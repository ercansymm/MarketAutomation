using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Netsis
{
    public class dmsDocument : gsBase
    {
        private string _code;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string code { get => _code; set { _code = value; SetUpdated("code", value); } }

        private string _name;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string name { get => _name; set { _name = value; SetUpdated("name", value); } }

        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }

        private int _categoriRef;
        public int categoriRef { get => _categoriRef; set { _categoriRef = value; SetUpdated("categoriRef", value); } }//. Örnek --Alış Faturası, Satış Faturası, Gümrük Evrağı, Teklif, Resmi Yazışma

        private int _departmentRef;
        public int departmentRef { get => _departmentRef; set { _departmentRef = value; SetUpdated("departmentRef", value); } }//Evrakın İlgili Departmanı

        private int _type;
        public int type { get => _type; set { _type = value; SetUpdated("type", value); } }
        //Evrak Tipi 0.Gelen Evrak   1.Giden Evrak

        private string _documentNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string documentNo { get => _documentNo; set { _documentNo = value; SetUpdated("documentNo", value); } }

        private DateTime _documentDate;
        public DateTime documentDate { get => _documentDate; set { _documentDate = value; SetUpdated("documentDate", value); } }

        private string _documentAccount;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string documentAccount { get => _documentAccount; set { _documentAccount = value; SetUpdated("documentAccount", value); } }

        private int _saveUser;
        public int saveUser { get => _saveUser; set { _saveUser = value; SetUpdated("saveUser", value); } }

        private DateTime _saveDate;
        public DateTime saveDate { get => _saveDate; set { _saveDate = value; SetUpdated("saveDate", value); } }

        private int _approvalState;
        public int approvalState { get => _approvalState; set { _approvalState = value; SetUpdated("approvalState", value); } }// Onay Durumu -- 0.Kontrol Edildi 1.Onay Tamamlandı

        private string _note;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(2500)]
        public string note { get => _note; set { _note = value; SetUpdated("note", value); } }

        private string _imagePath;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(2500)]
        public string imagePath { get => _imagePath; set { _imagePath = value; SetUpdated("imagePath", value); } }

        private Int16 _lock_;
        public Int16 lock_ { get => _lock_; set { _lock_ = value; SetUpdated("lock_", value); } }//Evrak Kilit Durumu   0.Açık   1.Kilitli

        public dmsDocument()
        {
            TableName = "dmsDocument";

            Columns.Add(new ObjColumn("code", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("name", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Date_", SqlDbType.DateTime, DateTime.Now, false, false));
            Columns.Add(new ObjColumn("categoriRef", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("departmentRef", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("type", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("documentNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("documentDate", SqlDbType.Date, DateTime.Now, false, false));
            Columns.Add(new ObjColumn("documentAccount", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("saveUser", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("saveDate", SqlDbType.DateTime, DateTime.Now, false, false));
            Columns.Add(new ObjColumn("approvalState", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("note", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("imagePath", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("lock_", SqlDbType.SmallInt, 0, false, false));

            this.saveUser = 0; this.saveDate = DateTime.Now; this.approvalState = 0; this.categoriRef = 0; this.code = ""; this.Date_ = DateTime.Now; this.documentDate = DateTime.Now; this.departmentRef = 0; this.documentAccount = ""; this.documentNo = ""; this.imagePath = ""; this.lock_ = 0; this.name = "";
            this.note = ""; this.Ref = Guid.NewGuid(); this.type = 0;
        }
    }
}
