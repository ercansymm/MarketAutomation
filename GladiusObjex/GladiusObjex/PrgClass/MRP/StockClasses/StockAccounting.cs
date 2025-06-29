using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockAccounting:gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private string _AbroadPuchaseCode;
        [Display(Name = "Y.Dışı Alış Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string AbroadPuchaseCode { get => _AbroadPuchaseCode; set { _AbroadPuchaseCode = value; SetUpdated("AbroadPuchaseCode", value); } }

        private string _AbroadSalesCode;
        [Display(Name = "Y.Dışı Satış Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string AbroadSalesCode { get => _AbroadSalesCode; set { _AbroadSalesCode = value; SetUpdated("AbroadSalesCode", value); } }

        private string _PurchaseCode;
        [Display(Name = "Alış Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string PurchaseCode { get => _PurchaseCode; set { _PurchaseCode = value; SetUpdated("PurchaseCode", value); } }

        private string _CalcKDVCode;
        [Display(Name = "Hesaplanan KDV Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CalcKDVCode { get => _CalcKDVCode; set { _CalcKDVCode = value; SetUpdated("CalcKDVCode", value); } }

        private string _DiscountCode;
        [Display(Name = "İskonto Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string DiscountCode { get => _DiscountCode; set { _DiscountCode = value; SetUpdated("DiscountCode", value); } }

        private string _DiscountKDVCode;
        [Display(Name = "İndirilecek KDV Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string DiscountKDVCode { get => _DiscountKDVCode; set { _DiscountKDVCode = value; SetUpdated("DiscountKDVCode", value); } }

        private string _PurchaseReturnCode;
        [Display(Name = "Alış İade Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string PurchaseReturnCode { get => _PurchaseReturnCode; set { _PurchaseReturnCode = value; SetUpdated("PurchaseReturnCode", value); } }

        private string _SalesAccCode;
        [Display(Name = "Satış Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SalesAccCode { get => _SalesAccCode; set { _SalesAccCode = value; SetUpdated("SalesAccCode", value); } }

        private string _SalesReturnCode;
        [Display(Name = "Satış İade Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SalesReturnCode { get => _SalesReturnCode; set { _SalesReturnCode = value; SetUpdated("SalesReturnCode", value); } }

        private string _TevkifatAccCode;
        [Display(Name = "Satış İade Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string TevkifatAccCode { get => _TevkifatAccCode; set { _TevkifatAccCode = value; SetUpdated("TevkifatAccCode", value); } }


        private string _SystemStockCode;
        [Display(Name = "Sistem Hes.Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SystemStockCode { get => _SystemStockCode; set { _SystemStockCode = value; SetUpdated("SystemStockCode", value); } }


        public StockAccounting()
        {
            TableName = "StockAccounting";

            Columns.Add(new ObjColumn("AbroadPuchaseCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("AbroadSalesCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PurchaseCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CalcKDVCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DiscountCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DiscountKDVCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PurchaseReturnCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SalesAccCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SalesReturnCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TevkifatAccCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SystemStockCode", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.AbroadPuchaseCode = "";
            this.AbroadSalesCode = "";
            this.PurchaseCode = "";
            this.CalcKDVCode = "";
            this.DiscountCode = "";
            this.DiscountKDVCode = "";
            this.PurchaseReturnCode = "";
            this.SalesAccCode = "";
            this.SalesReturnCode = "";
            this.TevkifatAccCode = "";
            this.SystemStockCode = "";
        }
    }
}
