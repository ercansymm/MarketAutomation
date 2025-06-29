using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.Tracing;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GladiusObjex.PrgClass.MRP.SalesClasses;

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockFiche:gsBase
    {
        private bool _IsCanceled;
        public bool IsCanceled { get => _IsCanceled; set { _IsCanceled = value; SetUpdated("IsCanceled", value); } }

        private string _DocType;
        [Display(Name = "Fiş Tipi")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string DocType { get => _DocType; set { _DocType = value; SetUpdated("DocType", value); } }
        /*"ACLFIS", "Açılış Fişi"
        "SKSFIS", "Sayım Kesinleştirme Fişi"
        "DNKFIS", "Depo Nakil Fişi"
        "SRFFIS", "Sarf Fişi"
        "FIRFIS", "Fire Fişi"
        "VIRFIS", "Stok Virman Fişi"
       //"STSIRS", "Satış İrsaliyesi"
       //"ALSIRS", "Alış İrsaliyesi"
        "PRDFIS", "Üretim Fişi"*/

        [Display(Name = "Dosya Seri No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        private string _DocSerialNo;
        public string DocSerialNo { get => _DocSerialNo; set { _DocSerialNo = value; SetUpdated("DocSerialNo", value); } }

        private DateTime _DocDate;
        public DateTime DocDate { get => _DocDate; set { _DocDate = value; SetUpdated("DocDate", value); } }

        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _FirmRef;
        public Guid FirmRef { get => _FirmRef; set { _FirmRef = value; SetUpdated("FirmRef", value); } }

        private Guid _BranchRef;
        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private Guid _WhouseRef;
        public Guid WhouseRef { get => _WhouseRef; set { _WhouseRef = value; SetUpdated("WhouseRef", value); } }

        private Guid _CrossBranchRef;
        public Guid CrossBranchRef { get => _CrossBranchRef; set { _CrossBranchRef = value; SetUpdated("CrossBranchRef", value); } }

        private Guid _CrossWhouseRef;
        public Guid CrossWhouseRef { get => _CrossWhouseRef; set { _CrossWhouseRef = value; SetUpdated("CrossWhouseRef", value); } }

        private string _SpeCode1;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }


        private Guid _DispatchRef;
        public Guid DispatchRef { get => _DispatchRef; set { _DispatchRef = value; SetUpdated("DispatchRef", value); } }

        private DateTime _DispatchDate;
        public DateTime DispatchDate { get => _DispatchDate; set { _DispatchDate = value; SetUpdated("DispatchDate", value); } }

        private bool _IsEdispatch;
        public bool IsEdispatch { get => _IsEdispatch; set { _IsEdispatch = value; SetUpdated("IsEdispatch", value); } }

        private Guid _TrackingRef;
        public Guid TrackingRef { get => _TrackingRef; set { _TrackingRef = value; SetUpdated("TrackingRef", value); } }


        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }
        /*
        0- Kesineştirilmedi	1- Kesinleştirildi
        */

        [NotMapped]
        public ClientCard Client { get; set; }

        public virtual BindingList<StockFicheDetails> Details { get; set; }

        public StockFiche getFiche(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockFiche myFiche = new StockFiche();

            myFiche = mng.GetObject<StockFiche>(Ref);
            myFiche.Details = mng.GetObjectList<StockFicheDetails>(" FicheRef='" + Ref + "'", "");

            return myFiche;

        }

        public StockFiche()
        {
            TableName = "StockFiche";

            Columns.Add(new ObjColumn("IsCanceled", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("DocType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocSerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("FirmRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WhouseRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CrossBranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CrossWhouseRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DispatchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("DispatchDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("IsEdispatch", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("TrackingRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));

            this.Ref = Guid.NewGuid();
            this.SpeCode1 = "";
            this.Description = "";
            this.IsCanceled = false;
            this.DocType = "";
            this.DocSerialNo = "";
            this.DocDate = DateTime.Today;
            this.ClientRef = Guid.Empty;
            this.Description = "";
            this.FirmRef = Guid.Empty;
            this.BranchRef = Guid.Empty;
            this.WhouseRef = Guid.Empty;
            this.CrossBranchRef = Guid.Empty;
            this.CrossWhouseRef = Guid.Empty;
            this.DispatchRef = Guid.Empty;
            this.DispatchDate = DateTime.Today;
            this.IsEdispatch = false;
            this.TrackingRef = Guid.Empty;
            this.State = 0;
            Details = new BindingList<StockFicheDetails>();
        }
    }
}
