using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
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

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class PurchasingOffer:gsBase
    {
        private Guid _PurchasingType;
        public Guid PurchasingType { get => _PurchasingType; set { _PurchasingType = value; SetUpdated("PurchasingType", value); } }

        private Guid _AgentRef;
        public Guid AgentRef { get => _AgentRef; set { _AgentRef = value; SetUpdated("AgentRef", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        private Guid _RequestRef;
        public Guid RequestRef { get => _RequestRef; set { _RequestRef = value; SetUpdated("RequestRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
 0. Beklemede
1. Onaylandı
2. Gönderildi
3. Red Edildi
 */

        private string _CardCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private DateTime _PurchasingOfferDate;
        public DateTime PurchasingOfferDate { get => _PurchasingOfferDate; set { _PurchasingOfferDate = value; SetUpdated("PurchasingOfferDate", value); } }

        private Guid _EmployeeRef;
        public Guid EmployeeRef { get => _EmployeeRef; set { _EmployeeRef = value; SetUpdated("EmployeeRef", value); } }

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


        public virtual BindingList<PurchasingOfferLines> PurchasingLines { get; set; }

        public PurchasingOffer getPurchasingOffer(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            PurchasingOffer myPurchasingOffer = new PurchasingOffer();

            myPurchasingOffer = mng.GetObject<PurchasingOffer>(Ref);
            myPurchasingOffer.PurchasingLines = mng.GetObjectList<PurchasingOfferLines>(" PurchasingOfferRef='" + Ref + "'", "");
            return myPurchasingOffer;
        }

        public PurchasingOffer()
        {
            TableName = "PurchasingOffer";

            Columns.Add(new ObjColumn("PurchasingType", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PurchasingOfferDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("RequestRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("AgentRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.PurchasingType = Guid.Empty;
            this.PurchasingOfferDate = DateTime.Now;
            this.RequestRef = Guid.Empty;
            this.CardCode = "";
            this.EmployeeRef = Guid.Empty;
            this.Description = "";
            this.SpecialCode = "";
            this.Curr = "";
            this.State = 0;
            this.AgentRef = Guid.Empty;

            PurchasingLines = new BindingList<PurchasingOfferLines>();
        }
    }
}
