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

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductionStockBarcodes:gsBase
    {
        private Guid _ProdTrackStockRef;
        public Guid ProdTrackStockRef { get => _ProdTrackStockRef; set { _ProdTrackStockRef = value; SetUpdated("ProdTrackStockRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private string _StockBarcode;
        [Display(Name = "Stok Barkod")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string StockBarcode { get => _StockBarcode; set { _StockBarcode = value; SetUpdated("StockBarcode", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0-Beklemede
         1-Bitti
         */


        public ProductionStockBarcodes()
        {
            TableName = "ProductionStockBarcodes";

            Columns.Add(new ObjColumn("ProdTrackStockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("StockBarcode", SqlDbType.NVarChar, "", false, false));

            this.ProdTrackStockRef = Guid.Empty;
            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.State = 0;
            this.StockBarcode = "";
        }
    }
}
