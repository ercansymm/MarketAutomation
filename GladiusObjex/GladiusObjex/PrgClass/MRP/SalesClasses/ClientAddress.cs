using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.Tracing;
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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class ClientAddress:gsBase
    {
        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private string _CardType;
        [Display(Name = "Kart Tipi")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardType { get => _CardType; set { _CardType = value; SetUpdated("CardType", value); } }

        /*  TAXOFF     TAX         Vergi Fatura Adresi
         *  DELIVERY     DELIVERY    Teslim Adresi
         */

        private string _Address;
        [Display(Name = "Adres")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Address { get => _Address; set { _Address = value; SetUpdated("Address", value); } }

        private string _PostCode;
        [Display(Name = "Posta Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string PostCode { get => _PostCode; set { _PostCode = value; SetUpdated("PostCode", value); } }

        private int _CityRef;
        public int CityRef { get => _CityRef; set { _CityRef = value; SetUpdated("CityRef", value); } }

        private int _DistrictRef;
        public int DistrictRef { get => _DistrictRef; set { _DistrictRef = value; SetUpdated("DistrictRef", value); } }

        private string _Coordinate;
        [Display(Name = "Koordinat")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Coordinate { get => _Coordinate; set { _Coordinate = value; SetUpdated("Coordinate", value); } }

        private string _Phone1;
        [Display(Name = "Telefon 1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Phone1 { get => _Phone1; set { _Phone1 = value; SetUpdated("Phone1", value); } }

        private string _Phone2;
        [Display(Name = "Telefon 2")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Phone2 { get => _Phone2; set { _Phone2 = value; SetUpdated("Phone2", value); } }

        private string _Phone3;
        [Display(Name = "Telefon 3")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Phone3 { get => _Phone3; set { _Phone3 = value; SetUpdated("Phone3", value); } }

        private string _Fax;
        [Display(Name = "Fax")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Fax { get => _Fax; set { _Fax = value; SetUpdated("Fax", value); } }

        private string _Email;
        [Display(Name = "Mail")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Email { get => _Email; set { _Email = value; SetUpdated("Email", value); } }

        private string _Web;
        [Display(Name = "Web")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Web { get => _Web; set { _Web = value; SetUpdated("Web", value); } }

        private string _AdresCode;
        [Display(Name = "Adres Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string AdresCode { get => _AdresCode; set { _AdresCode = value; SetUpdated("AdresCode", value); } }

        private string _CardDesc;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string CardDesc { get => _CardDesc; set { _CardDesc = value; SetUpdated("CardDesc", value); } }

        [ForeignKey("ClientRef")]
        public virtual ClientCard Client { get; set; }

        public ClientAddress getAddress(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            ClientAddress myClientAddress = new ClientAddress();

            myClientAddress = mng.GetObject<ClientAddress>(Ref);

            return myClientAddress;
        }

        public ClientAddress()
        {

            TableName = "ClientAddress";

            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Address", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PostCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CityRef", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("DistrictRef", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Coordinate", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Phone1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Phone2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Phone3", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Fax", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Email", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Web", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("AdresCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardDesc", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.ClientRef = Guid.Empty;
            this.CardType = "";
            this.Address = "";
            this.PostCode = "";
            this.CityRef = 0;
            this.DistrictRef = 0;
            this.Coordinate = "";
            this.Phone1 = "";
            this.Phone2 = "";
            this.Phone3 = "";
            this.Email = "";
            this.Web = "";
            this.AdresCode = "TR";
            this.CardDesc = "";
        }
    }
}
