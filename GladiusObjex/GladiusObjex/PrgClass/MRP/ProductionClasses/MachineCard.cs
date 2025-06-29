using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.EmployeeClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class MachineCard:gsBase
    {

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private string _MachineCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string MachineCode { get => _MachineCode; set { _MachineCode = value; SetUpdated("MachineCode", value); } }

        private Guid _MachineTypeRef;
        public Guid MachineTypeRef { get => _MachineTypeRef; set { _MachineTypeRef = value; SetUpdated("MachineTypeRef", value); } }


        private Guid _MachinePlaceRef;
        public Guid MachinePlaceRef { get => _MachinePlaceRef; set { _MachinePlaceRef = value; SetUpdated("MachinePlaceRef", value); } }

        private Guid _MachineOperationRef;
        public Guid MachineOperationRef { get => _MachineOperationRef; set { _MachineOperationRef = value; SetUpdated("MachineOperationRef", value); } }

        private string _CardName;
        [Display(Name = "Makine Adı")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _Producer;
        [Display(Name = "Üretici")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string Producer { get => _Producer; set { _Producer = value; SetUpdated("Producer", value); } }

        private DateTime _Date;
        public DateTime Date { get => _Date; set { _Date = value; SetUpdated("Date", value); } }

        private string _SerialNo;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _Printer;
        [Display(Name = "Yazıcı")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string Printer { get => _Printer; set { _Printer = value; SetUpdated("Printer", value); } }

        private double _WasteRate;
        public double WasteRate { get => _WasteRate; set { _WasteRate = value; SetUpdated("WasteRate", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _SpeCode1;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        private string _SpeCode2;
        [Display(Name = "Özel Kod2")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode2 { get => _SpeCode2; set { _SpeCode2 = value; SetUpdated("SpeCode2", value); } }

        private string _SpeCode3;
        [Display(Name = "Özel Kod3")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode3 { get => _SpeCode3; set { _SpeCode3 = value; SetUpdated("SpeCode3", value); } }

        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }


        public MachineCard getMachine(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            MachineCard myMachine = new MachineCard();

            myMachine = mng.GetObject<MachineCard>(Ref);

            return myMachine;
        }

        public MachineCard()
        {

            TableName = "MachineCard";

            Columns.Add(new ObjColumn("MachineCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("MachineTypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Producer", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Date", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Printer", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WasteRate", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode3", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("MachinePlaceRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MachineOperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));

            Ref = Guid.NewGuid();

            this.MachineCode = "";
            this.MachineTypeRef = Guid.Empty;
            this.MachinePlaceRef = Guid.Empty;
            this.MachineOperationRef = Guid.Empty;
            this.CardName = "";
            this.Producer = "";
            this.Date = DateTime.Today;
            this.SerialNo = "";
            this.Printer = "";
            this.WasteRate = 0;
            this.Description = "";
            this.SpeCode1 = "";
            this.SpeCode2 = "";
            this.SpeCode3 = "";
            this.Barcode = "";
            this.Image = new byte[] { };
            this.IsPassive = true;
        }
    }
}
