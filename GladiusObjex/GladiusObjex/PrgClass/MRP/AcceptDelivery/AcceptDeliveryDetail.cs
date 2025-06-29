using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.MRP.AcceptDelivery
{
    public class AcceptDeliveryDetail:gsBase
    {
        private Guid _DeliveryRef;
        public Guid DeliveryRef { get => _DeliveryRef; set { _DeliveryRef = value; SetUpdated("DeliveryRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private string _Barcode;
        [Display(Name = "Plaka")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }


        public AcceptDeliveryDetail()
        {
            TableName = "AcceptDeliveryDetail";

            Columns.Add(new ObjColumn("DeliveryRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));

            this.DeliveryRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.Barcode = "";
            this.UnitRef = Guid.Empty;
            this.Amount =0;
        }
    }
}
