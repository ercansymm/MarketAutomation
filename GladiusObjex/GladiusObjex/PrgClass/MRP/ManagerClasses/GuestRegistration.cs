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

namespace GladiusObjex.PrgClass.MRP.SettingClasses
{
    public class GuestRegistration:gsBase
    {
        private string _CardName;
        [Display(Name = "İsmi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _FirmName;
        [Display(Name = "Firma İsmi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string FirmName { get => _FirmName; set { _FirmName = value; SetUpdated("FirmName", value); } }

        private string _Plate;
        [Display(Name = "Plaka")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Plate { get => _Plate; set { _Plate = value; SetUpdated("Plate", value); } }

        private DateTime _EntryDate;
        public DateTime EntryDate { get => _EntryDate; set { _EntryDate = value; SetUpdated("EntryDate", value); } }

        private TimeSpan _EntryTime;
        public TimeSpan EntryTime { get => _EntryTime; set { _EntryTime = value; SetUpdated("EntryTime", value); } }

        private DateTime _OutDate;
        public DateTime OutDate { get => _OutDate; set { _OutDate = value; SetUpdated("OutDate", value); } }

        private TimeSpan _OutTime;
        public TimeSpan OutTime { get => _OutTime; set { _OutTime = value; SetUpdated("OutTime", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        public GuestRegistration()
        {
            TableName = "GuestRegistration";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("FirmName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Plate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EntryDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("EntryTime", SqlDbType.Time, "", false, false));
            Columns.Add(new ObjColumn("OutDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("OutTime", SqlDbType.Time, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.CardName = "";
            this.FirmName = "";
            this.Plate = "";
            this.EntryDate = DateTime.Today;
            this.EntryTime = DateTime.Today.TimeOfDay;
            this.OutDate = DateTime.Today;
            this.OutTime = DateTime.Today.TimeOfDay;
            this.Description = "";
        }
    }
}
