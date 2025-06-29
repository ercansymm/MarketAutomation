using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Data;

namespace GladiusObjex.SystemClass
{
    public class Databases : gsBaseCard
    {
        public Guid _ConnectionRef;

        public Guid ConnectionRef { get => _ConnectionRef; set { _ConnectionRef = value; SetUpdated("ConnectionRef", value); } }

        public static Databases GetDatabase(Guid Ref)
        {
            Databases myDb = new Databases();
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            myDb = mng.GetObject<Databases>(Ref);

            return myDb;
        }

        public Databases()
        {
            TableName = "Databases";

            Columns.Add(new ObjColumn("ConnectionRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));

            ConnectionRef = Guid.Empty;
        }
    }
}
