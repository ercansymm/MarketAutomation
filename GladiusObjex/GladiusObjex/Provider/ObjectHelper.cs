using GladiusObjex.GKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Provider
{
    internal class ObjectHelper
    {
        internal static string GetWhereClause(ICustomObject customObject)
        {
            string return_value = "";
            foreach (ObjColumn column in customObject.Columns)
            {
                if (column.IsUpdated)
                {
                    return_value += " And " + column.ColumnName + " = @" + column.ColumnName;
                }
            }
            return_value = return_value.Substring(5);
            return return_value;
        }

        internal static ObjColumn GetIdentityColumn(ICustomObject customObject)
        {
            ObjColumn column = new ObjColumn();
            foreach (ObjColumn objColumn in customObject.Columns)
            {
                //if (objColumn.IsIdentity)
                if (objColumn.ColumnName == "Ref")
                {
                    column = objColumn;


                    break;
                }
            }
            return column;
        }

        internal static void AddParameter(DbManager db, ObjColumn column)
        {
            string ColumnName = column.ColumnName + "_ax";
            switch (column.ColumnType)
            {
                case SqlDbType.Int:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Int, column.ColumnValue);
                    break;
                case SqlDbType.Decimal:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Decimal, column.ColumnValue);
                    break;
                case SqlDbType.NText:
                    db.AddInParameters("@" + ColumnName, SqlDbType.NText, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.BigInt:
                    db.AddInParameters("@" + ColumnName, SqlDbType.BigInt, column.ColumnValue);
                    break;
                case SqlDbType.SmallInt:
                    db.AddInParameters("@" + ColumnName, SqlDbType.SmallInt, column.ColumnValue);
                    break;
                case SqlDbType.TinyInt:
                    db.AddInParameters("@" + ColumnName, SqlDbType.TinyInt, column.ColumnValue);
                    break;
                case SqlDbType.Real:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Real, column.ColumnValue);
                    break;
                case SqlDbType.VarChar:
                    db.AddInParameters("@" + ColumnName, SqlDbType.VarChar, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.Text:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Text, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.Binary:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Binary, column.ColumnValue);
                    break;
                case SqlDbType.NVarChar:
                    db.AddInParameters("@" + ColumnName, SqlDbType.NVarChar, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.Float:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Float, column.ColumnValue);
                    break;
                case SqlDbType.Bit:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Bit, column.ColumnValue);
                    break;
                case SqlDbType.DateTime:
                    db.AddInParameters("@" + ColumnName, SqlDbType.DateTime, column.ColumnValue);
                    break;
                case SqlDbType.Date:
                    db.AddInParameters("@" + ColumnName, SqlDbType.DateTime, column.ColumnValue);
                    break;
                case SqlDbType.Time:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Time, column.ColumnValue);
                    break;
                case SqlDbType.Char:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Char, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.UniqueIdentifier:
                    db.AddInParameters("@" + ColumnName, SqlDbType.UniqueIdentifier, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
                case SqlDbType.Image:
                    db.AddInParameters("@" + ColumnName, SqlDbType.Image, column.ColumnValue == null ? "" : column.ColumnValue);
                    break;
            }
        }

        internal static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (ICustomObject item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
