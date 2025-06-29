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
using GladiusObjex.PrgClass.MRP.StockClasses;
using System.ComponentModel;

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class SubmittedPurchasingOffer:gsBase
    {
        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _OfferRef;
        public Guid OfferRef { get => _OfferRef; set { _OfferRef = value; SetUpdated("OfferRef", value); } }

        private string _CardCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private DateTime _SendDate;
        public DateTime SendDate { get => _SendDate; set { _SendDate = value; SetUpdated("SendDate", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(2000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private DateTime _TransactionDate;
        public DateTime TransactionDate { get => _TransactionDate; set { _TransactionDate = value; SetUpdated("TransactionDate", value); } }

        private Guid _AuthorizingAgentRef;
        public Guid AuthorizingAgentRef { get => _AuthorizingAgentRef; set { _AuthorizingAgentRef = value; SetUpdated("AuthorizingAgentRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0 - Beklemede
         1 - Onaylandı
         2 - Reddedildi
         3 - Teslim Alındı
         4 - Bir Kısmı Teslim Alındı 
         */

        private Guid _PurchasingType;
        public Guid PurchasingType { get => _PurchasingType; set { _PurchasingType = value; SetUpdated("PurchasingType", value); } }



        public virtual BindingList<SubmittedPurchasingOfferDocuments> SubOfferDocuments { get; set; }
        public virtual BindingList<SubmittedPurchasingOfferLines> SubOfferLines { get; set; }
        public virtual BindingList<SubmittedPurchasingOfferPayment> SubOfferPayment { get; set; }

        public SubmittedPurchasingOffer getSubPurcOffer(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            SubmittedPurchasingOffer mySubPurc = new SubmittedPurchasingOffer();

            mySubPurc = mng.GetObject<SubmittedPurchasingOffer>(Ref);
            mySubPurc.SubOfferDocuments = mng.GetObjectList<SubmittedPurchasingOfferDocuments>("SubmittedPurchasingOfferRef='" + Ref + "'", "");
            mySubPurc.SubOfferLines = mng.GetObjectList<SubmittedPurchasingOfferLines>("SubmittedPurchasingOfferRef='" + Ref + "'", "");
            mySubPurc.SubOfferPayment = mng.GetObjectList<SubmittedPurchasingOfferPayment>("SubmittedPurchasingOfferRef='" + Ref + "'", "");

            return mySubPurc;
        }
        public SubmittedPurchasingOffer()
        {
            TableName = "SubmittedPurchasingOffer";

            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SendDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("TransactionDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("AuthorizingAgentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PurchasingType", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.ClientRef = Guid.Empty;
            this.OfferRef = Guid.Empty;
            this.CardCode = "";
            this.SendDate = DateTime.Now;
            this.State = 0;
            this.AuthorizingAgentRef = Guid.Empty;
            this.Curr = "";
            this.PurchasingType = Guid.Empty;

            SubOfferDocuments = new BindingList<SubmittedPurchasingOfferDocuments>();
            SubOfferLines = new BindingList<SubmittedPurchasingOfferLines>();
            SubOfferPayment = new BindingList<SubmittedPurchasingOfferPayment>();
        }
    }
}
