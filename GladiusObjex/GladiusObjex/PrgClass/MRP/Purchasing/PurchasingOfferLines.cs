using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
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
    public class PurchasingOfferLines:gsBase
    {
        private int _LineNumber;
        public int LineNumber { get => _LineNumber; set { _LineNumber = value; SetUpdated("LineNumber", value); } }

        private Guid _PurchasingOfferRef;
        public Guid PurchasingOfferRef { get => _PurchasingOfferRef; set { _PurchasingOfferRef = value; SetUpdated("PurchasingOfferRef", value); } }

        private string _StockName;
        [Display(Name = "Stok Adı")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string StockName { get => _StockName; set { _StockName = value; SetUpdated("StockName", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        [ForeignKey("PurchasingOfferRef")]
        public virtual PurchasingOffer PurchasingOffer { get; set; }

        public PurchasingOfferLines()
        {
            TableName = "PurchasingOfferLines";

            Columns.Add(new ObjColumn("LineNumber", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("PurchasingOfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));


            this.Ref = Guid.NewGuid();
            this.PurchasingOfferRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.Description = "";
            this.LineNumber = 1;
            this.StockName = "";
            this.StockRef = Guid.Empty;
        }
    }
}
