using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Machine : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _TypeRef;
        public Guid TypeRef { get => _TypeRef; set { _TypeRef = value; SetUpdated("TypeRef", value); } }

        private string _MachineCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string MachineCode { get => _MachineCode; set { _MachineCode = value; SetUpdated("MachineCode", value); } }

        private string _MachineName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string MachineName { get => _MachineName; set { _MachineName = value; SetUpdated("MachineName", value); } }

        private string _Producer;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string Producer { get => _Producer; set { _Producer = value; SetUpdated("Producer", value); } }

        private DateTime _PurchaseDate;
        public DateTime PurchaseDate { get => _PurchaseDate; set { _PurchaseDate = value; SetUpdated("PurchaseDate", value); } }

        private string _SerialNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _DefaultPrinter;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string DefaultPrinter { get => _DefaultPrinter; set { _DefaultPrinter = value; SetUpdated("DefaultPrinter", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private decimal _WastageRate;
        public decimal WastageRate { get => _WastageRate; set { _WastageRate = value; SetUpdated("WastageRate", value); } }

        private string _Description;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _SpecialCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpecialCode { get => _SpecialCode; set { _SpecialCode = value; SetUpdated("SpecialCode", value); } }

        private string _SpecialCode1;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpecialCode1 { get => _SpecialCode1; set { _SpecialCode1 = value; SetUpdated("SpecialCode1", value); } }

        private string _SpecialCode2;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpecialCode2 { get => _SpecialCode2; set { _SpecialCode2 = value; SetUpdated("SpecialCode2", value); } }

        private byte[] _Images;

        [Display(Name = "Resim")]
        public byte[] Images { get => _Images; set { _Images = value; SetUpdated("Images", value); } }

        [NotMapped]
        public Image _myImage { get; set; }

        public BindingList<A_MachineReel> MachineReel { get; set; }

        public A_Machine()
        {
            TableName = "A_Machine";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("TypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MachineCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("MachineName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Producer", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PurchaseDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DefaultPrinter", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));           
            Columns.Add(new ObjColumn("WastageRate", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Images", SqlDbType.Image, null, false, false));

            this.Ref = Guid.NewGuid();            
            this.IsPassive = false;
            this.TypeRef = Guid.Empty;
            this.MachineCode = "";
            this.MachineName = "";
            this.Producer = "";
            this.PurchaseDate = DateTime.Now;
            this.SerialNo = "";
            this.DefaultPrinter = "";
            this.Barcode = "";
            this.WastageRate = 0;
            this.Description = "";
            this.SpecialCode = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.Images = new byte[] { };

            this.MachineReel = new BindingList<A_MachineReel>();
        }
    }
}
