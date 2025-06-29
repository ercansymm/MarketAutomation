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

namespace GladiusObjex.PrgClass.MRP
{
    public class DiscountDefinitions:gsBase
    {

        private Guid _StockGroupRef;
        public Guid StockGroupRef { get => _StockGroupRef; set { _StockGroupRef = value; SetUpdated("StockGroupRef", value); } }

        private decimal _DiscountRate;
        public decimal DiscountRate { get => _DiscountRate; set { _DiscountRate = value; SetUpdated("DiscountRate", value); } }

        public DiscountDefinitions()
        {
            TableName = "DiscountDefinitions";

            Columns.Add(new ObjColumn("StockGroupRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("DiscountRate", SqlDbType.Decimal, "", false, false));

            this.StockGroupRef = Guid.Empty;
            this.DiscountRate = 0;
        }
    }
}
