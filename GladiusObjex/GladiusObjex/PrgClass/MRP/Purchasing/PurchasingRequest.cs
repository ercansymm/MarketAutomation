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

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class PurchasingRequest:gsBase
    {
        private Guid _RequestType;
        public Guid RequestType { get => _RequestType; set { _RequestType = value; SetUpdated("RequestType", value); } }

        private DateTime _RequestDate;
        public DateTime RequestDate { get => _RequestDate; set { _RequestDate = value; SetUpdated("RequestDate", value); } }

        private Guid _EmployeeRef;
        public Guid EmployeeRef { get => _EmployeeRef; set { _EmployeeRef = value; SetUpdated("EmployeeRef", value); } }

        private Guid _DepartmentRef;
        public Guid DepartmentRef { get => _DepartmentRef; set { _DepartmentRef = value; SetUpdated("DepartmentRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0 - Bekliyor
         1 - İşleme Alındı
         2 - İptal Edildi */

        private string _CardCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

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


        public virtual BindingList<PurchasingRequestDetail> RequestingDetails { get; set; }

        public PurchasingRequest getPurchasingRequest(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            PurchasingRequest myPurchasingRequest = new PurchasingRequest();

            myPurchasingRequest = mng.GetObject<PurchasingRequest>(Ref);
            myPurchasingRequest.RequestingDetails = mng.GetObjectList<PurchasingRequestDetail>(" PurchasingRequestRef='" + Ref + "'", "");
            return myPurchasingRequest;
        }

        public PurchasingRequest()
        {
            TableName = "PurchasingRequest";

            Columns.Add(new ObjColumn("RequestType", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("RequestDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DepartmentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("EmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));


            this.Ref = Guid.NewGuid();
            this.Description = "";
            this.SpecialCode = "";
            this.RequestType = Guid.Empty;
            this.RequestDate = DateTime.Now;
            this.DepartmentRef = Guid.Empty;
            this.EmployeeRef = Guid.Empty;
            this.State = 0;
            this.CardCode = "";

            RequestingDetails = new BindingList<PurchasingRequestDetail>();
        }
    }
}
