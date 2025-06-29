using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_ColdDraw : gsBase
    {
        private bool _IsContinuous;
        public bool IsContinuous { get => _IsContinuous; set { _IsContinuous = value; SetUpdated("IsContinuous", value); } }

        private int _IsState;
        public int IsState { get => _IsState; set { _IsState = value; SetUpdated("IsState", value); } }
        /*
         * 0 Bekliyor
         * 1 Başladı
         * 2 Bitti
         * 3 İptal
         */

        private string _SeriNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(5)]
        public string SeriNo { get => _SeriNo; set { _SeriNo = value; SetUpdated("SeriNo", value); } }

        private string _SerialNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(16)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private DateTime _ColdDate;
        public DateTime ColdDate { get => _ColdDate; set { _ColdDate = value; SetUpdated("ColdDate", value); } }

        private string _ColdName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string ColdName { get => _ColdName; set { _ColdName = value; SetUpdated("ColdName", value); } }

        private string _ColdType;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(5)]
        public string ColdType { get => _ColdType; set { _ColdType = value; SetUpdated("ColdType", value); } }
        /* STOCK    STOK
         * FIRMS    FİRMA
           PRDCT    ÜRETİM
        */

        private Guid _FirmRef;
        public Guid FirmRef { get => _FirmRef; set { _FirmRef = value; SetUpdated("FirmRef", value); } }

        private string _PoNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string PoNo { get => _PoNo; set { _PoNo = value; SetUpdated("PoNo", value); } }

        private decimal _Weight;
        public decimal Weight { get => _Weight; set { _Weight = value; SetUpdated("Weight", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private string _SpeNot;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string SpeNot { get => _SpeNot; set { _SpeNot = value; SetUpdated("SpeNot", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private string _Note;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Note { get => _Note; set { _Note = value; SetUpdated("Note", value); } }

        private bool _isCoil;
        public bool isCoil { get => _isCoil; set { _isCoil = value; SetUpdated("isCoil", value); } }

        public BindingList<A_ColdDrawDetail> ColdDetail { get; set; }
        public A_ColdDraw()
        {
            this.TableName = "A_ColdDraw";

            Columns.Add(new ObjColumn("IsContinuous", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("IsState", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("SeriNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ColdDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("ColdName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ColdType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("FirmRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PoNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Weight", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SpeNot", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Note", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("isCoil", SqlDbType.Bit, "", false, false));

            this.Ref = Guid.NewGuid();
            this.IsContinuous = false;
            this.IsState = 0;
            this.SerialNo = "";
            this.SeriNo = "A";
            this.ColdDate = DateTime.Today;
            this.ColdName = "";
            this.ColdType = "STOCK";
            this.FirmRef = Guid.Empty;
            this.PoNo = "";
            this.Weight = 0;
            this.MachineRef = Guid.Empty;
            this.SpeNot = "";
            this.UserRef = Guid.Empty;
            this.Note = "";
            this.isCoil = false;

            this.ColdDetail = new BindingList<A_ColdDrawDetail>();
        }
    }
}
