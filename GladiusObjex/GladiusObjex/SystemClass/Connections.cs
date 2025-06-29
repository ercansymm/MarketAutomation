using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace GladiusObjex.SystemClass
{
    public class Connections : gsBaseCard
    {
        private string _Server;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Server { get => _Server; set { _Server = value; SetUpdated("Server", value); } }

        private string _DbName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string DbName { get => _DbName; set { _DbName = value; SetUpdated("DbName", value); } }

        private string _UserName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string UserName { get => _UserName; set { _UserName = value; SetUpdated("UserName", value); } }

        private string _Password;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string Password { get => _Password; set { _Password = value; SetUpdated("Password", value); } }


        public static Connections GetConnection(Guid Ref)
        {
            Connections myCon = new Connections();
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            myCon = mng.GetObject<Connections>(Ref);
            myCon.Password = Tool.GladiusEnycription.Decrypt(myCon.Password,true,myCon.CardName);            

            return myCon;
        }

        [NotMapped]
        public string ConnStr { get; set; }

        public Connections()
        {
            TableName = "Connections";

            Columns.Add(new ObjColumn("Server", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DbName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Password", SqlDbType.NVarChar, "", false, false));

            this.Server = ""; this.DbName = ""; this.UserName = ""; this.Password = "";
        }
    }
}
