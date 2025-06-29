using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.ProductionClasses;
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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockDocuments:gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private string _DocumentName;
        [Display(Name = "Döküman İsmi")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string DocumentName { get => _DocumentName; set { _DocumentName = value; SetUpdated("DocumentName", value); } }

        private byte[] _Documents;
        public byte[] Documents { get => _Documents; set { _Documents = value; SetUpdated("Documents", value); } }

        [ForeignKey("StockRef")]
        public virtual StockCard Stock { get; set; }

        public StockDocuments()
        {

            TableName = "StockDocuments";

            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Documents", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("DocumentName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.Documents = new byte[] { };
            this.StockRef = Guid.Empty;
            this.DocumentName = "";
        }
    }
}
