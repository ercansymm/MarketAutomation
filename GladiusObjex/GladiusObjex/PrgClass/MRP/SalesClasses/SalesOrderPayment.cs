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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class SalesOrderPayment:gsBase
    {
        private Guid _OrderRef;
        public Guid OrderRef { get => _OrderRef; set { _OrderRef = value; SetUpdated("OrderRef", value); } }

        private string _PaymentType;
        [Display(Name = "Ödeme Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string PaymentType { get => _PaymentType; set { _PaymentType = value; SetUpdated("PaymentType", value); } }

        private DateTime _PaymentDate;
        public DateTime PaymentDate { get => _PaymentDate; set { _PaymentDate = value; SetUpdated("PaymentDate", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private decimal _Total;
        public decimal Total { get => _Total; set { _Total = value; SetUpdated("Total", value); } }

        private Guid _DueRef;
        public Guid DueRef { get => _DueRef; set { _DueRef = value; SetUpdated("DueRef", value); } }

        [ForeignKey("OrderRef")]
        public virtual SalesOrder SalesOrder { get; set; }

        public SalesOrderPayment()
        {
            TableName = "SalesOrderPayment";

            Columns.Add(new ObjColumn("OrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PaymentType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PaymentDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Total", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("DueRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.PaymentType = "";
            this.OrderRef = Guid.Empty;
            this.PaymentDate = DateTime.Today;
            this.Total = 0;
            this.Description = "";
            this.DueRef = Guid.Empty;
        }
    }
}
