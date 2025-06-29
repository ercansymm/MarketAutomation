using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipeDocuments:gsBase
    {
        private Guid _RecipeRef;
        public Guid RecipeRef { get => _RecipeRef; set { _RecipeRef = value; SetUpdated("RecipeRef", value); } }

        private string _DocumentName; 
        [Display(Name = "Döküman İsmi")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string DocumentName { get => _DocumentName; set { _DocumentName = value; SetUpdated("DocumentName", value); } }

        private byte[] _Documents;
        public byte[] Documents { get => _Documents; set { _Documents = value; SetUpdated("Documents", value); } }

        [ForeignKey("RecipeRef")]
        public virtual StockRecipe Recipe { get; set; }

        public StockRecipeDocuments()
        {

            TableName = "StockRecipeDocuments";

            Columns.Add(new ObjColumn("RecipeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Documents", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("DocumentName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.Documents = new byte[] { };
            this.RecipeRef = Guid.Empty;
            this.DocumentName = "";
        }
    }
}
