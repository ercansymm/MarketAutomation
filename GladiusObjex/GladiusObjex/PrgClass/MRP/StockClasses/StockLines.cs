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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockLines:gsBase
    {
        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _SpecialCode;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string SpecialCode { get => _SpecialCode; set { _SpecialCode = value; SetUpdated("SpecialCode", value); } }

        private Guid _StockFicheRef;
        public Guid StockFicheRef { get => _StockFicheRef; set { _StockFicheRef = value; SetUpdated("StockFicheRef", value); } }

        private Guid _StockFicheDetailRef;
        public Guid StockFicheDetailRef { get => _StockFicheDetailRef; set { _StockFicheDetailRef = value; SetUpdated("StockFicheDetailRef", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _LineIO;
        public int LineIO { get => _LineIO; set { _LineIO = value; SetUpdated("LineIO", value); } }

        private DateTime _FicheDate;
        public DateTime FicheDate { get => _FicheDate; set { _FicheDate = value; SetUpdated("FicheDate", value); } }

        private string _SourceType;
        [Display(Name = "Kaynak Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SourceType { get => _SourceType; set { _SourceType = value; SetUpdated("SourceType", value); } }


        private Guid _BranchRef;
        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private Guid _WhouseRef;
        public Guid WhouseRef { get => _WhouseRef; set { _WhouseRef = value; SetUpdated("WhouseRef", value); } }

        public StockLines()
        {
            TableName = "StockLines";

            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockFicheRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LineIO", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("FicheDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("StockFicheDetailRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SourceType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WhouseRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.Description = "";
            this.SpecialCode = "";
            this.SourceType = "";
            this.StockFicheRef = Guid.Empty;
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.LineIO = 0;
            this.Ref = Guid.NewGuid();
            this.FicheDate = DateTime.Today;
            this.StockFicheDetailRef = Guid.Empty;
            this.SourceType = "";
            this.BranchRef = Guid.Empty;
            this.WhouseRef = Guid.Empty;
        }
    }
}
