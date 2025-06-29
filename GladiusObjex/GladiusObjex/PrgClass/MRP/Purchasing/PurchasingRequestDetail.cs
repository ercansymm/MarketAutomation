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

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class PurchasingRequestDetail:gsBase
    {
        private Guid _PurchasingRequestRef;
        public Guid PurchasingRequestRef { get => _PurchasingRequestRef; set { _PurchasingRequestRef = value; SetUpdated("PurchasingRequestRef", value); } }

        private string _StockName;
        [Display(Name = "Stok İsmi")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string StockName { get => _StockName; set { _StockName = value; SetUpdated("StockName", value); } }

        private int _LineNumber;
        public int LineNumber { get => _LineNumber; set { _LineNumber = value; SetUpdated("LineNumber", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        /*
         0 - Karşılanmadı
         1 - Karşılandı 
         */

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        [ForeignKey("PurchasingRequestRef")]
        public virtual PurchasingRequest PurchasingRequest { get; set; }

        public PurchasingRequestDetail()
        {

            TableName = "PurchasingRequestDetail";

            Columns.Add(new ObjColumn("PurchasingRequestRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LineNumber", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));


            this.Ref = Guid.NewGuid();
            this.PurchasingRequestRef = Guid.Empty;
            this.StockName = "";
            this.LineNumber = 0;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.Description = "";
            this.State = 0;
            this.StockRef = Guid.Empty;
        }
    }
}
