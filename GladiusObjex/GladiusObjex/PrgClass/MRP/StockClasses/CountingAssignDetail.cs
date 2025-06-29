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
    public class CountingAssignDetail:gsBase
    {
        private Guid _CountingAssignRef;
        public Guid CountingAssignRef { get => _CountingAssignRef; set { _CountingAssignRef = value; SetUpdated("CountingAssignRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }


        [ForeignKey("CountingAssignRef")]
        public virtual CountingAssign Counting { get; set; }



        public CountingAssignDetail()
        {
            TableName = "CountingAssignDetail";

            Columns.Add(new ObjColumn("CountingAssignRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));


            this.CountingAssignRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
        }
    }
}
