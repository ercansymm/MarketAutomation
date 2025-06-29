using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipeConnectedStocks:gsBase
    {
        private Guid _RecipeRef;
        public Guid RecipeRef { get => _RecipeRef; set { _RecipeRef = value; SetUpdated("RecipeRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }


        [ForeignKey("RecipeRef")]
        public virtual StockRecipe Recipe { get; set; }

        public StockRecipeConnectedStocks()
        {

            TableName = "StockRecipeConnectedStocks";

            Columns.Add(new ObjColumn("RecipeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.RecipeRef = Guid.Empty;
        }
    }
}
