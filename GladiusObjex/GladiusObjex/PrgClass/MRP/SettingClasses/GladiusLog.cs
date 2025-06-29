using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.SettingClasses
{
    public class GladiusLog:gsBase
    {
        private string _MenuNo;
        [Display(Name = "Menü Numarası")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string MenuNo { get => _MenuNo; set { _MenuNo = value; SetUpdated("MenuNo", value); } }

        private Guid _MenuRef;
        public Guid MenuRef { get => _MenuRef; set { _MenuRef = value; SetUpdated("MenuRef", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private DateTime _LogDate;
        public DateTime LogDate { get => _LogDate; set { _LogDate = value; SetUpdated("LogDate", value); } }

        private string _LogAction;
        [Display(Name = "İşlem")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string LogAction { get => _LogAction; set { _LogAction = value; SetUpdated("LogAction", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(2000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }


        public GladiusLog getLog (Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            GladiusLog myLog = new GladiusLog();

            myLog = mng.GetObject<GladiusLog>(Ref);

            return myLog;
        }

        public GladiusLog()
        {
            TableName = "GladiusLog";

            Columns.Add(new ObjColumn("MenuNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("MenuRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LogDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("LogAction", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.MenuNo = "";
            this.MenuRef = Guid.Empty;
            this.UserRef = Guid.Empty;
            this.LogDate = DateTime.Now;
            this.LogAction = "";
            this.Description = "";
        }
    }
}
