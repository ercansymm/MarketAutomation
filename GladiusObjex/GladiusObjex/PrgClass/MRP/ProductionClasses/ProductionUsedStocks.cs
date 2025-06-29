using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductionUsedStocks:gsBase
    {
        private Guid _ProdTrackRef;
        public Guid ProdTrackRef { get => _ProdTrackRef; set { _ProdTrackRef = value; SetUpdated("ProdTrackRef", value); } }

        private Guid _OperationRef;
        public Guid OperationRef { get => _OperationRef; set { _OperationRef = value; SetUpdated("OperationRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0-Beklemede
         1-Başladı
         2-Bitti
         */


        public ProductionUsedStocks()
        {
            TableName = "ProductionUsedStocks";

            Columns.Add(new ObjColumn("ProdTrackRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.ProdTrackRef = Guid.Empty;
            this.Ref = Guid.NewGuid();
            this.OperationRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.MachineRef = Guid.Empty;
            this.Amount = 0;
            this.State = 0;
        }
    }
}
