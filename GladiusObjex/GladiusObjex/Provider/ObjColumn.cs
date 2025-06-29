using System.Data;

namespace GladiusObjex.Provider
{
    public class ObjColumn
    {
        public string ColumnName { get; set; }
        public SqlDbType ColumnType { get; set; }
        public object ColumnValue { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsUpdated { get; set; }

        public ObjColumn()
        {

        }

        public ObjColumn(string columnName, SqlDbType columnType, object columnValue, bool isIdentity, bool isUpdated)
        {
            ColumnName = columnName;
            ColumnType = columnType;
            ColumnValue = columnValue;
            IsIdentity = isIdentity;
            IsUpdated = isUpdated;
        }
    }
}
