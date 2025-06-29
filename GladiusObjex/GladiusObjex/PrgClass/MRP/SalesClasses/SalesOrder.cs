using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.PrgClass.MRP.ProductionClasses;
using GladiusObjex.PrgClass.Tracing;

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class SalesOrder:gsBase
    {
        private string _SerialNo;
        [Display(Name = "Seri No")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _OrderType;
        [Display(Name = "Sipariş Tipi")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string OrderType { get => _OrderType; set { _OrderType = value; SetUpdated("OrderType", value); } }

        private Guid _OfferRef;
        public Guid OfferRef { get => _OfferRef; set { _OfferRef = value; SetUpdated("OfferRef", value); } }

        private DateTime _OrderDate;
        public DateTime OrderDate { get => _OrderDate; set { _OrderDate = value; SetUpdated("OrderDate", value); } }

        private DateTime _DeadLineDate;
        public DateTime DeadLineDate { get => _DeadLineDate; set { _DeadLineDate = value; SetUpdated("DeadLineDate", value); } }

        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _AgentRef;
        public Guid AgentRef { get => _AgentRef; set { _AgentRef = value; SetUpdated("AgentRef", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        private string _CrossOrderNo;
        [Display(Name = "Karşı Sipariş No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CrossOrderNo { get => _CrossOrderNo; set { _CrossOrderNo = value; SetUpdated("CrossOrderNo", value); } }

        private string _OfferNo;
        [Display(Name = "Teklif No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string OfferNo { get => _OfferNo; set { _OfferNo = value; SetUpdated("OfferNo", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }


        private string _SpecialCode;
        [Display(Name = "Özel Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode { get => _SpecialCode; set { _SpecialCode = value; SetUpdated("SpecialCode", value); } }

        private decimal _ClientBalance;
        public decimal ClientBalance { get => _ClientBalance; set { _ClientBalance = value; SetUpdated("ClientBalance", value); } }

        private Guid _ActualClientRef;
        public Guid ActualClientRef { get => _ActualClientRef; set { _ActualClientRef = value; SetUpdated("ActualClientRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0 - Bekliyor
         1 - Üretimde
         2 - Üretildi
         3 - Sevk Edildi
         4 - İptal Edildi
         5 - Sevkiyat Başladı
         */

        private bool _IsProduct;
        public bool IsProduct { get => _IsProduct; set { _IsProduct = value; SetUpdated("IsProduct", value); } }

        private Guid _PriceListRef;
        public Guid PriceListRef { get => _PriceListRef; set { _PriceListRef = value; SetUpdated("PriceListRef", value); } }

        public virtual BindingList<SalesOrderLines> OrderLines { get; set; }
        public virtual SalesOrderTransport OrderTransport { get; set; }
        public virtual BindingList<SalesOrderPayment> OrderPayment { get; set; }
        public virtual BindingList<Shipment> Shipment { get; set; }


        public SalesOrder getSalesOrder(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            SalesOrder mySalesOrder = new SalesOrder();

            mySalesOrder = mng.GetObject<SalesOrder>(Ref);
            mySalesOrder.OrderLines = mng.GetObjectList<SalesOrderLines>(" OrderRef='" + Ref + "'", "");
            mySalesOrder.Shipment = mng.GetObjectList<Shipment>("OrderRef = '"+ mySalesOrder.Ref + "'","");
            for (int i = 0; i < mySalesOrder.OrderLines.Count; i++)
            {
                mySalesOrder.OrderLines[i].DemandList = mng.GetObjectList<ProductDemand>(" OrderLineRef='" + mySalesOrder.OrderLines[i].Ref + "'", "");
            }
            mySalesOrder.OrderPayment = mng.GetObjectList<SalesOrderPayment>(" OrderRef='" + Ref + "'", "");
            mySalesOrder.OrderTransport = mng.GetObject<SalesOrderTransport>(" OrderRef='" + Ref + "'");
            return mySalesOrder;
        }
        public SalesOrder getSalesOrderForShipment(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            SalesOrder mySalesOrder = new SalesOrder();

            mySalesOrder = mng.GetObject<SalesOrder>(Ref);
            mySalesOrder.OrderLines = mng.GetObjectList<SalesOrderLines>(" OrderRef='" + Ref + "'", "");
            mySalesOrder.Shipment = mng.GetObjectList<Shipment>("OrderRef = '" + mySalesOrder.Ref + "'","");
            for (int i = 0; i < mySalesOrder.OrderLines.Count; i++)
            {
                mySalesOrder.OrderLines[i].DemandList = mng.GetObjectList<ProductDemand>(" OrderLineRef='" + mySalesOrder.OrderLines[i].Ref + "'", "");
            }
            mySalesOrder.OrderPayment = mng.GetObjectList<SalesOrderPayment>(" OrderRef='" + Ref + "'", "");
            mySalesOrder.OrderTransport = mng.GetObject<SalesOrderTransport>(" OrderRef='" + Ref + "'");
            return mySalesOrder;
        }

        public SalesOrder()
        {
            TableName = "SalesOrder";

            Columns.Add(new ObjColumn("OrderType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OrderDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DeadLineDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("AgentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CrossOrderNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OfferNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientBalance", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("OfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("IsProduct", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("PriceListRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ActualClientRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.SerialNo = "";
            this.Ref = Guid.NewGuid();
            this.ClientRef = Guid.Empty;
            this.OrderDate = DateTime.Today;
            this.AgentRef = Guid.Empty;
            this.CrossOrderNo = "";
            this.Description = "";
            this.SpecialCode = "";
            this.ClientBalance = 0;
            this.Curr = "";
            this.OfferNo = "";
            this.OrderType = "";
            this.OfferRef = Guid.Empty;
            this.IsProduct = false;
            this.DeadLineDate = DateTime.Today;
            this.PriceListRef = Guid.Empty;
            this.State = 0;
            this.ActualClientRef = Guid.Empty;

            OrderLines = new BindingList<SalesOrderLines>();
            OrderPayment = new BindingList<SalesOrderPayment>();
            OrderTransport = new SalesOrderTransport();
            Shipment = new BindingList<Shipment>();
        }
    }
}
