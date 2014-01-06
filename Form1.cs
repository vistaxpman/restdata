using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using OpenQA.Selenium.Firefox;
using Helpers;
using System.Configuration;
using System.IO;
using AutoBrowser.DataInfo;
using System.Collections;
using System.Threading.Tasks;
using System.Net;
namespace AutoBrowser
{
    public partial class Form1 : Form
    {
        private string sqlConnection = ConfigurationManager.AppSettings["SqlConnection"];
        private string startup_path = System.Windows.Forms.Application.StartupPath;
        private string out_folder = string.Format(ConfigurationManager.AppSettings["OutFolder"], DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        private string sql_get_table_info = @"
        SELECT clm.*, 'PRIMARY_KEY' = 
        ( 
	        select (case when column_name is null then '0' else '1' end) [data]
	        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
	        WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 
	        AND table_name = '{0}' and column_name = clm.COLUMN_NAME
        )
        FROM INFORMATION_SCHEMA.COLUMNS clm 
        WHERE clm.table_name = '{1}' ORDER BY clm.ordinal_position";
        private string sql_get_all_table_hs2 = "SELECT * FROM sys.tables where name like '%HS2%'";

        private string sql_get_all_table_dms = "SELECT * FROM sys.tables where name not like 'Delete%' order by Name";

        private const string CUSTOM_COLUMN = "list_colum.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(out_folder))
            {
                Directory.CreateDirectory(out_folder);
            }

            // select event select all for textbox control
            TextBox[] list_textbox = new TextBox[] { txtStoreProcedure, txtSPResult, txtBindData, txtInputText, txtOutputText, textBoxCustomColumn };
            foreach (var item_textbox in list_textbox)
            {
                item_textbox.ScrollBars = ScrollBars.Both;
                item_textbox.KeyDown += new KeyEventHandler(Textbox_KeyDown_Event);
            }
            LoadCustomColumn();

            textBoxCustomColumn.ShortcutsEnabled = false;
            
            //textBoxCustomColumn.ContextMenu = contextMenuStrip1.;
            
        }

        private void Textbox_KeyDown_Event(object sender, KeyEventArgs e)
        {
            Commons.SetKeyDownSelectFotExtBox(sender, e);
        }

