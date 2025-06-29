using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.ProductionClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.MRP.AcceptDelivery
{
    public class AcceptDelivery:gsBase
    {
        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _PurchasingRef;
        public Guid PurchasingRef { get => _PurchasingRef; set { _PurchasingRef = value; SetUpdated("PurchasingRef", value); } }

        private string _Plate;
        [Display(Name = "Plaka")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string Plate { get => _Plate; set { _Plate = value; SetUpdated("Plate", value); } }

        private DateTime _DeliveryDate;
        public DateTime DeliveryDate { get => _DeliveryDate; set { _DeliveryDate = value; SetUpdated("DeliveryDate", value); } }

        private Guid _EmployeeRef;
        public Guid EmployeeRef { get => _EmployeeRef; set { _EmployeeRef = value; SetUpdated("EmployeeRef", value); } }

        private Guid _WarehouseRef;
        public Guid WarehouseRef { get => _WarehouseRef; set { _WarehouseRef = value; SetUpdated("WarehouseRef", value); } }

        public virtual BindingList<AcceptDeliveryDetail> Details { get; set; }

        public AcceptDelivery getDelivery(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            AcceptDelivery myDelivery = new AcceptDelivery();

            myDelivery = mng.GetObject<AcceptDelivery>(Ref);
            myDelivery.Details = mng.GetObjectList<AcceptDeliveryDetail>(" DeliveryRef='" + Ref + "'", "");

            return myDelivery;
        }
        public AcceptDelivery()
        {
            TableName = "AcceptDelivery";

            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PurchasingRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Plate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DeliveryDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("EmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WarehouseRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.ClientRef = Guid.Empty;
            this.PurchasingRef = Guid.Empty;
            this.Plate = "";
            this.DeliveryDate = DateTime.Now;
            this.EmployeeRef = Guid.Empty;
            this.WarehouseRef = Guid.Empty;

            Details = new BindingList<AcceptDeliveryDetail>();
        }
    }
}
