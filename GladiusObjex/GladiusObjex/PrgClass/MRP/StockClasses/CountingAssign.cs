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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class CountingAssign:gsBase
    {
        private DateTime _CountingDate;
        public DateTime CountingDate { get => _CountingDate; set { _CountingDate = value; SetUpdated("CountingDate", value); } }

        private Guid _SectionRef;
        public Guid SectionRef { get => _SectionRef; set { _SectionRef = value; SetUpdated("SectionRef", value); } }

        private Guid _EmployeeRef;
        public Guid EmployeeRef { get => _EmployeeRef; set { _EmployeeRef = value; SetUpdated("EmployeeRef", value); } }

        private string _CountNo;
        [Display(Name = "Sayım No")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CountNo { get => _CountNo; set { _CountNo = value; SetUpdated("CountNo", value); } }

        private Guid _BranchRef;
        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private Guid _WhouseRef;
        public Guid WhouseRef { get => _WhouseRef; set { _WhouseRef = value; SetUpdated("WhouseRef", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        /*
         0 - Bekliyor 
         1 - Başladı
         2 - Bitti 
         3 - Kesinleştirildi
         */

        public virtual BindingList<CountingAssignDetail> CountingDetails { get; set; }

        public CountingAssign getCounting(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            CountingAssign myCounting = new CountingAssign();

            myCounting = mng.GetObject<CountingAssign>(Ref);
            myCounting.CountingDetails = mng.GetObjectList<CountingAssignDetail>(" CountingAssignRef='" + Ref + "'", "");

            return myCounting;

        }

        public CountingAssign()
        {
            TableName = "CountingAssign";

            Columns.Add(new ObjColumn("CountingDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("SectionRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("EmployeeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("CountNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WhouseRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Ref = Guid.NewGuid();
            this.CountingDate = DateTime.Today ;
            this.SectionRef = Guid.Empty;
            this.EmployeeRef = Guid.Empty;
            this.State = 0;
            this.CountNo = "";
            this.WhouseRef = Guid.Empty;
            this.BranchRef = Guid.Empty;

            CountingDetails = new BindingList<CountingAssignDetail>();
        }
    }
}
