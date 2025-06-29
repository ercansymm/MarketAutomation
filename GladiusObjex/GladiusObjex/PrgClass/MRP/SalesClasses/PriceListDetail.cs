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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class PriceListDetail:gsBase
    {
        private Guid _PriceListRef;
        public Guid PriceListRef { get => _PriceListRef; set { _PriceListRef = value; SetUpdated("PriceListRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Price;
        public decimal Price { get => _Price; set { _Price = value; SetUpdated("Price", value); } }

        private bool _KDV;
        public bool KDV { get => _KDV; set { _KDV = value; SetUpdated("KDV", value); } }

        private string _Description;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _MeasureRef;
        public Guid MeasureRef { get => _MeasureRef; set { _MeasureRef = value; SetUpdated("MeasureRef", value); } }

        [ForeignKey("PriceListRef")]
        public virtual PriceList List { get; set; }

        public PriceListDetail()
        {

            TableName = "PriceListDetail";

            Columns.Add(new ObjColumn("PriceListRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Price", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("KDV", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("MeasureRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.PriceListRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Price = 0;
            this.Description = "";
            this.MeasureRef = Guid.Empty;
        }
    }
}
