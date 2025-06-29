using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Stock : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _QualityRef;
        public Guid QualityRef { get => _QualityRef; set { _QualityRef = value; SetUpdated("QualityRef", value); } }

        private Guid _TypeRef;
        public Guid TypeRef { get => _TypeRef; set { _TypeRef = value; SetUpdated("TypeRef", value); } }

        private string _StockCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string StockCode { get => _StockCode; set { _StockCode = value; SetUpdated("StockCode", value); } }

        private string _StockName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string StockName { get => _StockName; set { _StockName = value; SetUpdated("StockName", value); } }

        private string _ProducerCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ProducerCode { get => _ProducerCode; set { _ProducerCode = value; SetUpdated("ProducerCode", value); } }

        private string _ProducerStockCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ProducerStockCode { get => _ProducerStockCode; set { _ProducerStockCode = value; SetUpdated("ProducerStockCode", value); } }

        private string _ErpStockCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ErpStockCode { get => _ErpStockCode; set { _ErpStockCode = value; SetUpdated("ErpStockCode", value); } }

        private decimal _Diameter;
        public decimal Diameter { get => _Diameter; set { _Diameter = value; SetUpdated("Diameter", value); } }

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

        public A_Stock()
        {
            TableName = "A_Stock";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("QualityRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("TypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ProducerCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ProducerStockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ErpStockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Diameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.Diameter = 0;
            this.ErpStockCode = "";
            this.IsPassive = true;
            this.ProducerCode = "";
            this.ProducerStockCode = "";
            this.QualityRef = Guid.Empty;
            this.SpecialCode = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.StockCode = "";
            this.StockName = "";
            this.TypeRef = Guid.Empty;
        }
    }
}
