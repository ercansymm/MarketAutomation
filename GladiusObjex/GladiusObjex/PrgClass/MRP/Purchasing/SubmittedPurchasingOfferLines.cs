using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class SubmittedPurchasingOfferLines:gsBase
    {
        private int _LineNumber;
        public int LineNumber { get => _LineNumber; set { _LineNumber = value; SetUpdated("LineNumber", value); } }

        private Guid _SubmittedPurchasingOfferRef;
        public Guid SubmittedPurchasingOfferRef { get => _SubmittedPurchasingOfferRef; set { _SubmittedPurchasingOfferRef = value; SetUpdated("SubmittedPurchasingOfferRef", value); } }

        private string _StockName;
        [Display(Name = "Stok Adı")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string StockName { get => _StockName; set { _StockName = value; SetUpdated("StockName", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private decimal _UnitTotalPrice;
        public decimal UnitTotalPrice { get => _UnitTotalPrice; set { _UnitTotalPrice = value; SetUpdated("UnitTotalPrice", value); } }

        private decimal _KDV;
        public decimal KDV { get => _KDV; set { _KDV = value; SetUpdated("KDV", value); } }

        private decimal _KDVTotal;
        public decimal KDVTotal { get => _KDVTotal; set { _KDVTotal = value; SetUpdated("KDVTotal", value); } }

        private decimal _GeneralTotal;
        public decimal GeneralTotal { get => _GeneralTotal; set { _GeneralTotal = value; SetUpdated("GeneralTotal", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private decimal _UnitPrice;
        public decimal UnitPrice { get => _UnitPrice; set { _UnitPrice = value; SetUpdated("UnitPrice", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _CoveredAmount;
        public decimal CoveredAmount { get => _CoveredAmount; set { _CoveredAmount = value; SetUpdated("CoveredAmount", value); } }

        [ForeignKey("SubmittedPurchasingOfferRef")]
        public virtual SubmittedPurchasingOffer PurchasingOffer { get; set; }

        public SubmittedPurchasingOfferLines()
        {
            TableName = "SubmittedPurchasingOfferLines";

            Columns.Add(new ObjColumn("LineNumber", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("SubmittedPurchasingOfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitTotalPrice", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KDV", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KDVTotal", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("GeneralTotal", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UnitPrice", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("StockName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CoveredAmount", SqlDbType.Decimal, "", false, false));

            this.Ref = Guid.NewGuid();
            this.SubmittedPurchasingOfferRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.UnitTotalPrice = 0;
            this.KDV = 0;
            this.KDVTotal = 0;
            this.GeneralTotal = 0;
            this.Description = "";
            this.LineNumber = 1;
            this.UnitPrice = 0;
            this.StockName = "";
            this.StockRef = Guid.Empty;
            this.CoveredAmount = 0;
        }
    }
}
