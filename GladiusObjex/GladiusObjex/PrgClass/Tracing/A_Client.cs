using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Client : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _GroupRef;
        public Guid GroupRef { get => _GroupRef; set { _GroupRef = value; SetUpdated("GroupRef", value); } }

        private string _ClientCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string ClientCode { get => _ClientCode; set { _ClientCode = value; SetUpdated("ClientCode", value); } }

        private string _ClientName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string ClientName { get => _ClientName; set { _ClientName = value; SetUpdated("ClientName", value); } }

        private string _TaxOffice;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string TaxOffice { get => _TaxOffice; set { _TaxOffice = value; SetUpdated("TaxOffice", value); } }

        private string _TaxNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string TaxNo { get => _TaxNo; set { _TaxNo = value; SetUpdated("TaxNo", value); } }

        private string _Address;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Address { get => _Address; set { _Address = value; SetUpdated("Address", value); } }

        private string _Phone;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string Phone { get => _Phone; set { _Phone = value; SetUpdated("Phone", value); } }

        private string _Fax;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string Fax { get => _Fax; set { _Fax = value; SetUpdated("Fax", value); } }

        private string _Mail;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Mail { get => _Mail; set { _Mail = value; SetUpdated("Mail", value); } }

        private string _LabelCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(5)]
        public string LabelCode { get => _LabelCode; set { _LabelCode = value; SetUpdated("LabelCode", value); } }

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

        public A_Client()
        {
            TableName = "A_Client";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("GroupRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ClientCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TaxOffice", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TaxNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Address", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Phone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Fax", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Mail", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LabelCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.ClientCode = "";
            this.ClientName = "";
            this.Description = "";
            this.TaxNo = "";
            this.TaxOffice = "";
            this.Address = "";
            this.Phone = "";
            this.Fax = "";
            this.Mail = "";
            this.LabelCode = "";
            this.SpecialCode = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.IsPassive = true;
            this.GroupRef = Guid.Empty;
        }
    }
}
