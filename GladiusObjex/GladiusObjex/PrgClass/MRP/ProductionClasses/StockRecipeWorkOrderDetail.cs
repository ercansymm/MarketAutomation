using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipeWorkOrderDetail:gsBase
    {
        private Guid _RecipeWorkOrderStockRef;
        public Guid RecipeWorkOrderStockRef { get => _RecipeWorkOrderStockRef; set { _RecipeWorkOrderStockRef = value; SetUpdated("RecipeWorkOrderStockRef", value); } }


        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        public StockRecipeWorkOrderDetail()
        {

            TableName = "StockRecipeWorkOrderDetail";

            Columns.Add(new ObjColumn("ProdTrackRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("RecipeWorkOrderStockRef", SqlDbType.UniqueIdentifier, "", false, false));

            Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
            this.RecipeWorkOrderStockRef = Guid.Empty;
        }
    }
}
