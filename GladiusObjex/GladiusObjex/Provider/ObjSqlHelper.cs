using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Provider
{
    public class ObjSqlHelper
    {
        public ObjSqlHelper()
        {
        }

        public static string GetDataColumnValue_String(DataTable TableName, int RowNum, string ColumnName)
        {
            string return_value = "";
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = TableName.Rows[RowNum][ColumnName].ToString();
            }
            return return_value;
        }

        public static int GetDataColumnValue_Int(DataTable TableName, int RowNum, string ColumnName)
        {
            if (TableName.Rows[RowNum][ColumnName].ToString() == "")
                return 0;
            else
                return Convert.ToInt32(TableName.Rows[RowNum][ColumnName]);
        }

        public static int GetDataColumnValue_Int(object Deger)
        {
            if (Deger.ToString() == "")
                return 0;
            else
                return Convert.ToInt32(Deger);
        }

        public static int GetDataColumnValue_Int16(object Deger)
        {
            if (Deger.ToString() == "")
                return 0;
            else
                return Convert.ToInt16(Deger);
        }

        public static Boolean GetDataColumnValue_Bool(DataTable TableName, int RowNum, string ColumnName)
        {
            return Convert.ToBoolean(TableName.Rows[RowNum][ColumnName]);
        }


        public static Boolean GetDataColumnValue_Bool(object Deger)
        {
            if (Deger.ToString() == "")
                return false;
            else
            {
                try
                {
                    return Convert.ToBoolean(Deger);
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public static DateTime GetDataColumnValue_DateTime(DataTable TableName, int RowNum, string ColumnName)
        {
            DateTime return_value = DateTime.MinValue;
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = Convert.ToDateTime(TableName.Rows[RowNum][ColumnName]);
            }
            return return_value;
        }

        public static object GetDataColumnValue_DateTime(DateTime theDate)
        {
            if (theDate == DateTime.MinValue)
                return DBNull.Value;
            else
                return theDate;
        }

        public static object GetDataColumnValue_Time(TimeSpan theTime)
        {
            return theTime;
        }


        public static decimal GetDataColumnValue_Decimal(object Deger)
        {
            if (Deger.ToString() == "")
                return 0;
            else
                return Convert.ToDecimal(Deger);
        }


        public static double GetDataColumnValue_Double(object Deger)
        {
            double d = 0;
            if (Deger.ToString() == "")
                d = 0;
            else
            {
                try
                {
                    d = double.Parse(Deger.ToString(), CultureInfo.InvariantCulture);
                }
                catch
                {

                }

            }
            return d;
        }

        public static Guid GetDataColumnValue_Guid(object Deger)
        {
            if (Deger.ToString() == "")
                return Guid.Empty;
            else
                return Guid.Parse(Deger.ToString());
        }
        public static byte[] GetDataColumnValue_Image(object Deger)
        {
            if (Deger.ToString() == "")
                return new byte[] { };
            else
                return (byte[])Deger;
        }

        public static Single GetDataColumnValue_Single(object Deger)
        {
            if (Deger.ToString() == "")
                return 0;
            else
                return Convert.ToSingle(Deger);
        }


        public static decimal GetDataColumnValue_Decimal(DataTable TableName, int RowNum, string ColumnName)
        {

            decimal return_value = 0;
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = Convert.ToDecimal(TableName.Rows[RowNum][ColumnName]);
            }
            return return_value;
        }
    }
}
