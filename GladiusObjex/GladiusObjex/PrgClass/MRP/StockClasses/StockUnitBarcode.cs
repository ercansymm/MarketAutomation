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
    public class StockUnitBarcode:gsBase
    {
        private Guid _StockUnitDetailRef;
        public Guid StockUnitDetailRef { get => _StockUnitDetailRef; set { _StockUnitDetailRef = value; SetUpdated("StockUnitDetailRef", value); } }

        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        [ForeignKey("StockUnitDetailRef")]
        public virtual StockUnitDetail Stock { get; set; }

        public StockUnitBarcode()
        {
            TableName = "StockUnitBarcode";

            Columns.Add(new ObjColumn("StockUnitDetailRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.StockUnitDetailRef = Guid.Empty;
            this.Barcode = "";
            this.State = 0;
            this.ClientRef = Guid.Empty;
        }
    }
}
