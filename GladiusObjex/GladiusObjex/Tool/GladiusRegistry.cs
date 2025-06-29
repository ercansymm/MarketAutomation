using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Tool
{
    public class GladiusRegistry : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public static string RegistryYaz(string Klasor, string pKey, string pValue)
        {
            try
            {
                RegistryKey masterKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\GLADIUS\\" + Klasor);

                masterKey.SetValue(pKey, pValue);
                masterKey.Close();
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string RegistryOku(string Klasor, string pKey)
        {
            string rtn = "";
            try
            {
                RegistryKey regKey1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\GLADIUS\\" + Klasor);

                var a = regKey1.GetValue(pKey);

                if (a != null)
                    rtn = a.ToString();
            }
            catch (Exception)
            {
                return "";
            }

            return rtn;


        }
    }
}
