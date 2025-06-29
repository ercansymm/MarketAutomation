using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_CuttingDetail : gsBase
    {
        private Guid _CutRef;
        public Guid CutRef { get => _CutRef; set { _CutRef = value; SetUpdated("CutRef", value); } }

        private int _LineNo;
        public int LineNo { get => _LineNo; set { _LineNo = value; SetUpdated("LineNo", value); } }

        private string _PartyNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(16)]
        public string PartyNo { get => _PartyNo; set { _PartyNo = value; SetUpdated("PartyNo", value); } }

        private Guid _QualityRef;
        public Guid QualityRef { get => _QualityRef; set { _QualityRef = value; SetUpdated("QualityRef", value); } }

        private decimal _Diameter;
        public decimal Diameter { get => _Diameter; set { _Diameter = value; SetUpdated("Diameter", value); } }

        private decimal _Size;
        public decimal Size { get => _Size; set { _Size = value; SetUpdated("Size", value); } }

        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _LabelCount;
        public int LabelCount { get => _LabelCount; set { _LabelCount = value; SetUpdated("LabelCount", value); } }

        private string _LabelName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string LabelName { get => _LabelName; set { _LabelName = value; SetUpdated("LabelName", value); } }

        public A_CuttingDetail()
        {
            this.TableName = "A_CuttingDetail";

            Columns.Add(new ObjColumn("CutRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LineNo", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("PartyNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("QualityRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Diameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Size", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LabelCount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LabelName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.CutRef = Guid.Empty;
            this.LineNo = 1;
            this.PartyNo = "";
            this.Diameter = 0;
            this.QualityRef = Guid.Empty;
            this.Size = 0;
            this.Amount = 0;
            this.LabelCount = 1;
            this.LabelName = "";

        }
    }
}
