using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Cassette : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _TypeRef;
        public Guid TypeRef { get => _TypeRef; set { _TypeRef = value; SetUpdated("TypeRef", value); } }

        private string _CasetteCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CasetteCode { get => _CasetteCode; set { _CasetteCode = value; SetUpdated("CasetteCode", value); } }

        private string _CasetteName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CasetteName { get => _CasetteName; set { _CasetteName = value; SetUpdated("CasetteName", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private decimal _Diameter;
        public decimal Diameter { get => _Diameter; set { _Diameter = value; SetUpdated("Diameter", value); } }

        public A_Cassette()
        {
            TableName = "A_Cassette";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("TypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CasetteCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CasetteName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Diameter", SqlDbType.Decimal, "", false, false));

            this.Ref = Guid.NewGuid();
            this.IsPassive = true;
            this.TypeRef = Guid.Empty;
            this.CasetteCode = "";
            this.CasetteName = "";
            this.Barcode = "";
            this.Diameter = 0;
        }
    }
}
