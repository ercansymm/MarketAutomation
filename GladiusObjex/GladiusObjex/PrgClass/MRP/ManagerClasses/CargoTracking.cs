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

namespace GladiusObjex.PrgClass.MRP.ManagerClasses
{
    public class CargoTracking:gsBase
    {
        
        private string _Client;
        [Display(Name = "Cari")]
        [DataType("nvarchar")]
        [StringLength(800)]
        public string Client { get => _Client; set { _Client = value; SetUpdated("Client", value); } }

        private int _LineNo_;
        public int LineNo_ { get => _LineNo_; set { _LineNo_ = value; SetUpdated("LineNo_", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(800)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private DateTime _Date;
        public DateTime Date { get => _Date; set { _Date = value; SetUpdated("Date", value); } }

        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private string _CardType;
        [Display(Name = "Tipi")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardType { get => _CardType; set { _CardType = value; SetUpdated("CardType", value); } }

        private string _Attach;
        [Display(Name = "Ek")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Attach { get => _Attach; set { _Attach = value; SetUpdated("Attach", value); } }

        private string _Firm;
        [Display(Name = "Firma")]
        [DataType("nvarchar")]
        [StringLength(800)]
        public string Firm { get => _Firm; set { _Firm = value; SetUpdated("Firm", value); } }

        public CargoTracking()
        {
            TableName = "CargoTracking";

            Columns.Add(new ObjColumn("Firm", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Attach", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Date", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("LineNo_", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Client", SqlDbType.NVarChar, "", false, false));

            this.Description = "";
            this.Firm = "";
            this.Attach = "";
            this.CardType = "";
            this.Amount = 1;
            this.Date = DateTime.Now;
            this.LineNo_ = 1;
            this.Client = "";
        }
    }
}
