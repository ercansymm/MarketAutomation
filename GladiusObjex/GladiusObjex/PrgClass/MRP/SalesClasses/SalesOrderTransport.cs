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
    public class SalesOrderTransport:gsBase
    {
        private Guid _OrderRef;
        public Guid OrderRef { get => _OrderRef; set { _OrderRef = value; SetUpdated("OrderRef", value); } }

        private string _TransportType;
        [Display(Name = "Sevk Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string TransportType { get => _TransportType; set { _TransportType = value; SetUpdated("TransportType", value); } }

        private string _TransportFirm;
        [Display(Name = "Nakliye Firması")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string TransportFirm { get => _TransportFirm; set { _TransportFirm = value; SetUpdated("TransportFirm", value); } }

        private string _Driver;
        [Display(Name = "Sürücü")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Driver { get => _Driver; set { _Driver = value; SetUpdated("Driver", value); } }

        private string _Plate;
        [Display(Name = "Plaka")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Plate { get => _Plate; set { _Plate = value; SetUpdated("Plate", value); } }

        private string _CrossOrderNo;
        [Display(Name = "Karşı Sipariş No")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CrossOrderNo { get => _CrossOrderNo; set { _CrossOrderNo = value; SetUpdated("CrossOrderNo", value); } }

        private string _TransportDescription;
        [Display(Name = "Nakliye Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string TransportDescription { get => _TransportDescription; set { _TransportDescription = value; SetUpdated("TransportDescription", value); } }

        private string _TransportAddress;
        [Display(Name = "Sevk Adresi")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string TransportAddress { get => _TransportAddress; set { _TransportAddress = value; SetUpdated("TransportAddress", value); } }

        private bool _InvoiceAddress;
        public bool InvoiceAddress { get => _InvoiceAddress; set { _InvoiceAddress = value; SetUpdated("InvoiceAddress", value); } }

        private decimal _Total;
        public decimal Total { get => _Total; set { _Total = value; SetUpdated("Total", value); } }

        [ForeignKey("OrderRef")]
        public virtual SalesOrder SalesOrder { get; set; }
        public SalesOrderTransport()
        {
            TableName = "SalesOrderTransport";

            Columns.Add(new ObjColumn("OrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("TransportType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TransportFirm", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Driver", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Plate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CrossOrderNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TransportDescription", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TransportAddress", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("InvoiceAddress", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Total", SqlDbType.Decimal, "", false, false));


            this.TransportType = "";
            this.Ref = Guid.NewGuid();
            this.OrderRef = Guid.Empty;
            this.CrossOrderNo = "";
            this.TransportFirm = "";
            this.Driver = "";
            this.Plate = "";
            this.TransportDescription = "";
            this.TransportAddress = "";
            this.InvoiceAddress = true;
            this.Total = 0;
        }
    }
}
