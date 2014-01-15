using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Helpers
{
    public class DBUtils
    {
        

        public static DataTable ExecDataTableQuery(string sConnect, string pQueryString)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(sConnect);
                SqlCommand cmd = new SqlCommand(pQueryString, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();                    
                    //da.FillSchema(dt, SchemaType.Mapped);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static int ExecQuery(string sConnect, string pQueryString)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(sConnect);
                SqlCommand cmd = new SqlCommand(pQueryString, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int ExecSP(string sConnect, string pSPName, List<SqlParameter> pParams)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(sConnect);
                SqlCommand cmd = new SqlCommand(pSPName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //add parameters
                if (pParams != null)
                {
                    foreach (SqlParameter param in pParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
