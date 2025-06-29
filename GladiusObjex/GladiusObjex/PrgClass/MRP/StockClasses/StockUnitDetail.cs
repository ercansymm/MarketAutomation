using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockUnitDetail:gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Factor1;
        public decimal Factor1 { get => _Factor1; set { _Factor1 = value; SetUpdated("Factor1", value); } } //Çarpan 1

        private decimal _Factor2;
        public decimal Factor2 { get => _Factor2; set { _Factor2 = value; SetUpdated("Factor2", value); } } //Çarpan 2

        private decimal _Lenght;
        public decimal Lenght { get => _Lenght; set { _Lenght = value; SetUpdated("Lenght", value); } } //Uzunluk

        private decimal _Weight;
        public decimal Weight { get => _Weight; set { _Weight = value; SetUpdated("Weight", value); } } //Ağırlık

        private decimal _Height;
        public decimal Height { get => _Height; set { _Height = value; SetUpdated("Height", value); } } //Yükseklik

        private decimal _Depth;
        public decimal Depth { get => _Depth; set { _Depth = value; SetUpdated("Depth", value); } } //Derinlik

        private decimal _Diameter;
        public decimal Diameter { get => _Diameter; set { _Diameter = value; SetUpdated("Diameter", value); } } //Çap

        [ForeignKey("StockRef")]
        public virtual StockCard Stock { get; set; }
        public virtual BindingList<StockUnitBarcode> StockUnitBarcode { get; set; } //barkod


        public StockUnitDetail()
        {
            TableName = "StockUnitDetail";

            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Factor1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Factor2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Lenght", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Weight", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Height", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Depth", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Diameter", SqlDbType.Decimal, "", false, false));

            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Factor1 = 1;
            this.Factor2 = 1;
            this.Lenght = 0;
            this.Weight = 0;
            this.Height = 0;
            this.Depth = 0;
            this.Diameter = 0;
            this.Ref = Guid.NewGuid();

            this.StockUnitBarcode = new BindingList<StockUnitBarcode>();
        }
    }
}
