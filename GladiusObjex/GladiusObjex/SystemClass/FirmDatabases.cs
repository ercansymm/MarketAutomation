using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Data;

namespace GladiusObjex.SystemClass
{
    public class FirmDatabases : gsBase
    {
        public Guid FirmRef { get; set; }

        public Guid DatabaseRef { get; set; }

        public FirmDatabases()
        {
            TableName = "FirmDatabases";

            Columns.Add(new ObjColumn("FirmRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("DatabaseRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));

            this.FirmRef = Guid.Empty;
            this.DatabaseRef = Guid.Empty;
        }
    }
}