        private void btnGeneration_Click(object sender, EventArgs e)
        {
            string sConnect = txtInput.Text.Trim();
            if (!String.IsNullOrEmpty(sConnect))
            {
                StringBuilder result = new StringBuilder();
                string[] lst = sConnect.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(l => l.Trim()).ToArray();
                foreach (var item in lst)
                {
                    result.AppendLine(Commons.EncyptConnectionString(item));
                }
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please input your connection");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string sConnect = txtInput.Text.Trim();
            if (!String.IsNullOrEmpty(sConnect))
            {
                StringBuilder result = new StringBuilder();
                string[] lst = sConnect.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(l => l.Trim()).ToArray();
                foreach (var item in lst)
                {
                    result.AppendLine(Commons.DecryptConnectionString(item));
                }
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please input your connection");
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            string sConnect = txtResult.Text.Trim();
            if (!String.IsNullOrEmpty(sConnect))
            {
                Clipboard.SetText(sConnect);
                toolStripStatusLabelMessage.Text = "Your connection string has been connect to your clipboard...";
            }
            else
            {
                MessageBox.Show("Please input your connection");
            }
        }

        private void btnGenDynamicClass_Click(object sender, EventArgs e)
        {
            // lấy toàn bộ bảng có tiền tố HS2 trong database DMS_TEST_HS2
            DataTable dt_all_table = DBUtils.ExecDataTableQuery(sqlConnection, sql_get_all_table_hs2);
            if (dt_all_table != null && dt_all_table.Rows.Count > 0)
            {
                foreach (DataRow item in dt_all_table.Rows)
                {
                    string table_name = Protect.ToString(item["name"]);
                    string class_data = TemplateFile.CLASS_TEMPLATE;
                    class_data = class_data.Replace("{__CLASS__NAME__}", table_name);
                    // lấy cấu trúc bảng 
                    if (!String.IsNullOrEmpty(table_name))
                    {
                        // class 
                        StringBuilder sb_class = new StringBuilder();
                        string template_file = TemplateFile.CLASS_TEMPLATE;
                        string table_info = string.Format(sql_get_table_info, table_name, table_name);

                        // store procedure
                        string store_procedure = TemplateFile.DATABIND_INFO;

                        DataTable dt_table_info = DBUtils.ExecDataTableQuery(sqlConnection, table_info);
                        if (dt_table_info != null && dt_table_info.Rows.Count > 0)
                        {
                            foreach (DataRow item_tb_info in dt_table_info.Rows)
                            {
                                string column_name = Protect.ToString(item_tb_info["COLUMN_NAME"]);
                                string column_datatype = Protect.ToString(item_tb_info["DATA_TYPE"]);
                                string datatype = Commons.TypeMappings.ContainsKey(column_datatype) ? Commons.TypeMappings[column_datatype] : "string";
                                string property_template = TemplateFile.CLASS_PROPERTY;
                                property_template = property_template.Replace("{__DATATYPE__}", datatype);
                                property_template = property_template.Replace("{__COLUMN__NAME__}", column_name);
                                if (sb_class.Length > 0)
                                {
                                    sb_class.Append("\t\t");
                                }
                                sb_class.AppendLine(property_template);
                                // tạo template
                            }
                        }
                        // lưu ra file 
                        class_data = class_data.Replace("{__CLASS__PROPERTY__}", sb_class.ToString());
                        string file_name = table_name + ".cs";
                        string file_name_path = out_folder + file_name;
                        FileUtils.WriteFile(file_name_path, class_data);
                    }
                    break;
                }
                MessageBox.Show("Complete");
            }
        }

        private void btnGenXML_Click(object sender, EventArgs e)
        {
            string folder_gen_xml = @"D:\norman\_ Selenium\MiniTool\MiniTools\AutoBrowser\xml_folder";

            // read all folder 
            DirectoryInfo dirInfo = new DirectoryInfo(folder_gen_xml);
            var all_folder = dirInfo.EnumerateDirectories().OrderBy(d => d.Name);
            if (all_folder != null && all_folder.Count() > 0)
            {
                foreach (var item in all_folder)
                {

                }
            }
        }

        private void btnGetAllTable_Click(object sender, EventArgs e)
        {
            DataTable dt_table_info = DBUtils.ExecDataTableQuery(sqlConnection, sql_get_all_table_dms);
            if (dt_table_info != null && dt_table_info.Rows.Count > 0)
            {
                foreach (DataRow item in dt_table_info.Rows)
                {
                    comboBoxListTables.Items.Add(new ComboboxItem
                    {
                        Text = Protect.ToString(item["name"].ToString()).Trim(),
                        Value = Protect.ToString(item["name"].ToString()).Trim()
                    });
                }
            }
            comboBoxListTables.SelectedIndex = 0;
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {
            bool using_custom_column = checkBoxCustomColumn.Checked;
            const int BufferSize = 128;
            Hashtable dtHash = new Hashtable();
            if (using_custom_column)
            {
                using (var fileStream = File.OpenRead(CUSTOM_COLUMN))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                    {
                        // Process line
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            dtHash.Add(line.ToLower(), line.ToLower());
                        }
                    }
                }
            }
            ComboboxItem table_obj = (ComboboxItem)comboBoxListTables.SelectedItem;
            if (table_obj != null)
            {
                string table_name = Protect.ToString(table_obj.Text).Trim();
                if (!String.IsNullOrEmpty(table_name))
                {
                    string table_info = string.Format(sql_get_table_info, table_name, table_name);
                    DataTable dt_table_info = DBUtils.ExecDataTableQuery(sqlConnection, table_info);
                    if (dt_table_info != null && dt_table_info.Rows.Count > 0)
                    {
                        // class 
                        string class_data = TemplateFile.CLASS_TEMPLATE;
                        class_data = class_data.Replace("{__CLASS__NAME__}", table_name);
                        StringBuilder sb_class = new StringBuilder();
                        string template_file = TemplateFile.CLASS_TEMPLATE;

                        // databind 
                        StringBuilder sb_bindata = new StringBuilder();

                        // store procedure 
                        StringBuilder sb_store_procedure = new StringBuilder();

                        foreach (DataRow item_tb_info in dt_table_info.Rows)
                        {
                            string is_nullable = Protect.ToString(item_tb_info["IS_NULLABLE"]);
                            string column_name = Protect.ToString(item_tb_info["COLUMN_NAME"]);

                            // if we using custom column
                            if (using_custom_column)
                            {
                                if (!dtHash.ContainsKey(column_name.ToLower()))
                                {
                                    continue;
                                }
                            }

                            string col_temp = Protect.ToString(item_tb_info["COLUMN_NAME"]);
                            string primary_key = Protect.ToString(item_tb_info["PRIMARY_KEY"]);
                            column_name = column_name.Replace("  ", " ");
                            column_name = column_name.Replace(" ", "_");
                            string column_datatype = Protect.ToString(item_tb_info["DATA_TYPE"]);
                            string datatype = Commons.TypeMappings.ContainsKey(column_datatype) ? Commons.TypeMappings[column_datatype] : "string";
                            string bind_data = Commons.ColumnMapping.ContainsKey(column_datatype) ? Commons.ColumnMapping[column_datatype] : Commons.ColumnMapping["nvarchar"]; ;
                            bind_data = bind_data.Replace("{__COLUMN__NAME__}", column_name);
                            bind_data = bind_data.Replace("{__COLUMN__NAME__INFO__}", col_temp);
                            if (!String.IsNullOrEmpty(primary_key))
                            {
                                datatype = "int"; // column is primary key
                            }
                            else
                            {
                                if (is_nullable == "YES")
                                {
                                    datatype = Commons.TypeMappings[column_datatype + "_null"];
                                }
                            }

                            string bind_data_template = TemplateFile.DATABIND_INFO;
                            bind_data_template = bind_data_template.Replace("{__COLUMN__NAME__}", column_name);
                            bind_data_template = bind_data_template.Replace("{__INFO__DATA__}", bind_data);

                            string property_template = TemplateFile.CLASS_PROPERTY;
                            property_template = property_template.Replace("{__DATATYPE__}", datatype);
                            property_template = property_template.Replace("{__COLUMN__NAME__}", column_name);
                            if (sb_class.Length > 0)
                            {
                                sb_class.Append("\t\t");
                            }
                            sb_class.AppendLine(property_template);
                            sb_bindata.AppendLine(bind_data_template);

                        }
                        class_data = class_data.Replace("{__CLASS__PROPERTY__}", sb_class.ToString());
                        txtStoreProcedure.Text = class_data;
                        txtBindData.Text = sb_bindata.ToString();
                        string file_name = table_name + ".cs";
                        string file_name_path = out_folder + file_name;
                        FileUtils.WriteFile(file_name_path, class_data);
                    }
                }
                MessageBox.Show("Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select table for creating dynamic data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text.ToString();
            if (!String.IsNullOrEmpty(input))
            {
                if (radioButtonSplit.Checked)
                {
                    txtOutputText.Lines = input.Split(new string[] { textBoxSplitJoinText.Text }, StringSplitOptions.RemoveEmptyEntries).Select(l => l.Trim()).ToArray();
                }
                else if (radioButtonJoin.Checked)
                {
                    string include_text = txtIncludeText.Text.Trim();
                    string[] lst = input.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(l => string.Concat(include_text, l.Trim(), include_text)).ToArray();
                    //if (txtIncludeText.Text.Trim() != string.Empty)
                    //{
                    //    string include_text = txtIncludeText.Text.Trim();
                    //    //txtOutputText.Text = string.Join(string.Concat(include_text, textBoxSplitJoinText.Text, include_text) + " ", lst);
                    //    foreach (var item in lst)
                    //    {
                    //        if (txtOutputText.Text.IndexOf(textBoxSplitJoinText.Text) >= 0)
                    //        {
                    //            txtOutputText.Text += textBoxSplitJoinText.Text;
                    //        }
                    //        txtOutputText.Text += string.Concat(include_text, item, include_text);
                    //    }
                    //}
                    //else
                    //{
                    //    txtOutputText.Text = string.Join(textBoxSplitJoinText.Text + " ", lst);
                    //}
                    txtOutputText.Text = string.Join(textBoxSplitJoinText.Text + " ", lst);
                }
            }
            else
            {
                MessageBox.Show("Please input your data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            Commons.SetKeyDownSelectFotExtBox(sender, e);
        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            Commons.SetKeyDownSelectFotExtBox(sender, e);
        }

        private void LoadCustomColumn()
        {
            const int BufferSize = 128;
            StringBuilder result = new StringBuilder();
            using (var fileStream = File.OpenRead(CUSTOM_COLUMN))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    // Process line
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        result.AppendLine(line.Trim());
                    }
                }
            }
            textBoxCustomColumn.Text = result.ToString();
        }

        /*
         string url = "http://localhost:51432/User/LogIn?ReturnUrl=%2f";
            IWebDriver driver = new FirefoxDriver();
            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // find button with id = "btnSignIn"
            //for (int i = 0; i < 5; i++)
            //{
            //    driver.FindElement(By.Id("btnSignIn")).SendKeys(OpenQA.Selenium.Keys.Enter);
            //    MessageBox.Show("Click: " + i);
            //}
            driver.FindElement(By.Id("user_name")).SendKeys("nghia.nguyendinh");
            driver.FindElement(By.Id("password")).SendKeys("");
            driver.FindElement(By.Id("btnSignIn")).SendKeys(OpenQA.Selenium.Keys.Enter);
         
         */



        /*************************************************** Upload File **********/

        private void UploadFileToWeb()
        {
            WebClient wdUpload = new WebClient();
            //wdUpload.UploadData()
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButtonJoin_CheckedChanged(object sender, EventArgs e)
        {
            txtIncludeText.Enabled = true;
        }

        private void radioButtonSplit_CheckedChanged(object sender, EventArgs e)
        {
            txtIncludeText.Enabled = false;
        }


    }
}
