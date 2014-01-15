using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using AutoBrowser;

namespace Helpers
{
    public class Commons
    {
        /// <summary>
        /// Return generated string
        /// </summary>
        /// <param name="pStartWith">Ex: HT, AA or XYZ. It can be empty.</param>
        /// <param name="pCurrentNum">Ex: 123, 3434, 2. It should be greater 0.</param>
        /// <param name="pLength">string lenth you want to have. Ex: 7, result will be HT0000123 for example.</param>
        /// <returns></returns>
        public static string GenerateCodeString(string pStartWith, int pCurrentNum, int pLength)
        {
            if (pLength <= 0 || pCurrentNum <= 0)
                return pStartWith;
            string result = string.Empty;
            int gene = pLength;
            if (!string.IsNullOrEmpty(pStartWith))
                gene = pLength - pStartWith.Length;
            string str = new string('0', gene);
            result = pStartWith + str + pCurrentNum;
            return result;
        }

        /// <summary>
        /// Check and return data type. Types: 2(All), 1(Active), 0(Pending), -1(Inactive)
        /// </summary>
        /// <param name="p_status"></param>
        /// <returns></returns>
        /// 
        public static Int16 GetDataStatus(Status pStatus)
        {
            Int16 status = -1000;
            switch (pStatus)
            {
                case Status.All:
                    {
                        status = 2;
                        break;
                    }
                case Status.Active:
                    {
                        status = 1;
                        break;
                    }
                case Status.Inactive:
                    {
                        status = -1;
                        break;
                    }
                case Status.Pending:
                    {
                        status = 0;
                        break;
                    }
            }
            return status;
        }

        public static string GetGender(int value)
        {
            string gender = string.Empty;
            switch (value)
            {
                case 1: gender = "Nam";
                    break;
                case 2: gender = "Nữ";
                    break;
            }
            return gender;
        }

