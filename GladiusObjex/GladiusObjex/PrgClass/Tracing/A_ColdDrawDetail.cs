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

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_ColdDrawDetail : gsBase
    {
        private Guid _DrawRef;
        public Guid DrawRef { get => _DrawRef; set { _DrawRef = value; SetUpdated("DrawRef", value); } }

        private int _LineNo;
        public int LineNo { get => _LineNo; set { _LineNo = value; SetUpdated("LineNo", value); } }

        private string _PartyNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(16)]
        public string PartyNo { get => _PartyNo; set { _PartyNo = value; SetUpdated("PartyNo", value); } }

        private decimal _MaterialDiameter;
        public decimal MaterialDiameter { get => _MaterialDiameter; set { _MaterialDiameter = value; SetUpdated("MaterialDiameter", value); } }

        private Guid _QualityRef;
        public Guid QualityRef { get => _QualityRef; set { _QualityRef = value; SetUpdated("QualityRef", value); } }

        private decimal _ProductDiameter;
        public decimal ProductDiameter { get => _ProductDiameter; set { _ProductDiameter = value; SetUpdated("ProductDiameter", value); } }

        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _LabelCount;
        public int LabelCount { get => _LabelCount; set { _LabelCount = value; SetUpdated("LabelCount", value); } }

        private string _LabelName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string LabelName { get => _LabelName; set { _LabelName = value; SetUpdated("LabelName", value); } }

        public A_ColdDrawDetail()
        {
            this.TableName = "A_ColdDrawDetail";

            Columns.Add(new ObjColumn("DrawRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LineNo", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("PartyNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("MaterialDiameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("QualityRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("ProductDiameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LabelCount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LabelName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.DrawRef = Guid.Empty;
            this.LineNo = 1;
            this.PartyNo = "";
            this.MaterialDiameter = 0;
            this.QualityRef = Guid.Empty;
            this.ProductDiameter = 0;
            this.Amount = 0;
            this.LabelCount = 1;
            this.LabelName = "";

        }

    }
}
