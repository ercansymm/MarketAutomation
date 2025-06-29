using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.Tracing;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockCard:gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private bool _IsOpenSale;
        public bool IsOpenSale { get => _IsOpenSale; set { _IsOpenSale = value; SetUpdated("IsOpenSale", value); } }

        private bool _IsOpenBuy;
        public bool IsOpenBuy { get => _IsOpenBuy; set { _IsOpenBuy = value; SetUpdated("IsOpenBuy", value); } }

        private bool _IsMControl;
        public bool IsMControl { get => _IsMControl; set { _IsMControl = value; SetUpdated("IsMControl", value); } }

        private string _StockCode;
        [Display(Name = "Stok Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string StockCode { get => _StockCode; set { _StockCode = value; SetUpdated("StockCode", value); } }

        private string _CardName;
        [Display(Name = "İsmi")]
        [DataType("nvarchar")]
        [StringLength(300)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _CardDesc;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardDesc { get => _CardDesc; set { _CardDesc = value; SetUpdated("CardDesc", value); } }

        private string _ComponentCode;
        [Display(Name = "Parça Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string ComponentCode { get => _ComponentCode; set { _ComponentCode = value; SetUpdated("ComponentCode", value); } }

        private Guid _BrandRef;
        public Guid BrandRef { get => _BrandRef; set { _BrandRef = value; SetUpdated("BrandRef", value); } }

        private Guid _ModelRef;
        public Guid ModelRef { get => _ModelRef; set { _ModelRef = value; SetUpdated("ModelRef", value); } }

        private string _GroupRef;
        [Display(Name = "Grup")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string GroupRef { get => _GroupRef; set { _GroupRef = value; SetUpdated("GroupRef", value); } }

        private Guid _ClassRef;
        public Guid ClassRef { get => _ClassRef; set { _ClassRef = value; SetUpdated("ClassRef", value); } }

        private Guid _SubClassRef;
        public Guid SubClassRef { get => _SubClassRef; set { _SubClassRef = value; SetUpdated("SubClassRef", value); } }

        private Guid _StockTypeRef;
        public Guid StockTypeRef { get => _StockTypeRef; set { _StockTypeRef = value; SetUpdated("StockTypeRef", value); } }

        private double _PurchaseVat;
        public double PurchaseVat { get => _PurchaseVat; set { _PurchaseVat = value; SetUpdated("PurchaseVat", value); } }

        private double _SalesVat;
        public double SalesVat { get => _SalesVat; set { _SalesVat = value; SetUpdated("SalesVat", value); } }

        private double _Tevkifat1;
        public double Tevkifat1 { get => _Tevkifat1; set { _Tevkifat1 = value; SetUpdated("Tevkifat1", value); } }

        private double _Tevkifat2;
        public double Tevkifat2 { get => _Tevkifat2; set { _Tevkifat2 = value; SetUpdated("Tevkifat2", value); } }

        private string _SpeCode1;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        private string _SpeCode2;
        [Display(Name = "Özel Kod2")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpeCode2 { get => _SpeCode2; set { _SpeCode2 = value; SetUpdated("SpeCode2", value); } }

        private string _SpeCode3;
        [Display(Name = "Özel Kod3")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpeCode3 { get => _SpeCode3; set { _SpeCode3 = value; SetUpdated("SpeCode3", value); } }

        private string _SpeCode4;
        [Display(Name = "Özel Kod4")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpeCode4 { get => _SpeCode4; set { _SpeCode4 = value; SetUpdated("SpeCode4", value); } }

        private string _SpeCode5;
        [Display(Name = "Özel Kod5")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SpeCode5 { get => _SpeCode5; set { _SpeCode5 = value; SetUpdated("SpeCode5", value); } }


        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        private int _LogicalRef;
        public int LogicalRef { get => _LogicalRef; set { _LogicalRef = value; SetUpdated("LogicalRef", value); } }

        private string _SystemStockCode;
        [Display(Name = "LOGO kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string SystemStockCode { get => _SystemStockCode; set { _SystemStockCode = value; SetUpdated("SystemStockCode", value); } }

        private string _SalesAccCode;
        [Display(Name = "Y.Dışı Firma Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SalesAccCode { get => _SalesAccCode; set { _SalesAccCode = value; SetUpdated("SalesAccCode", value); } }

        public virtual BindingList<StockUnitDetail> CardUnit { get; set; }
        public virtual BindingList<StockDocuments> StockDocuments { get; set; }
        public virtual StockAccounting StockAcc{ get; set; }

        public StockCard getStock(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockCard myStock = new StockCard();

            myStock = mng.GetObject<StockCard>(Ref);

            myStock.StockAcc = mng.GetObject<StockAccounting>("StockRef = '" + Ref + "'");
            myStock.CardUnit = mng.GetObjectList<StockUnitDetail>(" StockRef='" + Ref + "'", "");
            myStock.StockDocuments = mng.GetObjectList<StockDocuments>(" StockRef='" + Ref + "'", "");

            for (int i = 0; i < myStock.CardUnit.Count; i++)
            {
                myStock.CardUnit[i].StockUnitBarcode = mng.GetObjectList<StockUnitBarcode>(" StockUnitDetailRef='" + myStock.CardUnit[i].Ref + "'", "");
                //myStock.CardUnit[i].StockSerialLot = mng.GetObjectList<StockSerialLot>(" StockUnitRef='" + myStock.CardUnit[i].Ref + "'", "");
            }

            return myStock;
        }


        public StockCard()
        {
            TableName = "StockCard";
            
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("IsOpenSale", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("IsOpenBuy", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("IsMControl", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("StockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ComponentCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BrandRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("ModelRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("GroupRef", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClassRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SubClassRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockTypeRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("PurchaseVat", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("SalesVat", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Tevkifat1", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Tevkifat2", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode3", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode4", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode5", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardDesc", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LogicalRef", SqlDbType.Int, "", false, false));

            Columns.Add(new ObjColumn("SystemStockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SalesAccCode", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.Image = new byte[] { };
            this.CardDesc = "";
            this.IsPassive = true;
            this.IsMControl = true;
            this.IsOpenBuy = true;
            this.IsOpenSale = true;
            this.StockCode = "";
            this.CardName = "";
            this.ComponentCode = "";
            this.BrandRef = Guid.Empty;
            this.ModelRef = Guid.Empty;
            this.GroupRef = "";
            this.ClassRef = Guid.Empty;
            this.SubClassRef = Guid.Empty;
            this.StockTypeRef = Guid.Empty;
            this.PurchaseVat = 0;
            this.SalesVat = 0;
            this.Tevkifat1 = 0;
            this.Tevkifat2 = 0;
            this.SpeCode1 = "";
            this.SpeCode2 = "";
            this.SpeCode3 = "";
            this.SpeCode4 = "";
            this.SpeCode5 = "";
            this.LogicalRef = 0;
            this.SystemStockCode = "";
            this.SalesAccCode = "";

            CardUnit = new BindingList<StockUnitDetail>();
            StockDocuments = new BindingList<StockDocuments>();
            StockAcc = new StockAccounting();

        }
    }
}