        public static string CurrencyFormat(object pValue, bool pAddCurrencyUnit)
        {
            string result = string.Empty;
            double currency = Protect.ToDouble(pValue, 0);
            string[] decimal_type = null;
            string minus_char = "";
            if (currency != 0)
            {
                if (currency < 0)
                {
                    minus_char = "-";
                    currency = currency * -1;
                }
                decimal_type = currency.ToString().Split(ConfigData.MONEY_DECIMAL_SEP_MARK[0]);
                if (decimal_type != null)
                {
                    string[] int_type = decimal_type[0].ToString().Split(ConfigData.MONEY_THOUSAND_SEP_MARK[0]);
                    if (int_type != null)
                    {
                        string addValue = string.Empty;
                        if (int_type.Length > 1)
                        {
                            addValue = Protect.ToString(int_type[1]);
                        }
                        string mainValue = Protect.ToString(int_type[0]);
                        if (!string.IsNullOrEmpty(mainValue))
                        {
                            string mainResult = string.Empty;
                            int count = 1;
                            for (int index = mainValue.Length - 1; index >= 0; index--)
                            {
                                mainResult = mainValue[index].ToString() + mainResult;
                                if (count == 3 && index > 0)
                                {
                                    mainResult = ConfigData.MONEY_THOUSAND_SEP_MARK + mainResult;
                                    count = 1;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            result = mainResult;
                        }
                        result += addValue;
                    }
                }
                result = minus_char + result;
            }
            else
                result = "0";
            if (decimal_type != null)
            {
                if (decimal_type.Length > 1)
                {
                    result += ConfigData.MONEY_DECIMAL_SEP_MARK + decimal_type[1].ToString();
                    if (decimal_type[1].Length == 1)
                    {
                        result += "0";
                    }
                }
                else
                {
                    result += ".00";
                }
            }
            else
            {
                result += ".00";
            }
            result = result + (pAddCurrencyUnit == true ? " " + ConfigData.CURRENCY : string.Empty);
            return result;
        }

        public static string CurrencyNDFormat(object pValue, bool pAddCurrencyUnit)
        {
            string result = string.Empty;
            double currency = Protect.ToDouble(pValue, 0);
            string[] decimal_type = null;
            if (currency > 0)
            {
                decimal_type = currency.ToString().Split(ConfigData.MONEY_DECIMAL_SEP_MARK[0]);
                if (decimal_type != null)
                {
                    string[] int_type = decimal_type[0].ToString().Split(ConfigData.MONEY_THOUSAND_SEP_MARK[0]);
                    if (int_type != null)
                    {
                        string addValue = string.Empty;
                        if (int_type.Length > 1)
                        {
                            addValue = Protect.ToString(int_type[1]);
                        }
                        string mainValue = Protect.ToString(int_type[0]);
                        if (!string.IsNullOrEmpty(mainValue))
                        {
                            string mainResult = string.Empty;
                            int count = 1;
                            for (int index = mainValue.Length - 1; index >= 0; index--)
                            {
                                mainResult = mainValue[index].ToString() + mainResult;
                                if (count == 3 && index > 0)
                                {
                                    mainResult = ConfigData.MONEY_THOUSAND_SEP_MARK + mainResult;
                                    count = 1;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            result = mainResult;
                        }
                        result += addValue;
                    }
                }
            }
            else
                result = "0";
            result = result + (pAddCurrencyUnit == true ? " " + ConfigData.CURRENCY : string.Empty);
            if (decimal_type != null)
            {
                if (decimal_type.Length > 1)
                {
                    result += ConfigData.MONEY_DECIMAL_SEP_MARK + decimal_type[1].ToString();
                    if (decimal_type[1].Length == 1)
                    {
                        result += "0";
                    }
                }
                else
                {
                    //result += ".00";
                }
            }
            else
            {
                //result += ".00";
            }
            return result;
        }

        public static string DateTimeFormat(object pDateTimeString, bool pFullTime)
        {
            if (pDateTimeString == null)
                return string.Empty;
            string date_result = string.Empty;
            if (pDateTimeString.ToString() == string.Empty || pDateTimeString.ToString().IndexOf("0001") >= 0)
                return string.Empty;
            string format = pFullTime ? ConfigData.FORMAT_DATE_TIME : ConfigData.FORMAT_DATE;
            return ((DateTime)pDateTimeString).ToString(format).Replace('.', '/');
        }

        public static string DateTimeFormat(object pDateTimeString)
        {
            return DateTimeFormat(pDateTimeString, false);
        }

        /// <summary>
        /// Convert from dd/MM/yyyy to DateTime data for inserting to DB
        /// </summary>
        /// <param name="pDateString"></param>
        /// <returns></returns>
        public static DateTime DateTimeConvert(string pDateString)
        {
            string[] date = new string[3];
            if (pDateString == string.Empty)
                pDateString = DateTime.Now.ToString();
            date = pDateString.Split('/');
            DateTime date_result = new DateTime(Protect.ToInt32(date[2]), Protect.ToInt32(date[1]), Protect.ToInt32(date[0]), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return date_result;
        }

        public static string NumToWords(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] hang = new string[] { "", "Nghìn", "Triệu", "Tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "Một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "Lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "Lẻ " + str;
                        if (chuc == 1) str = "Mười " + str;
                        if (chuc > 1) str = so[chuc] + " Mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " Trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str;
        }

        public static string NumToWordsEnglish(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { " ", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] hang = new string[] { "", "Thousand", "Million", "Billion" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "One " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "" + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "And " + str;
                        if (chuc == 1) str = "ty " + str;
                        if (chuc > 1) str = so[chuc] + "ty " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " Hundred " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = " " + str;
            return str;
        }

        public static double RemoveMoneyMark(string pMoneyValue)
        {
            double result = 0.00;
            pMoneyValue = pMoneyValue.Trim();
            if (pMoneyValue != string.Empty)
            {
                pMoneyValue = pMoneyValue.Replace(ConfigData.MONEY_THOUSAND_SEP_MARK, string.Empty);
            }
            result = Protect.ToDouble(pMoneyValue, 0.00);
            return result;
        }

        public static string GetFileName(string pOriginFilename)
        {
            string result = string.Empty;
            int getFilenamePos = pOriginFilename.LastIndexOf("\\");
            if (getFilenamePos > 0)
            {
                return pOriginFilename.Substring(getFilenamePos + 1);
            }
            else
            {
                return pOriginFilename;
            }
        }

        public static void SendErrorEmail(Exception ex)
        {
            Mail mail = new Mail();
            mail.Subject = "Error message: " + ex.Message;
            string message = ex.Message;
            message += "<br/>Date: " + DateTime.Now;
            message += "<br/>Targe Site: " + ex.TargetSite.ToString();
            message += "<br/>Source: " + ex.Source;
            message += "<br/>Stack Trace: " + ex.StackTrace;
            mail.Body = message;
            mail.From = "dms@homecredit.vn";
            mail.To = "dms@homecredit.vn";
            mail.BCC = "dms@homecredit.vn";
            mail.Send();
        }

        public static List<DataItemInfo> HoursDDL()
        {
            List<DataItemInfo> list = new List<DataItemInfo>();
            DataItemInfo item = new DataItemInfo();
            item.text = string.Empty;
            item.value = string.Empty;
            list.Add(item);
            for (int i = 1; i <= 24; i++)
            {
                item = new DataItemInfo();
                item.text = i.ToString();
                item.value = i.ToString();
                list.Add(item);
            }
            return list;
        }

        public static List<DataItemInfo> MinutesDDL()
        {
            List<DataItemInfo> list = new List<DataItemInfo>();
            DataItemInfo item = new DataItemInfo();
            item.text = string.Empty;
            item.value = string.Empty;
            list.Add(item);
            for (int i = 1; i <= 59; i++)
            {
                item = new DataItemInfo();
                item.text = i.ToString();
                item.value = i.ToString();
                list.Add(item);
            }
            return list;
        }

        public static string GetRandomFileName()
        {
            int length = 10;
            // Get the GUID
            string guidResult = System.Guid.NewGuid().ToString();

            // Remove the hyphens
            guidResult = guidResult.Replace("-", string.Empty);

            // Make sure length is valid
            if (length <= 0 || length > guidResult.Length)
                throw new ArgumentException("Length must be between 1 and " + guidResult.Length);

            // Return the first length bytes
            return guidResult.Substring(0, length);
        }

        public static string ShowStatusTemplate(int? value)
        {
            string result = "";
            string color = "";
            switch (value)
            {
                case 1:
                    color = "#4d3efa";
                    break;
                case 0:
                    color = "#ffa677";
                    break;
                case -1:
                    color = "#ff000";
                    break;
            }
            result = (string.Format("<span style=\"color:{0}\">{1}</span>", color, XMLUtils.GetNodeDataByValue("status5", value.ToString())));
            return result;
        }

        public static string GenerateCode(string prefix, int length, string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prefix);
            if (length > id.Length)
            {
                for (int i = 0; i < length - id.ToString().Length; i++)
                {
                    sb.Append("0");
                }
            }
            sb.Append(id.ToString());
            return sb.ToString();
        }

        public static bool DeleteFile(string filePath, ref Exception exception)
        {
            if (!System.IO.File.Exists(filePath))
                return false;

            try
            {
                System.IO.File.Delete(filePath);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static string GenerateCodeNumber(string prefix, string input)
        {
            string result = "0000000";
            if (input != string.Empty)
            {
                int length_input = result.Length - input.Length;
                result = string.Format("{0}{1}{2}", prefix, result.Substring(0, length_input), input);
            }
            return result;
        }

        /// <summary>
        /// Get default image
        /// </summary>
        /// <param name="image_name"> Image name</param>
        /// <param name="type">Type image</param>
        /// <returns></returns>
        public static string GetImageDefaultIfEmpty(string image_name, int type)
        {
            string result = string.Empty;
            switch (type)
            {
                case 1: // small image
                    if (!String.IsNullOrEmpty(image_name))
                    {
                        result = image_name;
                    }
                    else
                    {
                        result = "no_image_small.jpg";
                    }
                    break;
                case 2: // large image
                    if (!String.IsNullOrEmpty(image_name))
                    {
                        result = image_name;
                    }
                    else
                    {
                        result = "no_image_large.jpg";
                    }
                    break;
                default:
                    if (!String.IsNullOrEmpty(image_name))
                    {
                        result = image_name;
                    }
                    else
                    {
                        result = "no_image_small.jpg";
                    }
                    break;
            }
            return result;
        }

        public static string ToCurrencyString(string value)
        {
            if (string.IsNullOrEmpty(value))
                return Protect.ToDecimal(value, 0).ToString(ConfigData.FORMAT_CURRENTCY) + " " + ConfigData.CURRENCY;
            return Protect.ToDecimal(value, 0).ToString(ConfigData.FORMAT_CURRENTCY) + " " + ConfigData.CURRENCY;
        }

        public static string RemoveHtmlTag(string content)
        {
            if (string.IsNullOrEmpty(content))
                return content;
            else
            {
                content = System.Text.RegularExpressions.Regex.Replace(content, @"<\s*?[^>]+\s*?>", "");
                return content.Trim();
            }
        }

        public static string GetScanDocStatus(int? status)
        {
            if (status == 0)
                return ConfigData.SCAN_STATUS_NEW;
            else if (status == 1)
                return ConfigData.SCAN_STATUS_CHECKING;
            else if (status == 2)
                return ConfigData.SCAN_STATUS_DONE;
            else if (status == 3)
                return ConfigData.SCAN_STATUS_REJECTED;
            else if (status == 4)
                return ConfigData.SCAN_STATUS_REUPLOAD;
            else if (status == -3)
                return ConfigData.SCAN_STATUS_PENDING;
            else if (status == -1)
                return ConfigData.SCAN_STATUS_CANCEL;
            return "";
        }

        public static string GetContracttatus(int status)
        {
            if (status == 0)
                return ConfigData.SCAN_STATUS_NEW;
            else if (status == 1)
                return ConfigData.SCAN_STATUS_CHECKING;
            else if (status == 2)
                return ConfigData.SCAN_STATUS_DONE;
            else if (status == 3)
                return ConfigData.SCAN_STATUS_REJECTED;
            else if (status == 4)
                return ConfigData.SCAN_STATUS_REUPLOAD;
            else if (status == -3)
                return ConfigData.SCAN_STATUS_PENDING;
            else if (status == -1)
                return ConfigData.SCAN_STATUS_CANCEL;
            return "";
        }


        public static int GetDuration(DateTime d)
        {
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - d;
            return ts.Days;
        }

        private static Random _random = new Random(Environment.TickCount);

        public static string RandomString(int length)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            System.Text.StringBuilder builder = new System.Text.StringBuilder(length);
            for (int i = 0; i < length; ++i)
            {
                builder.Append(chars[_random.Next(chars.Length)]);
            }
            return builder.ToString();
        }

        public static string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        public static string DecryptConnectionString(string sConnection)
        {
            return HttpUtility.HtmlDecode(Protect.DecryptString(sConnection));
        }

        public static string EncyptConnectionString(string sConnection)
        {
            return HttpUtility.HtmlDecode(Protect.EncryptString(sConnection));
        }

        public readonly static Dictionary<string, string> TypeMappings = new Dictionary<string, string>
        {
            { "bit","System.Nullable<bool>" },
            { "uniqueidentifier","System.Guid" },
            { "date","DateTime" },
            { "datetime","DateTime" },
            { "datetime2","DateTime" },
            { "smalldatetime","DateTime" },
            { "int","int" },
            { "smallint","short" },
            { "bigint","long" },
            { "varchar","string" },
            { "nchar","char" },
            { "char","char" },
            { "nvarchar","string" },
            { "text","string" },
            { "decimal", "decimal" },
            { "money", "decimal" },
            { "numeric", "decimal" },
            { "float", "double" },
            { "bit_null","System.Nullable<bool>" },
            { "uniqueidentifier_null","System.Guid" },
            { "int_null", "System.Nullable<int>" },
            { "smallint_null","short" },
            { "bigint_null","long" },
            { "varchar_null","string" },
            { "nchar_null","char" },
            { "char_null","char" },
            { "nvarchar_null","string" },
            { "text_null","string" },
            { "decimal_null", "System.Nullable<decimal>" },
            { "money_null", "decimal" },
            { "numeric_null", "System.Nullable<decimal>" },
            { "float_null", "System.Nullable<double>" },
            { "date_null","System.Nullable<System.DateTime>" },
            { "datetime_null","System.Nullable<System.DateTime>" },
            { "datetime2_null","System.Nullable<System.DateTime>" },
            { "smalldatetime_null","System.Nullable<System.DateTime>" }
        };

        public readonly static Dictionary<string, string> ColumnMapping = new Dictionary<string, string>
        {
            { "bit","info.{__COLUMN__NAME__} = Protect.ToBoolean(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), false);" },
            // { "uniqueidentifier","Guid" }, -- will support later
            { "date","info.{__COLUMN__NAME__} = Protect.ToDateTime(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), DateTime.Now);" },
            { "datetime","info.{__COLUMN__NAME__} = Protect.ToDateTime(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), DateTime.Now);" },
            { "datetime2","info.{__COLUMN__NAME__} = Protect.ToDateTime(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), DateTime.Now);" },
            { "smalldatetime","info.{__COLUMN__NAME__} = Protect.ToDateTime(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), DateTime.Now);" },
            { "int","info.{__COLUMN__NAME__} = Protect.ToInt32(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "numeric","info.{__COLUMN__NAME__} = Protect.ToInt32(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "smallint","info.{__COLUMN__NAME__} = Protect.ToInt32(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "bigint","info.{__COLUMN__NAME__} = Protect.ToInt64(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), 0);" },
            { "varchar","info.{__COLUMN__NAME__} = Protect.ToString(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "nchar","info.{__COLUMN__NAME__} = Protect.ToString(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" }, // check later
            { "char","info.{__COLUMN__NAME__} = Protect.ToString(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "nvarchar","info.{__COLUMN__NAME__} = Protect.ToString(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "text","info.{__COLUMN__NAME__} = Protect.ToString(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString());" },
            { "decimal", "info.{__COLUMN__NAME__} = Protect.ToDecimal(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), 0);" },
            { "money", "info.{__COLUMN__NAME__} = Protect.ToDecimal(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), 0);" },
            { "float", "info.{__COLUMN__NAME__} = Protect.ToDouble(dr.Rows[0][\"{__COLUMN__NAME__INFO__}\"].ToString(), 0);" }
        };


        public static string GetTypeName(SqlDbType Type)
        {
            string s = "System.String";
            switch (Type)
            {
                case SqlDbType.Int:
                    s = "System.Int32";
                    break;
                case SqlDbType.SmallInt:
                    s = "System.Int32";
                    break;
                case SqlDbType.TinyInt:
                    s = "System.Int32";
                    break;
                case SqlDbType.BigInt:
                    s = "System.Int64";
                    break;
                case SqlDbType.Bit:
                    s = "System.Boolean";
                    break;
                case SqlDbType.Decimal:
                    s = "System.Decimal";
                    break;
                case SqlDbType.Float:
                    s = "System.Single";
                    break;
                case SqlDbType.Money:
                    s = "System.Decimal";
                    break;
                case SqlDbType.SmallMoney:
                    s = "System.Decimal";
                    break;
                case SqlDbType.Real:
                    s = "System.Single";
                    break;
                case SqlDbType.DateTime:
                    s = "DateTime";
                    break;
                case SqlDbType.SmallDateTime:
                    s = "DateTime";
                    break;
                case SqlDbType.UniqueIdentifier:
                    s = "Guid";
                    break;
                default:
                    s = "System.String";
                    break;
            }
            return s;
        }

        public static void SetKeyDownSelectFotExtBox(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            System.Windows.Forms.TextBox txtKeyDown = (System.Windows.Forms.TextBox)sender;
            if (e.Control)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.A)
                {
                    txtKeyDown.SelectAll();
                }
                if (e.KeyCode == System.Windows.Forms.Keys.Back)
                {
                    e.SuppressKeyPress = true;
                    int selStart = txtKeyDown.SelectionStart;
                    while (selStart > 0 && txtKeyDown.Text.Substring(selStart - 1, 1) == " ")
                    {
                        selStart--;
                    }
                    int prevSpacePos = -1;
                    if (selStart != 0)
                    {
                        prevSpacePos = txtKeyDown.Text.LastIndexOf(' ', selStart - 1);
                    }
                    txtKeyDown.Select(prevSpacePos + 1, txtKeyDown.SelectionStart - prevSpacePos - 1);
                    txtKeyDown.SelectedText = "";
                }
            }
        }


    }
}
