using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Tool
{
    public class GladiusOffice : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public static DataSet ExcelReadXls(string filelocation, string PageName)
        {
            string connstr = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + filelocation + @";Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(connstr);
            string strSQL = "SELECT * FROM [" + PageName + "$]";

            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            DataSet ds = new DataSet();

            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception)
            { }


            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return ds;

        }

        public static DataTable ExcelReadXlsx(string filename, string PageName, string selectQ, string WhereQ)
        {
            DataTable dt = new System.Data.DataTable();
            try
            {
                try
                {
                    if (selectQ.Length == 0)
                        selectQ = "*";


                    String sdbconnection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + filename + "; Extended Properties='Excel 12.0; TypeGuessRows=0; HDR=YES; IMEX=1'";
                    OleDbConnection dbconnection = new OleDbConnection(sdbconnection);
                    dbconnection.Open();
                    OleDbDataAdapter dbadapter = new OleDbDataAdapter(string.Format(@"Select " + selectQ + @" from [{0}$] " + WhereQ, PageName), dbconnection);

                    dbadapter.Fill(dt);
                }
                catch (Exception ex)
                { throw ex; }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable ExcelData(string filePath, string Page)
        {
            DataTable dtexcel = new DataTable();
            try
            {


                bool hasHeaders = false;
                string HDR = hasHeaders ? "Yes" : "No";
                string strConn;
                if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
                else
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Looping Total Sheet of Xl File
                /*foreach (DataRow schemaRow in schemaTable.Rows)
                {
                }*/
                //Looping a first Sheet of Xl File
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + Page + "$]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }

                conn.Close();
            }
            catch (Exception)
            { }
            return dtexcel;

        }
    }
}
