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
using GladiusObjex.BaseClass;

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class ClientCard:gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private bool _IsPerson;
        public bool IsPerson { get => _IsPerson; set { _IsPerson = value; SetUpdated("IsPerson", value); } }

        private string _InvoiceType;
        [Display(Name = "Fatura Türü")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string InvoiceType { get => _InvoiceType; set { _InvoiceType = value; SetUpdated("InvoiceType", value); } }
        /*   EINVOICE       E-FATURA            
             EARCHIVE       E-ARSIV
             PRINTED        MATBU KAĞIT
        */
        //private string _TaxType;
        //[Display(Name = "Vergi Türü")]
        //[DataType("nvarchar")]
        //[StringLength(10)]
        //public string TaxType { get => _TaxType; set { _TaxType = value; SetUpdated("TaxType", value); } }
        /*  COMPANY         KURUM - FIRMA
            PERSCOMP        ŞAHIS FİRMASI
            RETAIL          PERAKENDE
            TAXFREE         YABANCI MÜŞTERİ
        */

        private bool _IsTaxNrCheck;
        public bool IsTaxNrCheck { get => _IsTaxNrCheck; set { _IsTaxNrCheck = value; SetUpdated("IsTaxNrCheck", value); } }
        /*AYNI VERGI NUMARASINDA BAŞKA CARİ AÇILSIN MI*/

        private string _ClientType;
        [DataType("nvarchar")]
        [StringLength(100)]
        public string ClientType { get => _ClientType; set { _ClientType = value; SetUpdated("ClientType", value); } }
        /*    BUYSEL    Buyer-Seller        Alıcı Satıcı (Müşteri)
         *    SELLER    Seller Client       Satıcı Cari (Tedarikçi)
         *    BUYERC    Buyer Client        Alıcı Cari
         *    EMPLOY    Employee            Çalışan Cari
         *    EXPENS    Expense Client      Masraf-Gider Carisi
         *    
         */

        private string _ClientCode;
        [Display(Name = "Cari Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string ClientCode { get => _ClientCode; set { _ClientCode = value; SetUpdated("ClientCode", value); } }

        private string _CardName;
        [Display(Name = "Cari Adı")]
        [DataType("nvarchar")]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _TaxOffice;
        [Display(Name = "Vergi Dairesi")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string TaxOffice { get => _TaxOffice; set { _TaxOffice = value; SetUpdated("TaxOffice", value); } }

        private string _TaxNumber;
        [Display(Name = "Vergi Numarası")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string TaxNumber { get => _TaxNumber; set { _TaxNumber = value; SetUpdated("TaxNumber", value); } }

        private string _Curr;
        [Display(Name = "Kur")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        //private string _PayType;
        //[Display(Name = "Ödeme Türü")]
        //[DataType("nvarchar")]
        //[StringLength(10)]
        //public string PayType { get => _PayType; set { _PayType = value; SetUpdated("PayType", value); } }
        /*  CASH    Nakit
         *  CARD    Kredi Kartı
         *  BANK    Banka Havale-Eft
         */


        private string _EInvInbox;
        [Display(Name = "E-Fatura Gelen")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string EInvInbox { get => _EInvInbox; set { _EInvInbox = value; SetUpdated("EInvInbox", value); } }

        private string _EInvOutbox;
        [Display(Name = "E-Fatura Giden")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string EInvOutbox { get => _EInvOutbox; set { _EInvOutbox = value; SetUpdated("EInvOutbox", value); } }

        private string _Sector;
        [Display(Name = "Sektör")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Sector { get => _Sector; set { _Sector = value; SetUpdated("Sector", value); } }



        private Guid _GroupRef;
        public Guid GroupRef { get => _GroupRef; set { _GroupRef = value; SetUpdated("GroupRef", value); } }
        /*Grup şirketleri tek bir hesap altında toplamak için kullanılır*/

        // private Guid _GroupClientRef;
        //public Guid GroupClientRef { get => _GroupClientRef; set { _GroupClientRef = value; SetUpdated("GroupClientRef", value); } }
        /*Bayilik sisteminde hesabın bağlı olduğu cari hesap*/

        private string _Seller;
        [Display(Name = "Satıcı")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Seller { get => _Seller; set { _Seller = value; SetUpdated("Seller", value); } }

        private string _SalesArea;
        [Display(Name = "Bölge")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string SalesArea { get => _SalesArea; set { _SalesArea = value; SetUpdated("SalesArea", value); } }

        private string _SpecialCode1;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode1 { get => _SpecialCode1; set { _SpecialCode1 = value; SetUpdated("SpecialCode1", value); } }

        private string _SpecialCode2;
        [Display(Name = "Özel Kod2")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode2 { get => _SpecialCode2; set { _SpecialCode2 = value; SetUpdated("SpecialCode2", value); } }

        private string _SpecialCode3;
        [Display(Name = "Özel Kod3")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode3 { get => _SpecialCode3; set { _SpecialCode3 = value; SetUpdated("SpecialCode3", value); } }

        private string _SpecialCode4;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode4 { get => _SpecialCode4; set { _SpecialCode4 = value; SetUpdated("SpecialCode4", value); } }

        private string _SpecialCode5;
        [Display(Name = "Özel Kod1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpecialCode5 { get => _SpecialCode5; set { _SpecialCode5 = value; SetUpdated("SpecialCode5", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(5000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _OfficialTitle;  //Carinin Resmi Ünvanı İsmi ile Resmi ünvanı farklı olabilir.
        [Display(Name = "Resmi Ünvan")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string OfficialTitle { get => _OfficialTitle; set { _OfficialTitle = value; SetUpdated("OfficialTitle", value); } }

        private int _EInvoiceType;
        public int EInvoiceType { get => _EInvoiceType; set { _EInvoiceType = value; SetUpdated("EInvoiceType", value); } }
        //0. Kağıt Fatura   1.E-Fatura   2. E-Arşiv

        private string _MainClient;
        [Display(Name = "Ana Cari")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string MainClient { get => _MainClient; set { _MainClient = value; SetUpdated("MainClient", value); } }

        private string _FinanceCode;
        [Display(Name = "Finans Programı Kodu")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string FinanceCode { get => _FinanceCode; set { _FinanceCode = value; SetUpdated("FinanceCode", value); } }

        private string _Options;
        [Display(Name = "Seçenekler")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Options { get => _Options; set { _Options = value; SetUpdated("Options", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        private int _LogicalRef;
        public int LogicalRef { get => _LogicalRef; set { _LogicalRef = value; SetUpdated("LogicalRef", value); } }


        public virtual BindingList<ClientAddress> ClientAddress { get; set; }

        public ClientCard getClient(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            ClientCard myClient = new ClientCard();

            myClient = mng.GetObject<ClientCard>(Ref);
            myClient.ClientAddress = mng.GetObjectList<ClientAddress>(" ClientRef='" + Ref + "'", "");

            return myClient;

        }

        public ClientCard()
        {
            TableName = "ClientCard";

            Columns.Add(new ObjColumn("MainClient", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("IsPerson", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("InvoiceType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsTaxNrCheck", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("ClientType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TaxOffice", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TaxNumber", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EInvInbox", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EInvOutbox", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Sector", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("GroupRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Seller", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SalesArea", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode3", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode4", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpecialCode5", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("OfficialTitle", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EInvoiceType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("FinanceCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("Options", SqlDbType.NVarChar, "", false, false));

            Columns.Add(new ObjColumn("LogicalRef", SqlDbType.Int, "", false, false));


            this.EInvoiceType = 0;
            this.OfficialTitle = "";
            this.Seller = "";
            this.GroupRef = Guid.Empty;
            this.Description = "";
            this.IsPassive = true;
            this.ClientCode = "";
            this.ClientType = "";
            this.CardName = "";
            this.Curr = "TRY";
            this.InvoiceType = "";
            this.EInvOutbox = "";
            this.SpecialCode1 = "";
            this.SpecialCode2 = "";
            this.SpecialCode3 = "";
            this.SpecialCode4 = "";
            this.SpecialCode5 = "";
            this.EInvInbox = "";
            this.Ref = Guid.NewGuid();
            this.IsPerson = false;
            this.Sector = "";
            this.TaxOffice = "";
            this.TaxNumber = "";
            this.IsTaxNrCheck = true;
            this.OfficialTitle = "";
            this.FinanceCode = "";
            this.Image = new byte[] { };
            this.Options = "YICI";
            this.LogicalRef = 0;

            ClientAddress = new BindingList<ClientAddress>();

        }
    }
}
