using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.GKernel
{
    public class SQLHelper
    {
        public SQLHelper()
        {
        }


        public static string GetDataColumnValue_String(object Deger)
        {
            string return_value = "";
            try
            {
                return_value = Deger.ToString();
            }
            catch
            {
                return_value = "";
            }
            return return_value;
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
            try
            {
                if (Deger.ToString() == "")
                    return 0;
                else
                    return Convert.ToInt32(Deger);
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public static Boolean GetDataColumnValue_Bool(DataTable TableName, int RowNum, string ColumnName)
        {
            try
            {
                return Convert.ToBoolean(TableName.Rows[RowNum][ColumnName]);
            }
            catch (Exception)
            {

                return false;
            }

        }


        public static Boolean GetDataColumnValue_Bool(object Deger)
        {
            if (Deger.ToString() == "")
                return false;
            else
            {
                try
                {
                    if (Deger.ToString() == "1")
                        return true;
                    else
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
            try
            {
                if (theDate == DateTime.MinValue)
                    return DBNull.Value;
                else
                    return theDate;
            }
            catch (Exception)
            {
                return DBNull.Value;
            }

        }


        public static decimal GetDataColumnValue_Decimal(object Deger)
        {
            try
            {
                if (Deger.ToString() == "")
                    return 0;
                else
                    return Convert.ToDecimal(Deger);
            }
            catch (Exception)
            {
                return 0;
            }

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
