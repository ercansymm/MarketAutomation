using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketautomation.SpecialClass
{
    public class BaseList
    {
        public Dictionary<int, string> AreaType()
        {
            Dictionary<int, string> lst = new Dictionary<int, string>();

            lst.Add(0, "Bahçe");
            lst.Add(1, "Salon 1");
            lst.Add(2, "Salon 2");
            lst.Add(3, "Salon 3");
            lst.Add(4, "Teras");

            return lst;
        }
        public Dictionary<int, string> EmployeeType()
        {
            Dictionary<int, string> lst = new Dictionary<int, string>();

            lst.Add(0, "Yönetici");
            lst.Add(1, "Kasiyer");
            lst.Add(2, "Garson");

            return lst;
        }

        public Dictionary<int, string> CaseType()
        {
            Dictionary<int, string> lst = new Dictionary<int, string>();

            lst.Add(0, "Nakit");
            lst.Add(1, "Kart");
            lst.Add(2, "Yemek Kartı");

            return lst;
        }


        public Dictionary<string, string> StockType()
        {
            
            Dictionary<string, string> lst = new Dictionary<string, string>();

            lst.Add("GRS", "Giriş");
            lst.Add("CKS", "Çıkış");

            return lst;
        }
    }
}
