using GladiusObjex.BaseClass;
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
    public class Agents:gsBase
    {
        private string _AgentType;
        [Display(Name = "Temsilci Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string AgentType { get => _AgentType; set { _AgentType = value; SetUpdated("AgentType", value); } }

        private string _CardCode;
        [Display(Name = "Kodu")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private string _CardName;
        [Display(Name = "Temsilci Tipi")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _BranchRef;
        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private string _Phone;
        [Display(Name = "Telefon")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Phone { get => _Phone; set { _Phone = value; SetUpdated("Phone", value); } }

        private string _Email;
        [Display(Name = "Telefon")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Email { get => _Email; set { _Email = value; SetUpdated("Email", value); } }
        

        private string _Description;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _SpeCode1;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        private string _SpeCode2;
        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string SpeCode2 { get => _SpeCode2; set { _SpeCode2 = value; SetUpdated("SpeCode2", value); } }

        private decimal _Discount;
        public decimal Discount { get => _Discount; set { _Discount = value; SetUpdated("Discount", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }


        private string _Department;
        [Display(Name = "Departman")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Department { get => _Department; set { _Department = value; SetUpdated("Department", value); } }


        public Agents getAgent(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Agents myAgent = new Agents();

            myAgent = mng.GetObject<Agents>(Ref);

            return myAgent;
        }

        public Agents()
        {

            TableName = "Agents";

            Columns.Add(new ObjColumn("AgentType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Phone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Email", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode1", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Discount", SqlDbType.Decimal, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Department", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.AgentType = "";
            this.CardName = "";
            this.BranchRef = Guid.Empty;
            this.UserRef = Guid.Empty;
            this.Phone = "";
            this.Email = "";
            this.Description = "";
            this.SpeCode1 = "";
            this.SpeCode2 = "";
            this.Discount = 0;
            this.CardCode = "";
            this.IsPassive = true;
            this.Image = new byte[] { };
            this.Department = "YICI";
        }
    }
}
