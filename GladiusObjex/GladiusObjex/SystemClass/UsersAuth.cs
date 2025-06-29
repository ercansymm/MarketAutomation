using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace GladiusObjex.SystemClass
{
    public class UsersAuth : gsBase
    {
        public Guid _UserRef;

        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        public Guid _FirmRef;

        public Guid FirmRef { get => _FirmRef; set { _FirmRef = value; SetUpdated("FirmRef", value); } }

        private byte[] _Auths;

        [Display(Name = "Yetki")]
        public byte[] Auths { get => _Auths; set { _Auths = value; SetUpdated("Auths", value); } }

        [ForeignKey("UserRef")]
        public virtual Users myUsers { get; set; }

        public UsersAuth GetUserAuth(Guid _REF)
        {
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            UsersAuth myAuth = new UsersAuth();

            myAuth = mng.GetObject<UsersAuth>(_REF);           

            return myAuth;
        }

        public UsersAuth()
        {
            TableName = "UsersAuth";

            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("FirmRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("Auths", SqlDbType.Image, null, false, false));

            this.FirmRef = Guid.Empty; this.UserRef = Guid.Empty; this.Auths = new byte[0]; 
        }

    }
}
