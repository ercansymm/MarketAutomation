using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipeWorkOrderStock:gsBase
    {
        private Guid _RecipeRef;
        public Guid RecipeRef { get => _RecipeRef; set { _RecipeRef = value; SetUpdated("RecipeRef", value); } }

        private Guid _OperationRef;
        public Guid OperationRef { get => _OperationRef; set { _OperationRef = value; SetUpdated("OperationRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private string _OperationNo;
        [Display(Name = "Operasyon No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string OperationNo { get => _OperationNo; set { _OperationNo = value; SetUpdated("OperationNo", value); } }


        [ForeignKey("RecipeRef")]
        public virtual StockRecipe Recipe { get; set; }

        public virtual BindingList<StockRecipeWorkOrderDetail> WorkOrderDetail { get; set; }

        public StockRecipeWorkOrderStock getTrackingStock(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockRecipeWorkOrderStock myDetailStock = new StockRecipeWorkOrderStock();

            myDetailStock = mng.GetObject<StockRecipeWorkOrderStock>(Ref);
            myDetailStock.WorkOrderDetail = mng.GetObjectList<StockRecipeWorkOrderDetail>("RecipeWorkOrderStockRef = '" + Ref + "'", "");

            return myDetailStock;
        }

        public StockRecipeWorkOrderStock()
        {
            TableName = "StockRecipeWorkOrderStock";

            Columns.Add(new ObjColumn("RecipeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OperationBarcode", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.RecipeRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
            this.OperationNo = "";
            this.OperationRef = Guid.Empty;

            WorkOrderDetail = new BindingList<StockRecipeWorkOrderDetail>();
        }
    }
}
