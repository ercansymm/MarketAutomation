using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Employee : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _TypeRef;
        public Guid TypeRef { get => _TypeRef; set { _TypeRef = value; SetUpdated("TypeRef", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private string _EmployeeCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string EmployeeCode { get => _EmployeeCode; set { _EmployeeCode = value; SetUpdated("EmployeeCode", value); } }

        private string _EmployeeName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string EmployeeName { get => _EmployeeName; set { _EmployeeName = value; SetUpdated("EmployeeName", value); } }

        private string _TcNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(11)]
        public string TcNo { get => _TcNo; set { _TcNo = value; SetUpdated("TcNo", value); } }

        private DateTime _WorkDate;
        public DateTime WorkDate { get => _WorkDate; set { _WorkDate = value; SetUpdated("WorkDate", value); } }

        private string _Phone;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string Phone { get => _Phone; set { _Phone = value; SetUpdated("Phone", value); } }

        private string _Address;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Address { get => _Address; set { _Address = value; SetUpdated("Address", value); } }

        private string _Mail;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string Mail { get => _Mail; set { _Mail = value; SetUpdated("Mail", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private string _Description;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
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

        public A_Employee()
        {
            TableName = "A_Employee";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("TypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("EmployeeCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EmployeeName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TcNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WorkDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("Phone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Address", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Mail", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Images", SqlDbType.Image, null, false, false));

            this.Ref = Guid.NewGuid();
            this.IsPassive = true;
            this.TypeRef = Guid.Empty;
            this.UserRef = Guid.Empty;
            this.EmployeeCode = "";
            this.EmployeeName = "";
            this.TcNo = "";
            this.WorkDate = DateTime.Today;
            this.Phone = "";
            this.Address = "";
            this.Mail = "";
            this.Barcode = "";
            this.Description = "";
            this.SpecialCode = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.Images = new byte[] { };
        }

    }
}
