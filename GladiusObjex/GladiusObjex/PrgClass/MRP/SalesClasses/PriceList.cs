using GladiusObjex.BaseClass;
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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class PriceList:gsBase
    {
        private string _CardName;
        [Display(Name = "Liste İsmi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _SerialNo;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string SerialNo { get => _SerialNo; set { _SerialNo = value; SetUpdated("SerialNo", value); } }

        private string _SpecialCode;
        [Display(Name = "Özel Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode { get => _SpecialCode; set { _SpecialCode = value; SetUpdated("SpecialCode", value); } }

        private string _Description;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private DateTime _StartDate;
        public DateTime StartDate { get => _StartDate; set { _StartDate = value; SetUpdated("StartDate", value); } }

        private DateTime _EndDate;
        public DateTime EndDate { get => _EndDate; set { _EndDate = value; SetUpdated("EndDate", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        public virtual BindingList<PriceListDetail> PriceDetail { get; set; }

        public PriceList getList(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            PriceList myList = new PriceList();

            myList = mng.GetObject<PriceList>(Ref);
            myList.PriceDetail = mng.GetObjectList<PriceListDetail>(" PriceListRef='" + Ref + "'", "");

            return myList;
        }

        public PriceList()
        {

            TableName = "PriceList";

            Columns.Add(new ObjColumn("SerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StartDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("EndDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.IsPassive = true;
            this.SerialNo = "";
            this.SpecialCode = "";
            this.Description = "";
            this.CardName = "";
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today;
            this.Curr = "TRY";

            PriceDetail = new BindingList<PriceListDetail>();
        }
    }
}
