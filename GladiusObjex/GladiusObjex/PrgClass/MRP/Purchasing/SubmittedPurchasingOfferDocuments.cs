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

namespace GladiusObjex.PrgClass.MRP.Purchasing
{
    public class SubmittedPurchasingOfferDocuments:gsBase
    {
        private string _DocumentName;
        [Display(Name = "Döküman Adı")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string DocumentName { get => _DocumentName; set { _DocumentName = value; SetUpdated("DocumentName", value); } }

        private Guid _SubmittedPurchasingOfferRef;
        public Guid SubmittedPurchasingOfferRef { get => _SubmittedPurchasingOfferRef; set { _SubmittedPurchasingOfferRef = value; SetUpdated("SubmittedPurchasingOfferRef", value); } }

        private byte[] _Documents;
        public byte[] Documents { get => _Documents; set { _Documents = value; SetUpdated("Documents", value); } }

        public SubmittedPurchasingOfferDocuments()
        {
            TableName = "SubmittedPurchasingOfferDocuments";

            Columns.Add(new ObjColumn("DocumentName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SubmittedPurchasingOfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Documents", SqlDbType.Image, "", false, false));

            this.Ref = Guid.NewGuid();
            this.SubmittedPurchasingOfferRef = Guid.Empty;
            this.Documents = new byte[] { };

        }
    }
}
