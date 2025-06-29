using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.EmployeeClasses
{
    public class EmployeeCard:gsBase
    {
        private Guid _EmpType;
        public Guid EmpType { get => _EmpType; set { _EmpType = value; SetUpdated("EmpType", value); } }

        private string _CardCode;
        [Display(Name = "Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private string _CardName;
        [Display(Name = "Temsilci Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _BranchRef;
        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private string _Phone;
        [Display(Name = "Telefon")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Phone { get => _Phone; set { _Phone = value; SetUpdated("Phone", value); } }

        private string _Email;
        [Display(Name = "Telefon")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Email { get => _Email; set { _Email = value; SetUpdated("Email", value); } }


        private string _Description;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _SpeCode1;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        private string _SpeCode2;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string SpeCode2 { get => _SpeCode2; set { _SpeCode2 = value; SetUpdated("SpeCode2", value); } }

        private string _SpeCode3;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string SpeCode3 { get => _SpeCode3; set { _SpeCode3 = value; SetUpdated("SpeCode3", value); } }

        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        private Guid _DepartmentRef;
        public Guid DepartmentRef { get => _DepartmentRef; set { _DepartmentRef = value; SetUpdated("DepartmentRef", value); } }

        public EmployeeCard getEmployee(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            EmployeeCard myEmployee = new EmployeeCard();

            myEmployee = mng.GetObject<EmployeeCard>(Ref);

            return myEmployee;
        }

        public EmployeeCard()
        {

            TableName = "EmployeeCard";

            Columns.Add(new ObjColumn("EmpType", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Phone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Email", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode3", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DepartmentRef", SqlDbType.UniqueIdentifier, "", false, false));

            Ref = Guid.NewGuid();
            this.EmpType = Guid.Empty;
            this.CardName = "";
            this.BranchRef = Guid.Empty;
            this.UserRef = Guid.Empty;
            this.Phone = "";
            this.Email = "";
            this.Description = "";
            this.SpeCode1 = "";
            this.SpeCode2 = "";
            this.SpeCode3 = "";
            this.CardCode = "";
            this.Barcode = "";
            this.IsPassive = true;
            this.Image = new byte[] { };
            this.DepartmentRef = Guid.Empty;
        }
    }
}
