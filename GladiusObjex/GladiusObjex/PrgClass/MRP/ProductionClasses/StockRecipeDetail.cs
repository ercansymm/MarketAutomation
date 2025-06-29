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

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipeDetail:gsBase
    {
        private Guid _RecipeRef;
        public Guid RecipeRef { get => _RecipeRef; set { _RecipeRef = value; SetUpdated("RecipeRef", value); } }

        private Guid _StockTypeRef;
        public Guid StockTypeRef { get => _StockTypeRef; set { _StockTypeRef = value; SetUpdated("StockTypeRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private double _Amount;
        public double Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _OperationRef;
        public Guid OperationRef { get => _OperationRef; set { _OperationRef = value; SetUpdated("OperationRef", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private int _LineIO;
        public int LineIO { get => _LineIO; set { _LineIO = value; SetUpdated("LineIO", value); } }

        [ForeignKey("RecipeRef")]
        public virtual StockRecipe Recipe { get; set; }

        public StockRecipeDetail()
        {

            TableName = "StockRecipeDetail";

            Columns.Add(new ObjColumn("RecipeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockTypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("OperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LineIO", SqlDbType.Int, "", false, false));

            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.StockTypeRef = Guid.Empty;
            this.RecipeRef = Guid.Empty;
            this.Amount = 0;
            this.OperationRef = Guid.Empty;
            this.MachineRef = Guid.Empty;
            this.LineIO = 0;
        }
    }
}
