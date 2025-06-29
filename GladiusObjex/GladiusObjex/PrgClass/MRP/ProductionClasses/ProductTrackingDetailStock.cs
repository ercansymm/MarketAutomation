using GladiusObjex.BaseClass;
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
    public class ProductTrackingDetailStock:gsBase
    {
        private Guid _ProdTrackRef;
        public Guid ProdTrackRef { get => _ProdTrackRef; set { _ProdTrackRef = value; SetUpdated("ProdTrackRef", value); } }

        private Guid _OperationRef;
        public Guid OperationRef { get => _OperationRef; set { _OperationRef = value; SetUpdated("OperationRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private decimal _AmountFulfilled;
        public decimal AmountFulfilled { get => _AmountFulfilled; set { _AmountFulfilled = value; SetUpdated("AmountFulfilled", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private Guid _StartEmployeeRef;
        public Guid StartEmployeeRef { get => _StartEmployeeRef; set { _StartEmployeeRef = value; SetUpdated("StartEmployeeRef", value); } }

        private Guid _EndEmployeeRef;
        public Guid EndEmployeeRef { get => _EndEmployeeRef; set { _EndEmployeeRef = value; SetUpdated("EndEmployeeRef", value); } }

        private DateTime _StartDate;
        public DateTime StartDate { get => _StartDate; set { _StartDate = value; SetUpdated("StartDate", value); } }

        private DateTime _EndDate;
        public DateTime EndDate { get => _EndDate; set { _EndDate = value; SetUpdated("EndDate", value); } }

        private string _OperationNo;
        [Display(Name = "Operasyon No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string OperationNo { get => _OperationNo; set { _OperationNo = value; SetUpdated("OperationNo", value); } }

        private string _OperationBarcode;
        [Display(Name = "Operasyon Barkod")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string OperationBarcode { get => _OperationBarcode; set { _OperationBarcode = value; SetUpdated("OperationBarcode", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }
        /*
         0 - Bekliyor
         1 - Üretimde
         2 - Üretildi
         3-  İptal Edildi
         */

        private string _StockBarcode;
        [Display(Name = "Stok Barkod")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string StockBarcode { get => _StockBarcode; set { _StockBarcode = value; SetUpdated("StockBarcode", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private string _MaterialBarcode;
        [Display(Name = "Hammadde Barkod")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string MaterialBarcode { get => _MaterialBarcode; set { _MaterialBarcode = value; SetUpdated("MaterialBarcode", value); } }

        [ForeignKey("ProdTrackRef")]
        public virtual ProductTracking ProdTrack { get; set; }

        public virtual BindingList<ProductTrackingDetail> TrackingDetail { get; set; }

        public ProductTrackingDetailStock getTrackingStock(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            ProductTrackingDetailStock myDetailStock = new ProductTrackingDetailStock();

            myDetailStock = mng.GetObject<ProductTrackingDetailStock>(Ref);
            myDetailStock.TrackingDetail = mng.GetObjectList<ProductTrackingDetail>("ProdTrackStockRef = '" + Ref + "'", "");

            return myDetailStock;
        }

        public ProductTrackingDetailStock()
        {

            TableName = "ProductTrackingDetailStock";

            Columns.Add(new ObjColumn("ProdTrackRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OperationNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OperationBarcode", SqlDbType.NVarChar, "", false, false));

            Columns.Add(new ObjColumn("StartEmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("EndEmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StartDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("EndDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));

            Columns.Add(new ObjColumn("StockBarcode", SqlDbType.NVarChar, "", false, false));

            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("AmountFulfilled", SqlDbType.Decimal, "", false, false));

            Columns.Add(new ObjColumn("MaterialBarcode", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.ProdTrackRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
            this.OperationBarcode = "";
            this.OperationNo = "";
            this.OperationRef = Guid.Empty;
            this.StartEmployeeRef = Guid.Empty;
            this.EndEmployeeRef = Guid.Empty;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.State = 0;
            this.StockBarcode = "";
            this.MachineRef = Guid.Empty;
            this.AmountFulfilled = 0;
            this.MaterialBarcode = "";

            TrackingDetail = new BindingList<ProductTrackingDetail>();
        }
    }
}
