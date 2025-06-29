using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.PrgClass.Tracing;
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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class SalesOffer:gsBase
    {
        private string _SerialNo;
        [Display(Name = "Seri No")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _OfferType;
        [Display(Name = "Teklif Tipi")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string OfferType { get => _OfferType; set { _OfferType = value; SetUpdated("OfferType", value); } }

        private DateTime _OfferDate;
        public DateTime OfferDate { get => _OfferDate; set { _OfferDate = value; SetUpdated("OfferDate", value); } }

        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _AgentRef;
        public Guid AgentRef { get => _AgentRef; set { _AgentRef = value; SetUpdated("AgentRef", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        private string _CrossOfferNo;
        [Display(Name = "Karşı Sipariş No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CrossOfferNo { get => _CrossOfferNo; set { _CrossOfferNo = value; SetUpdated("CrossOfferNo", value); } }

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

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
 0. Beklemede
1. Onaylandı
2. Gönderildi
3. Red Edildi
4. Onay Sürecinde 

 */

        private string _RejectionDesc;
        [Display(Name = "Reddedilme Sebebi")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string RejectionDesc { get => _RejectionDesc; set { _RejectionDesc = value; SetUpdated("RejectionDesc", value); } }

        private DateTime _TransactionDate;
        public DateTime TransactionDate { get => _TransactionDate; set { _TransactionDate = value; SetUpdated("TransactionDate", value); } }

        private Guid _PriceListRef;
        public Guid PriceListRef { get => _PriceListRef; set { _PriceListRef = value; SetUpdated("PriceListRef", value); } }

        private Guid _AuthorizingEmployeeRef;
        public Guid AuthorizingEmployeeRef { get => _AuthorizingEmployeeRef; set { _AuthorizingEmployeeRef = value; SetUpdated("AuthorizingEmployeeRef", value); } }

        private Guid _ActualClientRef;
        public Guid ActualClientRef { get => _ActualClientRef; set { _ActualClientRef = value; SetUpdated("ActualClientRef", value); } }

        private string _PotentialClient;
        [Display(Name = "PotentialClient")]
        [DataType("nvarchar")]
        [StringLength(800)]
        public string PotentialClient { get => _PotentialClient; set { _PotentialClient = value; SetUpdated("PotentialClient", value); } }

        private bool _IsPotential;
        public bool IsPotential { get => _IsPotential; set { _IsPotential = value; SetUpdated("IsPotential", value); } }

        public virtual BindingList<SalesOfferLines> OfferLines { get; set; }
        public virtual SalesOfferTransport OfferTransport { get; set; }
        public virtual BindingList<SalesOfferPayment> OfferPayment { get; set; }

        public SalesOffer getSalesOffer(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            SalesOffer mySalesOffer = new SalesOffer();

            mySalesOffer = mng.GetObject<SalesOffer>(Ref);
            mySalesOffer.OfferLines = mng.GetObjectList<SalesOfferLines>(" OfferRef='" + Ref + "'", "");
            mySalesOffer.OfferPayment = mng.GetObjectList<SalesOfferPayment>(" OfferRef='" + Ref + "'", "");
            mySalesOffer.OfferTransport = mng.GetObject<SalesOfferTransport>(" OfferRef='" + Ref + "'");
            return mySalesOffer;
        }

        public SalesOffer()
        {
            TableName = "SalesOffer";

            Columns.Add(new ObjColumn("OfferType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OfferDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("AgentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CrossOfferNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientBalance", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("RejectionDesc", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TransactionDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("AuthorizingEmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PriceListRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ActualClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PotentialClient", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsPotential", SqlDbType.Bit, "", false, false));

            this.SerialNo = "";
            this.Ref = Guid.NewGuid();
            this.ClientRef = Guid.Empty;
            this.OfferDate = DateTime.Today;
            this.AgentRef = Guid.Empty;
            this.CrossOfferNo = "";
            this.Description = "";
            this.SpecialCode = "";
            this.ClientBalance = 0;
            this.Curr = "";
            this.OfferType = "";
            this.State = 0;
            this.RejectionDesc = "";
            this.TransactionDate = DateTime.Now;
            this.AuthorizingEmployeeRef = Guid.Empty;
            this.PriceListRef = Guid.Empty;
            this.ActualClientRef = Guid.Empty;
            this.PotentialClient = "";
            this.IsPotential = false;

            OfferLines = new BindingList<SalesOfferLines>();
            OfferPayment = new BindingList<SalesOfferPayment>();
            OfferTransport = new SalesOfferTransport();
        }
    }
}
