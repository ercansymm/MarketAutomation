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
    public class StockRecipeOperations:gsBase
    {
        private Guid _RecipeRef;
        public Guid RecipeRef { get => _RecipeRef; set { _RecipeRef = value; SetUpdated("RecipeRef", value); } }

        private Guid _OperationRef;
        public Guid OperationRef { get => _OperationRef; set { _OperationRef = value; SetUpdated("OperationRef", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private TimeSpan _OperationTime;
        public TimeSpan OperationTime { get => _OperationTime; set { _OperationTime = value; SetUpdated("OperationTime", value); } }

        [ForeignKey("RecipeRef")]
        public virtual StockRecipe Recipe { get; set; }

        public StockRecipeOperations()
        {

            TableName = "StockRecipeOperations";

            Columns.Add(new ObjColumn("RecipeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationTime", SqlDbType.Time, "", false, false));

            this.Ref = Guid.NewGuid();
            this.RecipeRef = Guid.Empty;
            this.OperationTime = DateTime.Today.TimeOfDay ;
            this.OperationRef = Guid.Empty;
            this.MachineRef = Guid.Empty;
        }
    }
}
