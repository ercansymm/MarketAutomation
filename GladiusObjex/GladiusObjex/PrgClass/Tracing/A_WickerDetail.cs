using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_WickerDetail : gsBase
    {
        private Guid _WickerRef;
        public Guid WickerRef { get => _WickerRef; set { _WickerRef = value; SetUpdated("WickerRef", value); } }

        private string _PartyNo;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(16)]
        public string PartyNo { get => _PartyNo; set { _PartyNo = value; SetUpdated("PartyNo", value); } }

        private Guid _QualityRef;
        public Guid QualityRef { get => _QualityRef; set { _QualityRef = value; SetUpdated("QualityRef", value); } }

        private int _LabelCount;
        public int LabelCount { get => _LabelCount; set { _LabelCount = value; SetUpdated("LabelCount", value); } }

        private string _LabelName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string LabelName { get => _LabelName; set { _LabelName = value; SetUpdated("LabelName", value); } }

        private string _WickerType;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string WickerType { get => _WickerType; set { _WickerType = value; SetUpdated("WickerType", value); } }

        private string _WickerName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string WickerName { get => _WickerName; set { _WickerName = value; SetUpdated("WickerName", value); } }

        private int _PartyAmount;
        public int PartyAmount { get => _PartyAmount; set { _PartyAmount = value; SetUpdated("PartyAmount", value); } }

        private int _TotalAmount;
        public int TotalAmount { get => _TotalAmount; set { _TotalAmount = value; SetUpdated("TotalAmount", value); } }

        private int _PacketAmount;
        public int PacketAmount { get => _PacketAmount; set { _PacketAmount = value; SetUpdated("PacketAmount", value); } }

        private decimal _LargestDiameter;
        public decimal LargestDiameter { get => _LargestDiameter; set { _LargestDiameter = value; SetUpdated("LargestDiameter", value); } }

        private decimal _LargestLenght;
        public decimal LargestLenght { get => _LargestLenght; set { _LargestLenght = value; SetUpdated("LargestLenght", value); } }

        private decimal _LargestInterval1;
        public decimal LargestInterval1 { get => _LargestInterval1; set { _LargestInterval1 = value; SetUpdated("LargestInterval1", value); } }

        private decimal _LargestInterval2;
        public decimal LargestInterval2 { get => _LargestInterval2; set { _LargestInterval2 = value; SetUpdated("LargestInterval2", value); } }

        private decimal _LargestTipLenght;
        public decimal LargestTipLenght { get => _LargestTipLenght; set { _LargestTipLenght = value; SetUpdated("LargestTipLenght", value); } }

        private decimal _LargestAmount;
        public decimal LargestAmount { get => _LargestAmount; set { _LargestAmount = value; SetUpdated("LargestAmount", value); } }

        private decimal _LenghtDiameter;
        public decimal LenghtDiameter { get => _LenghtDiameter; set { _LenghtDiameter = value; SetUpdated("LenghtDiameter", value); } }

        private decimal _LenghtLenght;
        public decimal LenghtLenght { get => _LenghtLenght; set { _LenghtLenght = value; SetUpdated("LenghtLenght", value); } }

        private decimal _LenghtInterval1;
        public decimal LenghtInterval1 { get => _LenghtInterval1; set { _LenghtInterval1 = value; SetUpdated("LenghtInterval1", value); } }

        private decimal _LenghtInterval2;
        public decimal LenghtInterval2 { get => _LenghtInterval2; set { _LenghtInterval2 = value; SetUpdated("LenghtInterval2", value); } }

        private decimal _LenghtTipLenght;
        public decimal LenghtTipLenght { get => _LenghtTipLenght; set { _LenghtTipLenght = value; SetUpdated("LenghtTipLenght", value); } }

        private decimal _LenghtAmount;
        public decimal LenghtAmount { get => _LenghtAmount; set { _LenghtAmount = value; SetUpdated("LenghtAmount", value); } }

        public A_WickerDetail()
        {
            this.TableName = "A_WickerDetail";

            Columns.Add(new ObjColumn("WickerRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PartyNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("QualityRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LabelCount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LabelName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WickerType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WickerName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PartyAmount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("TotalAmount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("PacketAmount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("LargestDiameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LargestLenght", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LargestInterval1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LargestInterval2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LargestTipLenght", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LargestAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtDiameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtLenght", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtInterval1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtInterval2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtTipLenght", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LenghtAmount", SqlDbType.Decimal, "", false, false));

            this.Ref = Guid.NewGuid();
            this.WickerRef = Guid.Empty;
            this.PartyNo = "";
            this.QualityRef = Guid.Empty;
            this.LabelCount = 1;
            this.LabelName = "";
            this.WickerType = "";
            this.WickerName = "";
            this.PartyAmount = 0;
            this.TotalAmount = 0;
            this.PacketAmount = 0;
            this.LargestDiameter = 0;
            this.LargestLenght = 0;
            this.LargestInterval1 = 0;
            this.LargestInterval2 = 0;
            this.LargestTipLenght = 0;
            this.LargestAmount = 0;
            this.LenghtDiameter = 0;
            this.LenghtLenght = 0;
            this.LenghtInterval1 = 0;
            this.LenghtInterval2 = 0;
            this.LenghtTipLenght = 0;
            this.LenghtAmount = 0;

        }

    }
}
