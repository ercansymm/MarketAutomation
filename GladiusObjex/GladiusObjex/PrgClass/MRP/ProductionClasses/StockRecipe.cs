using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class StockRecipe:gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private string _RecipeCode;
        [Display(Name = "Reçete Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string RecipeCode { get => _RecipeCode; set { _RecipeCode = value; SetUpdated("RecipeCode", value); } }

        private string _CardName;
        [Display(Name = "İsmi")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _MainUnitRef;
        public Guid MainUnitRef { get => _MainUnitRef; set { _MainUnitRef = value; SetUpdated("MainUnitRef", value); } }

        private Guid _Unit1Ref;
        public Guid Unit1Ref { get => _Unit1Ref; set { _Unit1Ref = value; SetUpdated("Unit1Ref", value); } }

        private Guid _Unit2Ref;
        public Guid Unit2Ref { get => _Unit2Ref; set { _Unit2Ref = value; SetUpdated("Unit2Ref", value); } }

        private Guid _Unit3Ref;
        public Guid Unit3Ref { get => _Unit3Ref; set { _Unit3Ref = value; SetUpdated("Unit3Ref", value); } }

        private double _MainAmount;
        public double MainAmount { get => _MainAmount; set { _MainAmount = value; SetUpdated("MainAmount", value); } }

        private double _Amount1;
        public double Amount1 { get => _Amount1; set { _Amount1 = value; SetUpdated("Amount1", value); } }

        private double _Amount2;
        public double Amount2 { get => _Amount2; set { _Amount2 = value; SetUpdated("Amount2", value); } }

        private double _Amount3;
        public double Amount3 { get => _Amount3; set { _Amount3 = value; SetUpdated("Amount3", value); } }


        private double _AlternativeAmount;
        public double AlternativeAmount { get => _AlternativeAmount; set { _AlternativeAmount = value; SetUpdated("AlternativeAmount", value); } }

        private Guid _MainStockReff;
        public Guid MainStockRef { get => _MainStockReff; set { _MainStockReff = value; SetUpdated("MainStockRef", value); } }

        public virtual BindingList<StockRecipeDetail> RecipeDetails { get; set; }
        public virtual BindingList<StockRecipeOperations> RecipeOperations { get; set; }
        public virtual BindingList<StockRecipeConnectedStocks> RecipeConStocks { get; set; }
        public virtual BindingList<StockRecipeDocuments> RecipeDocuments { get; set; }
        public virtual BindingList<StockRecipeWorkOrderStock> RecipeWorkOrder { get; set; }

        public StockRecipe getRecipe(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockRecipe myRecipe = new StockRecipe();

            myRecipe = mng.GetObject<StockRecipe>(Ref);
            myRecipe.RecipeDetails = mng.GetObjectList<StockRecipeDetail>(" RecipeRef='" + Ref + "'", "");
            myRecipe.RecipeOperations = mng.GetObjectList<StockRecipeOperations>(" RecipeRef='" + Ref + "'", "");
            myRecipe.RecipeConStocks = mng.GetObjectList<StockRecipeConnectedStocks>(" RecipeRef='" + Ref + "'", "");
            myRecipe.RecipeDocuments = mng.GetObjectList<StockRecipeDocuments>(" RecipeRef='" + Ref + "'", "");
            myRecipe.RecipeWorkOrder = mng.GetObjectList<StockRecipeWorkOrderStock>(" RecipeRef='" + Ref + "'", "");
            for (int i = 0; i < myRecipe.RecipeWorkOrder.Count; i++)
            {
                myRecipe.RecipeWorkOrder[i].WorkOrderDetail = mng.GetObjectList<StockRecipeWorkOrderDetail>(" RecipeWorkOrderStockRef='" + myRecipe.RecipeWorkOrder[i].Ref + "'", "");
            }

            return myRecipe;
        }
        public StockRecipe()
        {
            TableName = "StockRecipe";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("RecipeCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("MainUnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Unit1Ref", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Unit2Ref", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Unit3Ref", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MainAmount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Amount1", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Amount2", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Amount3", SqlDbType.Float, "", false, false));

            Columns.Add(new ObjColumn("AlternativeAmount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("MainStockRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.IsPassive = true;
            this.RecipeCode = "";
            this.CardName = "";
            this.Description = "";
            this.MainUnitRef = Guid.Empty;
            this.Unit1Ref = Guid.Empty;
            this.Unit2Ref = Guid.Empty;
            this.Unit3Ref = Guid.Empty;
            this.MainAmount = 0;
            this.Amount1 = 0;
            this.Amount2 = 0;
            this.Amount3 = 0;
            this.AlternativeAmount = 0;
            this.MainStockRef = Guid.Empty;

            RecipeDetails = new BindingList<StockRecipeDetail>();
            RecipeOperations = new BindingList<StockRecipeOperations>();
            RecipeConStocks = new BindingList<StockRecipeConnectedStocks>();
            RecipeDocuments = new BindingList<StockRecipeDocuments>();
            RecipeWorkOrder = new BindingList<StockRecipeWorkOrderStock>();

        }
    }
}
