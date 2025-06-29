using GladiusObjex.GKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.SystemClass
{
    

    [Serializable]
    public class UserFirmAuth
    {        

        [Serializable]
        public class Modul
        {
            public string ModulName { get; set; }
            public bool IsOk { get; set; }

            public Modul(string myModul, bool myOk)
            {
                ModulName = myModul; IsOk = myOk;
            }
        }

        [Serializable]
        public class Branch
        {
            public Guid Ref { get; set; }
            public string CardName { get; set; }
            public int IsOk { get; set; }

            public BindingList<WareHouse> WhList { get; set; }

            public Branch()
            {
                Ref = Guid.Empty;
                CardName = ""; IsOk = 0;
                WhList = new BindingList<WareHouse>();
            }
        }

        [Serializable]
        public class WareHouse
        {
            public Guid Ref { get; set; }
            public string CardName { get; set; }
            public int IsOk { get; set; }

            public WareHouse()
            {
                Ref = Guid.Empty;
                CardName = ""; IsOk = 0;
            }
        }

        [Serializable]
        public class Menu
        {
            public int MenuID { get; set; }
            public int MenuSubID { get; set; }
            public string MenuName { get; set; }
            public int Show { get; set; }
            public int Add { get; set; }
            public int Change { get; set; }
            public int Del { get; set; }

            public Menu()
            {
                MenuID = 0; MenuSubID = 0; MenuName = "";
                Show = 0; Add = 0; Change = 0; Del = 0;

            }
        }

        public BindingList<Branch> BranchList { get; set; }
        public BindingList<Modul> ModulList { get; set; }
        public BindingList<Menu> MenuList { get; set; }

        public UserFirmAuth()
        { }
        public UserFirmAuth(Guid FirmRef)
        {
            DbManager dbm = new DbManager(false, "erpConnStr");

            ModulList = new BindingList<Modul>();

            Modul ModulStok = new Modul("Stok", true);
            ModulList.Add(ModulStok);
            //Modul ModulFinans = new Modul("Finans", true);
            //ModulList.Add(ModulFinans);
            Modul ModulSatis = new Modul("Satış & Sipariş", true);
            ModulList.Add(ModulSatis);
            Modul ModulSatinAlma = new Modul("Satın Alma", false);
            ModulList.Add(ModulSatinAlma);
            Modul ModulUretim = new Modul("Üretim", false);
            ModulList.Add(ModulUretim);
            Modul ModulIdariIsler = new Modul("İdari İşler", false);
            ModulList.Add(ModulIdariIsler);
            Modul ModulRaporlar = new Modul("Raporlar", false);
            ModulList.Add(ModulRaporlar);
            Modul ModulEntegrasyon = new Modul("Entegrasyon", false);
            ModulList.Add(ModulEntegrasyon);
            Modul ModulAyarlar = new Modul("Ayarlar", false);
            ModulList.Add(ModulAyarlar);

            BranchList = new BindingList<Branch>();

            DataTable dt = dbm.ExecuteDataTable(String.Format("select Ref,CardName from Branches where FirmRef = '{0}'", FirmRef), CommandType.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Branch myBranch = new Branch();
                myBranch.Ref = Guid.Parse(dt.Rows[i]["Ref"].ToString());
                myBranch.CardName = dt.Rows[i]["CardName"].ToString();
                myBranch.IsOk = 1;

                DataTable dtWhouse = dbm.ExecuteDataTable(String.Format("select Ref, CardName from WareHouses where BranchRef = '{0}'",myBranch.Ref),CommandType.Text);

                for (int z = 0; z < dtWhouse.Rows.Count; z++)
                {
                    WareHouse myWhouse = new WareHouse();
                    myWhouse.Ref = Guid.Parse(dtWhouse.Rows[i]["Ref"].ToString());
                    myWhouse.CardName = dtWhouse.Rows[i]["CardName"].ToString();
                    myWhouse.IsOk = 1;

                    myBranch.WhList.Add(myWhouse);
                }

                BranchList.Add(myBranch);
                
            }

            MenuList = new BindingList<Menu>();

            string[] allLines = File.ReadAllLines("GladiusMenu.csv", Encoding.GetEncoding("iso-8859-9"));

            var query = allLines.Skip(0).Select((r, index) => new
            {
                i = index,
                Data = r.Split(';')
            }).ToList();

            for (int y = 0; y < query.Count; y++)
            {
                Menu myMenu = new Menu();
                myMenu.MenuID = int.Parse(query[y].Data[0].ToString());
                myMenu.MenuSubID = int.Parse(query[y].Data[1].ToString());
                myMenu.MenuName = query[y].Data[2].ToString();
                myMenu.Add = 1;
                myMenu.Show = 1;
                myMenu.Change = 1;
                myMenu.Del = 1;

                MenuList.Add(myMenu);
            }
        }
    }
}
