using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
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
    public class Shipment:gsBase
    {
        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _OrderRef;
        public Guid OrderRef { get => _OrderRef; set { _OrderRef = value; SetUpdated("OrderRef", value); } }

        private DateTime _ShipmentDate;
        public DateTime ShipmentDate { get => _ShipmentDate; set { _ShipmentDate = value; SetUpdated("ShipmentDate", value); } }

        private string _Plate;
        [Display(Name = "Plaka")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string Plate { get => _Plate; set { _Plate = value; SetUpdated("Plate", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        public virtual BindingList<ShipmentLines> ShipmentLines { get; set; }
        public Shipment getShipment(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Shipment myShipment = new Shipment();

            myShipment = mng.GetObject<Shipment>(Ref);
            myShipment.ShipmentLines = mng.GetObjectList<ShipmentLines>("ShipmentRef = '" + Ref + "'", "");

            return myShipment;
        }

        public Shipment()
        {

            TableName = "Shipment";

            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Plate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ShipmentDate", SqlDbType.DateTime, "", false, false));

            this.Ref = Guid.NewGuid();
            this.ClientRef  =Guid.Empty;
            this.OrderRef = Guid.Empty;
            this.Plate = "";
            this.Description = "";
            this.ShipmentDate = DateTime.Now;

            ShipmentLines = new BindingList<ShipmentLines>();
        }
    }
}
