using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ShipmentLines:gsBase
    {
        private Guid _ShipmentRef;
        public Guid ShipmentRef { get => _ShipmentRef; set { _ShipmentRef = value; SetUpdated("ShipmentRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }



        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }



        

        public MachineCard getMachine(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            MachineCard myMachine = new MachineCard();

            myMachine = mng.GetObject<MachineCard>(Ref);

            return myMachine;
        }

        public ShipmentLines()
        {

            TableName = "ShipmentLines";

            Columns.Add(new ObjColumn("ShipmentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));

           

            this.Ref = Guid.NewGuid();
            this.ShipmentRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.Description = "";

        }
    }
}
