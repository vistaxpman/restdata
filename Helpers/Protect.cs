using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using AutoBrowser;

namespace Helpers
{
    public class Protect
    {
        public static string EncryptString(string Message)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(ConfigData.ENCRYPT_SECRET_STRING));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(ConfigData.ENCRYPT_SECRET_STRING));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }
        
        public static object ToDataType(object pData, Type pType, object pDefaultValue)
        {
            return ToDataType(pData, pType, pDefaultValue, System.Globalization.CultureInfo.CurrentCulture);
        }

        public static object ToDataType(object pData, Type pType, object p_pDefaultValue, IFormatProvider pProvider)
        {
            if (pData == null)
                return p_pDefaultValue;
            try
            {
                return Convert.ChangeType(pData, pType, pProvider);
            }
            catch
            {
                return p_pDefaultValue;
            }
        }

        public static string ToString(object pData)
        {
            return ToDataType(pData, typeof(string), string.Empty).ToString();
        }

        public static int ToInt32(object pData)
        {
            return ToInt32(pData, -1);
        }

        public static int ToInt32(object pData, int pDefaultValue)
        {
            return (int)ToDataType(pData, typeof(int), pDefaultValue);
        }

        public static long ToInt64(object pData, long pDefaultValue)
        {
            return (long)ToDataType(pData, typeof(long), pDefaultValue);
        }

        public static bool ToBoolean(object pData, bool pDefaultValue)
        {
            return (bool)ToDataType(pData, typeof(bool), pDefaultValue);
        }

        public static double ToDouble(object pData, double pDefaultValue)
        {
            return Convert.ToDouble(string.Format("{0:0.00}", (double)ToDataType(pData, typeof(double), pDefaultValue)));
        }

        public static decimal ToDecimal(object pData, decimal pDefaultValue)
        {
            return (decimal)ToDataType(pData, typeof(decimal), pDefaultValue);
        }

        public static DateTime ToDateTime(object pData, string pFormat, DateTime pDefaultValue)
        {
            try
            {
                return DateTime.ParseExact(pData.ToString(), pFormat, System.Globalization.CultureInfo.CurrentCulture);
            }
            catch
            {
                return pDefaultValue;
            }
        }

        public static DateTime ToDateTime(object pData, DateTime pDefaultValue)
        {
            return (DateTime)ToDataType(pData, typeof(DateTime), pDefaultValue);
        }

        public static DateTime ToDateTime(DateTime pBaseDateTime, TimeSpan pOffset)
        {
            DateTime dt = pBaseDateTime;
            dt = dt.AddMilliseconds(pOffset.TotalMilliseconds);

            return dt;
        }

        public static byte ToByte(object pData, byte pDefaultValue)
        {
            return (byte)ToDataType(pData, typeof(byte), pDefaultValue);
        }

        public static string UserName(object pData)
        {
            if (pData == null)
            {
                return string.Empty;
            }
            string username = Protect.ToString(pData).Trim().ToLower();
            if (username.IndexOf("\\") >= 0)
            {
                username = Protect.ToString(username.Split('\\')[1]);
            }
            return username;
        }

        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };

        public static string RemoveVNString(string str)
        {
            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;
        }
    }
}
