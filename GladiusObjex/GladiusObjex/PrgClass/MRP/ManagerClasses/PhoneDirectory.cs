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

namespace GladiusObjex.PrgClass.MRP.SettingClasses
{
    public class PhoneDirectory:gsBase
    {
        private string _CardName;
        [Display(Name = "Kart Adı")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _ClientRef;
        public Guid ClientRef { get => _ClientRef; set { _ClientRef = value; SetUpdated("ClientRef", value); } }

        private string _Phone1;
        [Display(Name = "Telefon 1")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string Phone1 { get => _Phone1; set { _Phone1 = value; SetUpdated("Phone1", value); } }

        private string _CellPhone;
        [Display(Name = "Cep Telefonu")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string CellPhone { get => _CellPhone; set { _CellPhone = value; SetUpdated("CellPhone", value); } }

        private string _Fax;
        [Display(Name = "Fax")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string Fax { get => _Fax; set { _Fax = value; SetUpdated("Fax", value); } }

        private string _Email;
        [Display(Name = "E-Mail")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string Email { get => _Email; set { _Email = value; SetUpdated("Email", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        public PhoneDirectory()
        {
            TableName = "PhoneDirectory";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClientRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Phone1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CellPhone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Fax", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Email", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.CardName = "";
            this.ClientRef = Guid.Empty;
            this.Phone1 = "";
            this.CellPhone = "";
            this.Fax = "";
            this.Email = "";
            this.Description = "";
        }
    }
}
