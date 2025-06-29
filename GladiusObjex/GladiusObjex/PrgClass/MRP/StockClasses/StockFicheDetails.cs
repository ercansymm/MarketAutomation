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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockFicheDetails:gsBase
    {
        private Guid _FicheRef;
        public Guid FicheRef { get => _FicheRef; set { _FicheRef = value; SetUpdated("FicheRef", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _UnitAmount;
        public decimal UnitAmount { get => _UnitAmount; set { _UnitAmount = value; SetUpdated("UnitAmount", value); } }

        private decimal _UnitPrice;
        public decimal UnitPrice { get => _UnitPrice; set { _UnitPrice = value; SetUpdated("UnitPrice", value); } }

        private decimal _Tax;
        public decimal Tax { get => _Tax; set { _Tax = value; SetUpdated("Tax", value); } }

        private decimal _TaxAmount;
        public decimal TaxAmount { get => _TaxAmount; set { _TaxAmount = value; SetUpdated("TaxAmount", value); } }

        private decimal _Total;
        public decimal Total { get => _Total; set { _Total = value; SetUpdated("Total", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private Guid _OrderRef;
        public Guid OrderRef { get => _OrderRef; set { _OrderRef = value; SetUpdated("OrderRef", value); } }

        private Guid _OrderDetailRef;
        public Guid OrderDetailRef { get => _OrderDetailRef; set { _OrderDetailRef = value; SetUpdated("OrderDetailRef", value); } }

        private int _LineIO;
        public int LineIO { get => _LineIO; set { _LineIO = value; SetUpdated("LineIO", value); } }
        /*
         0. Giriş
         1. Çıkış
         */


        [ForeignKey("FicheRef")]
        public virtual StockFiche Fiche { get; set; }


        public StockFicheDetails()
        {
            TableName = "StockFicheDetails";

            Columns.Add(new ObjColumn("FicheRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitPrice", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Tax", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("TaxAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Total", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OrderDetailRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LineIO", SqlDbType.Int, "", false, false));

            this.Ref = Guid.NewGuid();
            this.FicheRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitAmount = 0;
            this.UnitPrice = 0;
            this.Tax = 0;
            this.TaxAmount = 0;
            this.Total = 0;
            this.UnitRef = Guid.Empty;
            this.OrderRef = Guid.Empty;
            this.OrderDetailRef = Guid.Empty;
            this.LineIO = 0;
            this.Description = "";
        }
    }
}
