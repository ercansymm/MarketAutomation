using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductDemand : gsBase
    {
        private Guid _OrderLineRef;
        public Guid OrderLineRef { get => _OrderLineRef; set { _OrderLineRef = value; SetUpdated("OrderLineRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private DateTime _DemandDate;
        public DateTime DemandDate { get => _DemandDate; set { _DemandDate = value; SetUpdated("DemandDate", value); } }


        private DateTime _DeadLineDate;
        public DateTime DeadLineDate { get => _DeadLineDate; set { _DeadLineDate = value; SetUpdated("DeadLineDate", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private string _MeetType;
        [Display(Name = "Karşılama Şekli")]
        [DataType("nvarchar")]
        [StringLength(3)]
        public string MeetType { get => _MeetType; set { _MeetType = value; SetUpdated("MeetType", value); } }
        /*
         STK = Stoktan
         PRD = Üretim
         FSN = Fason
         */

        private Guid _MeetUnitRef;
        public Guid MeetUnitRef { get => _MeetUnitRef; set { _MeetUnitRef = value; SetUpdated("MeetUnitRef", value); } }

        private decimal _MeetAmount;
        public decimal MeetAmount { get => _MeetAmount; set { _MeetAmount = value; SetUpdated("MeetAmount", value); } }

        private Guid _ReceiptRef;
        public Guid ReceiptRef { get => _ReceiptRef; set { _ReceiptRef = value; SetUpdated("ReceiptRef", value); } }

        private string _ProductNote;
        [Display(Name = "Üretim Notu")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string ProductNote { get => _ProductNote; set { _ProductNote = value; SetUpdated("ProductNote", value); } }

        private string _DemandNo;
        [Display(Name = "Seri No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string DemandNo { get => _DemandNo; set { _DemandNo = value; SetUpdated("DemandNo", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }
        /*
         0 - Bekliyor
         1 - Planlandı
         2 - Üretiliyor
         3 - Üretildi 
         4 - İptal Edildi 
         5 - Sevk Ediliyor
         6 - Sevk Edildi 
         */

        public ProductDemand()
        {
            TableName = "ProductDemand";

            Columns.Add(new ObjColumn("OrderLineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("MeetType", SqlDbType.NVarChar, 0, false, false));
            Columns.Add(new ObjColumn("MeetUnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MeetAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("ReceiptRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ProductNote", SqlDbType.NVarChar, 0, false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("DemandDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DemandNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DeadLineDate", SqlDbType.DateTime, "", false, false));

            this.Ref = Guid.NewGuid();
            this.OrderLineRef = Guid.Empty;
            this.StockRef= Guid.Empty;
            this.UnitRef= Guid.Empty;
            this.Amount = 0;
            this.MeetType = "PRD";
            this.MeetUnitRef= Guid.Empty;
            this.MeetAmount = 0;
            this.ReceiptRef= Guid.Empty;
            this.ProductNote = "";
            this.State = 0;
            this.DemandDate = DateTime.Now;
            this.DemandNo = "";
            this.DeadLineDate = DateTime.Today;
        }
    }
}
