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
    public class DispatchDetail:gsBase
    {
        private Guid _DispatchRef;
        public Guid DispatchRef { get => _DispatchRef; set { _DispatchRef = value; SetUpdated("DispatchRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private double _Amount;
        public double Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }


        private int _LogoItemRef;
        public int LogoItemRef { get => _LogoItemRef; set { _LogoItemRef = value; SetUpdated("LogoItemRef", value); } }

        private double _UnitPrice;
        public double UnitPrice { get => _UnitPrice; set { _UnitPrice = value; SetUpdated("UnitPrice", value); } }

        private double _Total;
        public double Total { get => _Total; set { _Total = value; SetUpdated("Total", value); } }

        private double _KDV;
        public double KDV { get => _KDV; set { _KDV = value; SetUpdated("KDV", value); } }

        private double _KDVTotal;
        public double KDVTotal { get => _KDVTotal; set { _KDVTotal = value; SetUpdated("KDVTotal", value); } }

        public DispatchDetail()
        {

            TableName = "DispatchDetail";

            Columns.Add(new ObjColumn("DispatchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LogoItemRef", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("UnitPrice", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Total", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("KDV", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("KDVTotal", SqlDbType.Float, "", false, false));


            this.Ref = Guid.NewGuid();
            this.DispatchRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.Description = "";
            this.LogoItemRef = 0;
            this.UnitPrice = 0;
            this.Total = 0;
            this.KDV = 0;
            this.KDVTotal = 0;
        }
    }
}
