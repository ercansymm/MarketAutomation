using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.IO;

namespace GladiusObjex.SystemClass
{
    public class Users : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private bool _IsAdmin;
        public bool IsAdmin { get => _IsAdmin; set { _IsAdmin = value; SetUpdated("IsAdmin", value); } }

        private string _CardCode;

        [Display(Name = "Kart Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private string _CardName;

        [Display(Name = "Kart Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _FullName;

        [Display(Name = "Tam Adı")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string FullName { get => _FullName; set { _FullName = value; SetUpdated("FullName", value); } }


        private string _CardDesc;

        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardDesc { get => _CardDesc; set { _CardDesc = value; SetUpdated("CardDesc", value); } }

        private string _EPosta;

        [Display(Name = "E-Posta")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string EPosta { get => _EPosta; set { _EPosta = value; SetUpdated("EPosta", value); } }


        private string _SpeCode;

        [Display(Name = "Özel Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode { get => _SpeCode; set { _SpeCode = value; SetUpdated("SpeCode", value); } }

        private string _UserName;

        [Display(Name = "Kullanıcı Adı")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string UserName { get => _UserName; set { _UserName = value; SetUpdated("UserName", value); } }

        private string _UserPass;

        [Display(Name = "Kullanıcı Şifre")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string UserPass { get => _UserPass; set { _UserPass = value; SetUpdated("UserPass", value); } }

        private string _ErpUser;

        [Display(Name = "Erp Kullanıcı Adı")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string ErpUser { get => _ErpUser; set { _ErpUser = value; SetUpdated("ErpUser", value); } }

        private string _ErpPass;

        [Display(Name = "Erp Kullanıcı Şifre")]
        [DataType("nvarchar")]
        [StringLength(1000)]
        public string ErpPass { get => _ErpPass; set { _ErpPass = value; SetUpdated("ErpPass", value); } }

        private byte[] _Images;

        [Display(Name = "Resim")]
        public byte[] Images { get => _Images; set { _Images = value; SetUpdated("Images", value); } }

        [NotMapped]
        public Image _myImage { get; set; }

        public virtual BindingList<UsersAuth> AuthList { get; set; }

        public Users GetUsers(Guid _REF)
        {
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            Users myUser = new Users();

            myUser = mng.GetObject<Users>(_REF);
            myUser.AuthList = mng.GetObjectList<UsersAuth>(String.Format(" UserRef = '{0}'", _REF), "");

            if (myUser.Images != null && myUser.Images.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(myUser.Images))
                    {
                        myUser._myImage = Image.FromStream(ms);
                    }
                }
                catch (Exception)
                { }
            }
            else
            {
                myUser._myImage = null;
                myUser.Images = new byte[] { };
            }

            return myUser;
        }

        public Users()
        {
            TableName = "Users";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, false, false, false));
            Columns.Add(new ObjColumn("IsAdmin", SqlDbType.Bit, false, false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("FullName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardDesc", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("EPosta", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SpeCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserPass", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ErpUser", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ErpPass", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Images", SqlDbType.Image, null, false, false));

            this.CardCode = ""; this.CardDesc = ""; this.CardName = "";
            this.EPosta = ""; this.ErpPass = ""; this.ErpUser = "";
            this.FullName = ""; this.Images = new byte[] { }; this.IsAdmin = false;
            this.IsPassive = true; this.SpeCode = ""; this.UserName = "";
            this.UserPass = "";

            AuthList = new BindingList<UsersAuth>();
        }
    }
}
