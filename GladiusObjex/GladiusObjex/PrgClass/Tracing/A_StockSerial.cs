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
    public class A_StockSerial : gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private string _SerialNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _HeatNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string HeatNo { get => _HeatNo; set { _HeatNo = value; SetUpdated("HeatNo", value); } }

        private string _LotNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string LotNo { get => _LotNo; set { _LotNo = value; SetUpdated("LotNo", value); } }

        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private decimal _UnitAmount;
        public decimal UnitAmount { get => _UnitAmount; set { _UnitAmount = value; SetUpdated("UnitAmount", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private string _Description_;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description_ { get => _Description_; set { _Description_ = value; SetUpdated("Description_", value); } }

        private string _SpeCode1;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        public A_StockSerial()
        {
            this.TableName = "A_StockSerial";

            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("HeatNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LotNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Date_", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description_", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.SerialNo = "";
            this.HeatNo = "";
            this.LotNo = "";
            this.Date_ = DateTime.Now;
            this.Amount = 0;
            this.UnitAmount = 0;
            this.Barcode = "";
            this.Description_ = "";
            this.SpeCode1 = "";


        }
    }
}
