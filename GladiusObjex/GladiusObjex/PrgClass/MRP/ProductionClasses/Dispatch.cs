using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class Dispatch:gsBase
    {
        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private Guid _ShipmentRef;
        public Guid ShipmentRef { get => _ShipmentRef; set { _ShipmentRef = value; SetUpdated("ShipmentRef", value); } }

        private Guid _ExportClientRef;
        public Guid ExportClientRef { get => _ExportClientRef; set { _ExportClientRef = value; SetUpdated("ExportClientRef", value); } }

        private DateTime _DispatchDate;
        public DateTime DispatchDate { get => _DispatchDate; set { _DispatchDate = value; SetUpdated("DispatchDate", value); } }

        private string _DispatchNo;
        [Display(Name = "İrsaliye No")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string DispatchNo { get => _DispatchNo; set { _DispatchNo = value; SetUpdated("DispatchNo", value); } }

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

        private string _SpecialCode1;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode1 { get => _SpecialCode1; set { _SpecialCode1 = value; SetUpdated("SpecialCode1", value); } }

        private string _SpecialCode2;
        [Display(Name = "Özel Kod2")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode2 { get => _SpecialCode2; set { _SpecialCode2 = value; SetUpdated("SpecialCode2", value); } }

        private string _SpecialCode3;
        [Display(Name = "Özel Kod3")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode3 { get => _SpecialCode3; set { _SpecialCode3 = value; SetUpdated("SpecialCode3", value); } }


        private int _DispatchType;
        public int DispatchType { get => _DispatchType; set { _DispatchType = value; SetUpdated("DispatchType", value); } }

        /*
         0 - Satış İrsaliyesi
         1 - Alış İrsaliyesi
         */

        private int _LogoState;
        public int LogoState { get => _LogoState; set { _LogoState = value; SetUpdated("LogoState", value); } }
        /*
         0 - Bekleyen
         1 - Gönderilen
        */

        public virtual BindingList<DispatchDetail> DispatchDetail { get; set; }
        public Dispatch getDispatch(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Dispatch myDispatch = new Dispatch();

            myDispatch = mng.GetObject<Dispatch>(Ref);
            myDispatch.DispatchDetail = mng.GetObjectList<DispatchDetail>("DispatchRef = '" + Ref + "'", "");

            return myDispatch;
        }

        public Dispatch()
        {

            TableName = "Dispatch"; 

            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ShipmentRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Plate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DispatchDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DispatchNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode3", SqlDbType.NVarChar, "", false, false));

            Columns.Add(new ObjColumn("DispatchType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LogoState", SqlDbType.Int, "", false, false));

            Columns.Add(new ObjColumn("ExportClientRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.ClientRef = Guid.Empty;
            this.ShipmentRef = Guid.Empty;
            this.Plate = "";
            this.Description = "";
            this.DispatchDate = DateTime.Now;
            this.DispatchNo = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.SpecialCode3 = "";
            this.DispatchType = 0;
            this.LogoState = 0;
            this.ExportClientRef = Guid.Empty;

            DispatchDetail = new BindingList<DispatchDetail>();
        }
    }
}
