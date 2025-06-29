using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.IO;

namespace GladiusObjex.SystemClass
{
    public class Firms : gsBaseCard
    {
        public Guid _DatabaseRef;

        public Guid DatabaseRef { get => _DatabaseRef; set { _DatabaseRef = value; SetUpdated("DatabaseRef", value); } }

        public Guid _ErpConRef;

        public Guid ErpConRef { get => _ErpConRef; set { _ErpConRef = value; SetUpdated("ErpConRef", value); } }

        private string _MainCurr;
        [Display(Name = "Döviz Kuru")]
        [DataType("nvarchar")]
        [StringLength(5)]
        public string MainCurr { get => _MainCurr; set { _MainCurr = value; SetUpdated("MainCurr", value); } }

        private string _ReportCurr;
        [Display(Name = "Raporlama Kuru")]
        [DataType("nvarchar")]
        [StringLength(5)]
        public string ReportCurr { get => _ReportCurr; set { _ReportCurr = value; SetUpdated("ReportCurr", value); } }

        private bool _EInvoice;
        public bool EInvoice { get => _EInvoice; set { _EInvoice = value; SetUpdated("EInvoice", value); } }

        private bool _EDispatch;
        public bool EDispatch { get => _EDispatch; set { _EDispatch = value; SetUpdated("EDispatch", value); } }

        private byte[] _Images;

        [Display(Name = "Resim")]
        public byte[] Images { get => _Images; set { _Images = value; SetUpdated("Images", value); } }

        [NotMapped]
        public Image _myImage { get; set; }

        public virtual BindingList<Branches> BranchDetail { get; set; }

        public Firms GetFirms(Guid _REF)
        {
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            Firms myFirms = new Firms();

            myFirms = mng.GetObject<Firms>(_REF);
            myFirms.BranchDetail = mng.GetObjectList<Branches>(String.Format(" FirmRef = '{0}'", _REF), " BranchNo ");

            if (myFirms.Images != null && myFirms.Images.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(myFirms.Images))
                    {
                        myFirms._myImage = Image.FromStream(ms);
                    }
                }
                catch (Exception)
                { }
            }
            else
            {
                myFirms._myImage = null;
                myFirms.Images = new byte[] { };
            }

            return myFirms;
        }
        public Firms()
        {
            TableName = "Firms";

            Columns.Add(new ObjColumn("DatabaseRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("ErpConRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("MainCurr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ReportCurr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EInvoice", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("EDispatch", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Images", SqlDbType.Image, null, false, false));

            this.DatabaseRef = Guid.Empty; this.ErpConRef = Guid.Empty;
            this.MainCurr = ""; this.ReportCurr = "";
            this.EInvoice = false; this.EDispatch = false;
            this.Images = new byte[] { };

            BranchDetail = new BindingList<Branches>();
        }
    }
}
