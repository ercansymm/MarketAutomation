using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductTracking:gsBase
    {

        private DateTime _TrackingDate;
        public DateTime TrackingDate { get => _TrackingDate; set { _TrackingDate = value; SetUpdated("TrackingDate", value); } }

        private Guid _DemandRef;
        public Guid DemandRef { get => _DemandRef; set { _DemandRef = value; SetUpdated("DemandRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private Guid _ReceiptRef;
        public Guid ReceiptRef { get => _ReceiptRef; set { _ReceiptRef = value; SetUpdated("ReceiptRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0- Bekliyor	1- Üretiliyor	2- Tamamlandı  3- İptal Edildi
         */


        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private string _TrackingNo;
        [Display(Name = "Takip No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string TrackingNo { get => _TrackingNo; set { _TrackingNo = value; SetUpdated("TrackingNo", value); } }


        public virtual BindingList<ProductTrackingDetailStock> TrackingDetailStock { get; set; }
        public virtual BindingList<ProductionUsedStocks> ProdStock { get; set; }

        public ProductTracking getTracking(Guid demandRef)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            ProductTracking myTracking = new ProductTracking();

            myTracking = mng.GetObject<ProductTracking>("DemandRef = '"+ demandRef + "'");
            myTracking.TrackingDetailStock = mng.GetObjectList<ProductTrackingDetailStock>("ProdTrackRef = '" + myTracking.Ref + "'","");
            myTracking.ProdStock = mng.GetObjectList<ProductionUsedStocks>("ProdTrackRef = '" + myTracking.Ref + "'","");

            for (int i = 0; i < myTracking.TrackingDetailStock.Count; i++)
            {
                myTracking.TrackingDetailStock[i].TrackingDetail = mng.GetObjectList<ProductTrackingDetail>(" ProdTrackStockRef='" + myTracking.TrackingDetailStock[i].Ref + "'", "");
            }

            return myTracking;
        }
        public ProductTracking getTrackingWRef(Guid Ref, string Barcode, Guid OpRef, Guid MachineRef)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");
            ProductTracking myTracking = new ProductTracking();

            myTracking = mng.GetObject<ProductTracking>("Ref = '" + Ref + "'");
            myTracking.TrackingDetailStock = mng.GetObjectList<ProductTrackingDetailStock>("ProdTrackRef = '" + myTracking.Ref + "' AND OperationBarcode = '"+Barcode+"'", "");
            myTracking.ProdStock = mng.GetObjectList<ProductionUsedStocks>("ProdTrackRef = '" + myTracking.Ref + "' AND OperationRef = '"+OpRef+"' AND MachineRef = '"+MachineRef+"' AND State = 1", "");

            for (int i = 0; i < myTracking.TrackingDetailStock.Count; i++)
            {
                myTracking.TrackingDetailStock[i].TrackingDetail = mng.GetObjectList<ProductTrackingDetail>(" ProdTrackStockRef='" + myTracking.TrackingDetailStock[i].Ref + "'", "");
            }

            return myTracking;
        }

        public ProductTracking getUpdateTracking(Guid demandRef,Guid stockRef)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            ProductTracking myTracking = new ProductTracking();

            myTracking = mng.GetObject<ProductTracking>("DemandRef = '" + demandRef + "'");
            myTracking.TrackingDetailStock = mng.GetObjectList<ProductTrackingDetailStock>("ProdTrackRef = '" + myTracking.Ref + "' AND StockRef = '"+stockRef+"'", "");
            myTracking.ProdStock = mng.GetObjectList<ProductionUsedStocks>("ProdTrackRef = '" + myTracking.Ref + "'", "");

            for (int i = 0; i < myTracking.TrackingDetailStock.Count; i++)
            {
                myTracking.TrackingDetailStock[i].TrackingDetail = mng.GetObjectList<ProductTrackingDetail>(" ProdTrackStockRef='" + myTracking.TrackingDetailStock[i].Ref + "'", "");
            }

            return myTracking;
        }

        public ProductTracking()
        {

            TableName = "ProductTracking";

            Columns.Add(new ObjColumn("TrackingDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DemandRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ReceiptRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TrackingNo", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.TrackingDate = DateTime.Now;
            this.DemandRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.Amount = 0;
            this.UnitRef = Guid.Empty;
            this.State = 0;
            this.Barcode = "";
            this.ReceiptRef = Guid.Empty;
            this.TrackingNo = "";

            TrackingDetailStock = new BindingList<ProductTrackingDetailStock>();
            ProdStock = new BindingList<ProductionUsedStocks>();
        }
    }
}
