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

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_TransactionDetail : gsBase
    {
        private Guid _TransRef;
        public Guid TransRef { get => _TransRef; set { _TransRef = value; SetUpdated("TransRef", value); } }

        private Int16 _IsGC;
        public Int16 IsGC { get => _IsGC; set { _IsGC = value; SetUpdated("IsGC", value); } }

        private Guid _OrderDetailRef;
        public Guid OrderDetailRef { get => _OrderDetailRef; set { _OrderDetailRef = value; SetUpdated("OrderDetailRef", value); } }

        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private Guid _ReelRef;
        public Guid ReelRef { get => _ReelRef; set { _ReelRef = value; SetUpdated("ReelRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _SerialRef;
        public Guid SerialRef { get => _SerialRef; set { _SerialRef = value; SetUpdated("SerialRef", value); } }

        private Guid _MacReelRef;
        public Guid MacReelRef { get => _MacReelRef; set { _MacReelRef = value; SetUpdated("MacReelRef", value); } }

        private Int16 _Direction;
        public Int16 Direction { get => _Direction; set { _Direction = value; SetUpdated("Direction", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private decimal _UnitAmount;
        public decimal UnitAmount { get => _UnitAmount; set { _UnitAmount = value; SetUpdated("UnitAmount", value); } }

        private string _Description_;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description_ { get => _Description_; set { _Description_ = value; SetUpdated("Description_", value); } }

        private decimal _Planning;
        public decimal Planning { get => _Planning; set { _Planning = value; SetUpdated("Planning", value); } }

        private decimal _Happening;
        public decimal Happening { get => _Happening; set { _Happening = value; SetUpdated("Happening", value); } }

        private decimal _Wastage;
        public decimal Wastage { get => _Wastage; set { _Wastage = value; SetUpdated("Wastage", value); } }

        private string _CoilNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CoilNo { get => _CoilNo; set { _CoilNo = value; SetUpdated("CoilNo", value); } }

        private string _HeatNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string HeatNo { get => _HeatNo; set { _HeatNo = value; SetUpdated("HeatNo", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }

        public A_TransactionDetail()
        {
            this.TableName = "A_TransactionDetail";

            Columns.Add(new ObjColumn("TransRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("IsGC", SqlDbType.TinyInt, "", false, false));
            Columns.Add(new ObjColumn("OrderDetailRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ReelRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SerialRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("MacReelRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Direction", SqlDbType.TinyInt, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description_", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Planning", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Happening", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Wastage", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("CoilNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("HeatNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Date_", SqlDbType.DateTime, "", false, false));

            this.Ref = Guid.NewGuid();
            this.TransRef = Guid.Empty;
            this.IsGC = 0;
            this.OrderDetailRef = Guid.Empty;
            this.MachineRef = Guid.Empty;
            this.ReelRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.SerialRef = Guid.Empty;
            this.MacReelRef = Guid.Empty;
            this.Direction = 0;
            this.Amount = 0;
            this.UnitAmount = 0;
            this.Description_ = "";
            this.Planning = 0;
            this.Happening = 0;
            this.Wastage = 0;
            this.CoilNo = "";
            this.HeatNo = "";
            this.UserRef = Guid.Empty;
            this.Date_ = DateTime.Now;
        }

    }
}
