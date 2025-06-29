using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class SalesOfferLines:gsBase
    {

        private int _LineNumber;
        public int LineNumber { get => _LineNumber; set { _LineNumber = value; SetUpdated("LineNumber", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _OfferRef;
        public Guid OfferRef { get => _OfferRef; set { _OfferRef = value; SetUpdated("OfferRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private decimal _Amount;
        public decimal Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private decimal _UnitTotalPrice;
        public decimal UnitTotalPrice { get => _UnitTotalPrice; set { _UnitTotalPrice = value; SetUpdated("UnitTotalPrice", value); } }

        private decimal _KDV;
        public decimal KDV { get => _KDV; set { _KDV = value; SetUpdated("KDV", value); } }

        private decimal _KDVTotal;
        public decimal KDVTotal { get => _KDVTotal; set { _KDVTotal = value; SetUpdated("KDVTotal", value); } }

        private decimal _GeneralTotal;
        public decimal GeneralTotal { get => _GeneralTotal; set { _GeneralTotal = value; SetUpdated("GeneralTotal", value); } }

        private decimal _DiscountUnitPrice;
        public decimal DiscountUnitPrice { get => _DiscountUnitPrice; set { _DiscountUnitPrice = value; SetUpdated("DiscountUnitPrice", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private Guid _ColorRef;
        public Guid ColorRef { get => _ColorRef; set { _ColorRef = value; SetUpdated("ColorRef", value); } }

        private decimal _Measure1;
        public decimal Measure1 { get => _Measure1; set { _Measure1 = value; SetUpdated("Measure1", value); } }

        private decimal _Measure2;
        public decimal Measure2 { get => _Measure2; set { _Measure2 = value; SetUpdated("Measure2", value); } }

        private decimal _Measure3;
        public decimal Measure3 { get => _Measure3; set { _Measure3 = value; SetUpdated("Measure3", value); } }

        private decimal _RollH;
        public decimal RollH { get => _RollH; set { _RollH = value; SetUpdated("RollH", value); } }

        private decimal _RollL;
        public decimal RollL { get => _RollL; set { _RollL = value; SetUpdated("RollL", value); } }

        private decimal _InterocularDistance1;
        public decimal InterocularDistance1 { get => _InterocularDistance1; set { _InterocularDistance1 = value; SetUpdated("InterocularDistance1", value); } }

        private decimal _InterocularDistance2;
        public decimal InterocularDistance2 { get => _InterocularDistance2; set { _InterocularDistance2 = value; SetUpdated("InterocularDistance2", value); } }

        private decimal _RollDiameter;
        public decimal RollDiameter { get => _RollDiameter; set { _RollDiameter = value; SetUpdated("RollDiameter", value); } }

        private decimal _PVC;
        public decimal PVC { get => _PVC; set { _PVC = value; SetUpdated("PVC", value); } }

        private decimal _Diameter;
        public decimal Diameter { get => _Diameter; set { _Diameter = value; SetUpdated("Diameter", value); } }

        private decimal _UnitPrice;
        public decimal UnitPrice { get => _UnitPrice; set { _UnitPrice = value; SetUpdated("UnitPrice", value); } }

        private string _Grass;
        [Display(Name = "Çim")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Grass { get => _Grass; set { _Grass = value; SetUpdated("Grass", value); } }

        private decimal _WindingAmount;
        public decimal WindingAmount { get => _WindingAmount; set { _WindingAmount = value; SetUpdated("WindingAmount", value); } }

        private Guid _MeasureRef;
        public Guid MeasureRef { get => _MeasureRef; set { _MeasureRef = value; SetUpdated("MeasureRef", value); } }

        private decimal _Discount;
        public decimal Discount { get => _Discount; set { _Discount = value; SetUpdated("Discount", value); } }


        private decimal _FlatbarThickness;
        public decimal FlatbarThickness { get => _FlatbarThickness; set { _FlatbarThickness = value; SetUpdated("FlatbarThickness", value); } }

        private decimal _FlatbarWidth;
        public decimal FlatbarWidth { get => _FlatbarWidth; set { _FlatbarWidth = value; SetUpdated("FlatbarWidth", value); } }

        private decimal _FlatbarHeight;
        public decimal FlatbarHeight { get => _FlatbarHeight; set { _FlatbarHeight = value; SetUpdated("FlatbarHeight", value); } }

        private decimal _Height;
        public decimal Height { get => _Height; set { _Height = value; SetUpdated("Height", value); } }

        private decimal _Length;
        public decimal Length { get => _Length; set { _Length = value; SetUpdated("Length", value); } }

        private decimal _ProfilePipe;
        public decimal ProfilePipe { get => _ProfilePipe; set { _ProfilePipe = value; SetUpdated("ProfilePipe", value); } }

        private string _PanelType;
        [Display(Name = "Panel Tipi")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string PanelType { get => _PanelType; set { _PanelType = value; SetUpdated("PanelType", value); } }

        private string _Foot;
        [Display(Name = "Ayak")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Foot { get => _Foot; set { _Foot = value; SetUpdated("Foot", value); } }

        private decimal _WireDiameter1;
        public decimal WireDiameter1 { get => _WireDiameter1; set { _WireDiameter1 = value; SetUpdated("WireDiameter1", value); } }

        private decimal _WireDiameter2;
        public decimal WireDiameter2 { get => _WireDiameter2; set { _WireDiameter2 = value; SetUpdated("WireDiameter2", value); } }

        private int _GrassType;
        public int GrassType { get => _GrassType; set { _GrassType = value; SetUpdated("GrassType", value); } }

        private int _WireType;
        public int WireType { get => _WireType; set { _WireType = value; SetUpdated("WireType", value); } }

        private int _DoorType;
        public int DoorType { get => _DoorType; set { _DoorType = value; SetUpdated("DoorType", value); } }

        private int _BarbedWireType;
        public int BarbedWireType { get => _BarbedWireType; set { _BarbedWireType = value; SetUpdated("BarbedWireType", value); } }

        private string _Material;
        [Display(Name = "Materyal")]
        [DataType("nvarchar")]
        [StringLength(750)]
        public string Material { get => _Material; set { _Material = value; SetUpdated("Material", value); } }

        private string _Plated;
        [Display(Name = "Kaplama")]
        [DataType("nvarchar")]
        [StringLength(750)]
        public string Plated { get => _Plated; set { _Plated = value; SetUpdated("Plated", value); } }

        private string _SheetMetal;
        [Display(Name = "Sac")]
        [DataType("nvarchar")]
        [StringLength(750)]
        public string SheetMetal { get => _SheetMetal; set { _SheetMetal = value; SetUpdated("SheetMetal", value); } }

        private decimal _LoopSize;
        public decimal LoopSize { get => _LoopSize; set { _LoopSize = value; SetUpdated("LoopSize", value); } }

        private decimal _KompozitPanel1;
        public decimal KompozitPanel1 { get => _KompozitPanel1; set { _KompozitPanel1 = value; SetUpdated("KompozitPanel1", value); } }

        private decimal _KompozitPanel2;
        public decimal KompozitPanel2 { get => _KompozitPanel2; set { _KompozitPanel2 = value; SetUpdated("KompozitPanel2", value); } }

        private decimal _KompozitPanel3;
        public decimal KompozitPanel3 { get => _KompozitPanel3; set { _KompozitPanel3 = value; SetUpdated("KompozitPanel3", value); } }

        private decimal _UProfil1;
        public decimal UProfil1 { get => _UProfil1; set { _UProfil1 = value; SetUpdated("UProfil1", value); } }

        private decimal _UProfil2;
        public decimal UProfil2 { get => _UProfil2; set { _UProfil2 = value; SetUpdated("UProfil2", value); } }

        private decimal _UProfil3;
        public decimal UProfil3 { get => _UProfil3; set { _UProfil3 = value; SetUpdated("UProfil3", value); } }

        private decimal _UProfil4;
        public decimal UProfil4 { get => _UProfil4; set { _UProfil4 = value; SetUpdated("UProfil4", value); } }

        private string _Hinges;
        [Display(Name = "Menteşe")]
        [DataType("nvarchar")]
        [StringLength(750)]
        public string Hinges { get => _Hinges; set { _Hinges = value; SetUpdated("Hinges", value); } }

        private string _LockAndHandle;
        [Display(Name = "KilitVeKol")]
        [DataType("nvarchar")]
        [StringLength(750)]
        public string LockAndHandle { get => _LockAndHandle; set { _LockAndHandle = value; SetUpdated("LockAndHandle", value); } }

        private decimal _DoorPanel1;
        public decimal DoorPanel1 { get => _DoorPanel1; set { _DoorPanel1 = value; SetUpdated("DoorPanel1", value); } }

        private decimal _DoorPanel2;
        public decimal DoorPanel2 { get => _DoorPanel2; set { _DoorPanel2 = value; SetUpdated("DoorPanel2", value); } }

        private decimal _DoorPanel3;
        public decimal DoorPanel3 { get => _DoorPanel3; set { _DoorPanel3 = value; SetUpdated("DoorPanel3", value); } }

        private string _LeafProfileType;
        [Display(Name = "Kanat Profil Tipi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string LeafProfileType { get => _LeafProfileType; set { _LeafProfileType = value; SetUpdated("LeafProfileType", value); } }

        private string _RailType;
        [Display(Name = "Ray Tipi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string RailType { get => _RailType; set { _RailType = value; SetUpdated("RailType", value); } }

        private string _PostProfileType;
        [Display(Name = "Direk Profil Tipi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string PostProfileType { get => _PostProfileType; set { _PostProfileType = value; SetUpdated("PostProfileType", value); } }

        private string _EngineType;
        [Display(Name = "Motor Tipi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string EngineType { get => _EngineType; set { _EngineType = value; SetUpdated("EngineType", value); } }

        private string _DoorPanelType;
        [Display(Name = "Kapı Panel Tipi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string DoorPanelType { get => _DoorPanelType; set { _DoorPanelType = value; SetUpdated("DoorPanelType", value); } }

        private decimal _HorizontalProfile1;
        public decimal HorizontalProfile1 { get => _HorizontalProfile1; set { _HorizontalProfile1 = value; SetUpdated("HorizontalProfile1", value); } }

        private decimal _HorizontalProfile2;
        public decimal HorizontalProfile2 { get => _HorizontalProfile2; set { _HorizontalProfile2 = value; SetUpdated("HorizontalProfile2", value); } }

        private decimal _HorizontalProfile3;
        public decimal HorizontalProfile3 { get => _HorizontalProfile3; set { _HorizontalProfile3 = value; SetUpdated("HorizontalProfile3", value); } }

        private decimal _VerticalProfile1;
        public decimal VerticalProfile1 { get => _VerticalProfile1; set { _VerticalProfile1 = value; SetUpdated("VerticalProfile1", value); } }

        private decimal _VerticalProfile2;
        public decimal VerticalProfile2 { get => _VerticalProfile2; set { _VerticalProfile2 = value; SetUpdated("VerticalProfile2", value); } }

        private decimal _VerticalProfile3;
        public decimal VerticalProfile3 { get => _VerticalProfile3; set { _VerticalProfile3 = value; SetUpdated("VerticalProfile3", value); } }

        private string _PanelCap;
        [Display(Name = "Panel Kapak")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string PanelCap { get => _PanelCap; set { _PanelCap = value; SetUpdated("PanelCap", value); } }

        private string _Razor;
        [Display(Name = "Diken")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string Razor { get => _Razor; set { _Razor = value; SetUpdated("Razor", value); } }

        private string _RockWool;
        [Display(Name = "Kaya Yünü")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string RockWool { get => _RockWool; set { _RockWool = value; SetUpdated("RockWool", value); } }

        private decimal _LeafProfile1;
        public decimal LeafProfile1 { get => _LeafProfile1; set { _LeafProfile1 = value; SetUpdated("LeafProfile1", value); } }

        private decimal _LeafProfile2;
        public decimal LeafProfile2 { get => _LeafProfile2; set { _LeafProfile2 = value; SetUpdated("LeafProfile2", value); } }

        private decimal _LeafProfile3;
        public decimal LeafProfile3 { get => _LeafProfile3; set { _LeafProfile3 = value; SetUpdated("LeafProfile3", value); } }

        [ForeignKey("OfferRef")]
        public virtual SalesOffer SalesOffer { get; set; }

        public SalesOfferLines()
        {
            TableName = "SalesOfferLines";

            Columns.Add(new ObjColumn("LineNumber", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("OfferRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UnitTotalPrice", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KDV", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KDVTotal", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("GeneralTotal", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UnitPrice", SqlDbType.Decimal, "", false, false));

            Columns.Add(new ObjColumn("ColorRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Measure1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Measure2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Measure3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("RollH", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("RollL", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("InterocularDistance1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("InterocularDistance2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("RollDiameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("PVC", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Diameter", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Grass", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WindingAmount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("MeasureRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Discount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("DiscountUnitPrice", SqlDbType.Decimal, "", false, false));

            Columns.Add(new ObjColumn("FlatbarThickness", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("FlatbarWidth", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("FlatbarHeight", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Height", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Length", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("ProfilePipe", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("PanelType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Foot", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WireDiameter1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("WireDiameter2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("GrassType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("WireType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("DoorType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Material", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Plated", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SheetMetal", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LoopSize", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KompozitPanel1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KompozitPanel2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("KompozitPanel3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UProfil1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UProfil2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UProfil3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("UProfil4", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("Hinges", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LockAndHandle", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DoorPanel1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("DoorPanel2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("DoorPanel3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LeafProfileType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("RailType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PostProfileType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EngineType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DoorPanelType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BarbedWireType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("HorizontalProfile1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("HorizontalProfile2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("HorizontalProfile3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("VerticalProfile1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("VerticalProfile2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("VerticalProfile3", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("PanelCap", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Razor", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("RockWool", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LeafProfile1", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LeafProfile2", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("LeafProfile3", SqlDbType.Decimal, "", false, false));


            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.OfferRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.UnitTotalPrice = 0;
            this.KDV = 0;
            this.KDVTotal = 0;
            this.GeneralTotal = 0;
            this.Description = "";
            this.ColorRef = Guid.Empty;
            this.Measure1 = 0;
            this.Measure2 = 0;
            this.Measure3 = 0;
            this.RollH = 0;
            this.RollL = 0;
            this.InterocularDistance1 = 0;
            this.InterocularDistance2 = 0;
            this.RollDiameter = 0;
            this.PVC = 0;
            this.Diameter = 0;
            this.Grass = "";
            this.WindingAmount = 0;
            this.LineNumber = 1;
            this.UnitPrice = 0;
            this.MeasureRef = Guid.Empty;
            this.Discount = 0;
            this.DiscountUnitPrice = 0;

            this.FlatbarThickness = 0;
            this.FlatbarWidth = 0;
            this.FlatbarHeight = 0;
            this.Height = 0;
            this.Length = 0;
            this.ProfilePipe = 0;
            this.PanelType = "";
            this.Foot = "";
            this.WireDiameter1 = 0;
            this.WireDiameter2 = 0;
            this.GrassType = 0;
            this.WireType = 0;
            this.DoorType = 0;
            this.BarbedWireType = 0;
            this.Material = "";
            this.Plated = "";
            this.SheetMetal = "";
            this.LoopSize = 0;
            this.KompozitPanel1 = 0;
            this.KompozitPanel2 = 0;
            this.KompozitPanel3 = 0;
            this.UProfil1 = 0;
            this.UProfil2 = 0;
            this.UProfil3 = 0;
            this.UProfil4 = 0;
            this.Hinges = "";
            this.LockAndHandle = "";
            this.DoorPanel1 = 0;
            this.DoorPanel2 = 0;
            this.DoorPanel3 = 0;
            this.LeafProfileType = "";
            this.RailType = "";
            this.PostProfileType = "";
            this.EngineType = "";
            this.DoorPanelType = "";
            this.HorizontalProfile1 = 0;
            this.HorizontalProfile2 = 0;
            this.HorizontalProfile3 = 0;
            this.VerticalProfile1 = 0;
            this.VerticalProfile2 = 0;
            this.VerticalProfile3 = 0;
            this.PanelCap = "";
            this.Razor = "";
            this.RockWool = "";
            this.LeafProfile1 = 0;
            this.LeafProfile2 = 0;
            this.LeafProfile3 = 0;

        }
    }
}
