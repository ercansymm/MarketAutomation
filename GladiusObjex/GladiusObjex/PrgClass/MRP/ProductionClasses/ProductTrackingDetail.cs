using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.PrgClass.Tracing;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductTrackingDetail:gsBase
    {

        private Guid _ProdTrackStockRef;
        public Guid ProdTrackStockRef { get => _ProdTrackStockRef; set { _ProdTrackStockRef = value; SetUpdated("ProdTrackStockRef", value); } }


        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }


        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0- Bekliyor	1- Başladı	2- Bitti
         */


        public ProductTrackingDetail()
        {

            TableName = "ProductTrackingDetail";

            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ProdTrackStockRef", SqlDbType.UniqueIdentifier, "", false, false));

            Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
            this.State = 0;
            this.ProdTrackStockRef = Guid.Empty;
        }
    }
}
