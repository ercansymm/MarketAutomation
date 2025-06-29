using GladiusObjex.Base;
using GladiusObjex.GKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Provider
{
    public class ObjectManager
    {
        private bool useTransaction;
        private DbManager db;

        public int CommandTimeOut { get; set; }

        public string Version
        {
            get { return "2.4.2"; }
        }

        public ObjectManager(bool UseTransaction)
        {
            useTransaction = UseTransaction;
            if (useTransaction)
            {
                db = new DbManager(true);
                if (CommandTimeOut > 0) db.CommandTimeOut = CommandTimeOut;
            }
            else
            {
                db = new DbManager(false);
                if (CommandTimeOut > 0) db.CommandTimeOut = CommandTimeOut;
            }
        }

        public ObjectManager(bool UseTransaction, string ConnectionName)
        {
            useTransaction = UseTransaction;
            if (useTransaction)
            {
                db = new DbManager(true, ConnectionName);
                if (CommandTimeOut > 0) db.CommandTimeOut = CommandTimeOut;
            }
            else
            {
                db = new DbManager(false, ConnectionName);
                if (CommandTimeOut > 0) db.CommandTimeOut = CommandTimeOut;
            }
        }

        public ObjectManager(bool UseTransaction, string connectionString, bool IsUsingInnerConnectionString)
        {
            if (db == null)
                db = new DbManager(useTransaction, connectionString, IsUsingInnerConnectionString);

            useTransaction = UseTransaction;
            if (useTransaction)
                db = new DbManager(useTransaction, connectionString, IsUsingInnerConnectionString);
        }

        private List<ObjParam> Parameters = new List<ObjParam>();

        public bool SaveObject<T>(ICustomObject armixObject)
        {
            bool rTurn = false;

            if (CheckObject<T>(armixObject.Ref))
            {
                if (UpdateObject(armixObject) > 0) rTurn = true;
            }
            else
            {
                if (InsertObject(armixObject) > 0) rTurn = true;
            }

            return rTurn;
        }

        public int InsertObject(ICustomObject customObject)
        {
            int sonuc;
            try
            {
                string sql_string = "Insert Into " + customObject.TableName + " (";
                string sql_string_params = "";
                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && (!column.IsIdentity || column.ColumnName == "Ref"))
                    {
                        sql_string += column.ColumnName + ",";
                        sql_string_params += "@" + column.ColumnName + "_ax,";
                    }
                }
                sql_string = sql_string.Substring(0, sql_string.Length - 1) + ") Values (" +
                             sql_string_params.Substring(0, sql_string_params.Length - 1) + ")";

                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && (!column.IsIdentity || column.ColumnName == "Ref"))
                        ObjectHelper.AddParameter(db, column);
                }

                sonuc = db.ExecuteNonQuery(sql_string, CommandType.Text);
                
            }
            catch (Exception ex)

            {
                throw ex;
            }
            finally
            {
                ClearParameters();

            }

            return sonuc;
        }

        public int UpdateObject(ICustomObject customObject)
        {
            int sonuc;
            try
            {
                Guid identidyId = (Guid)ObjectHelper.GetIdentityColumn(customObject).ColumnValue;
                string sql_string = "Update " + customObject.TableName + " Set ";
                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && !column.IsIdentity)
                        sql_string += column.ColumnName + " = " + "@" + column.ColumnName + "_ax,";
                }
                sql_string = sql_string.Substring(0, sql_string.Length - 1);


                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && !column.IsIdentity)
                        ObjectHelper.AddParameter(db, column);
                }

                ObjColumn identityColumn = ObjectHelper.GetIdentityColumn(customObject);

                sql_string += " Where " + identityColumn.ColumnName + " = @" + identityColumn.ColumnName + "_ax";
                db.AddInParameters("@" + identityColumn.ColumnName + "_ax", identityColumn.ColumnType, identidyId);

                sonuc = db.ExecuteNonQuery(sql_string, CommandType.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }
            return sonuc;
        }

        public int UpdateObjects(ICustomObject customObject, string whereClause)
        {

            int sonuc;
            try
            {
                string sql_string = "Update " + customObject.TableName + " Set ";
                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && !column.IsIdentity)
                        sql_string += column.ColumnName + " = " + "@" + column.ColumnName + "_ax,";
                }
                sql_string = sql_string.Substring(0, sql_string.Length - 1);


                foreach (ObjColumn column in customObject.Columns)
                {
                    if (column.IsUpdated && !column.IsIdentity)
                        ObjectHelper.AddParameter(db, column);
                }

                if (whereClause != "")
                {
                    sql_string += " Where " + whereClause;

                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                sonuc = db.ExecuteNonQuery(sql_string, CommandType.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }
            return sonuc;
        }

        public int DeleteObject<T>(Guid id)
        {
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;
            int sonuc;
            try
            {
                string sql_string = "Delete From " + customObject.TableName;
                string sql_where = "";


                ObjColumn column = ObjectHelper.GetIdentityColumn(customObject);
                column.ColumnValue = id;
                sql_where += column.ColumnName + " = @" + column.ColumnName + "_ax And";
                sql_string = sql_string + " Where " + sql_where.Substring(0, sql_where.Length - 3);


                ObjectHelper.AddParameter(db, column);



                sonuc = db.ExecuteNonQuery(sql_string, CommandType.Text);
                if (!useTransaction)
                    db.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }

            return sonuc;

        }

        public void DeleteObjects<T>(string whereClause)
        {
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;
            int sonuc;
            try
            {
                string sql_string = "Delete From " + customObject.TableName;

                if (whereClause != "")
                {
                    sql_string += " Where " + whereClause;

                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                sonuc = db.ExecuteNonQuery(sql_string, CommandType.Text);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ClearParameters();
            }

        }

        public void SetProperty(ICustomObject customObject, PropertyInfo p, object deger)
        {
            switch (p.PropertyType.FullName)
            {
                case "System.Int16":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Int16(deger.ToString()), null);
                    break;
                case "System.Int32":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Int(deger.ToString()), null);
                    break;
                case "System.Int64":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Int(deger.ToString()), null);
                    break;
                case "System.Boolean":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Bool(deger.ToString()), null);
                    break;
                case "System.String":
                    p.SetValue(customObject, deger.ToString(), null);
                    break;
                case "System.DateTime":
                    if (deger.ToString() == "" || deger == null)
                        p.SetValue(customObject, DateTime.MinValue, null);
                    else
                        p.SetValue(customObject, DateTime.Parse(deger.ToString()), null);
                    break;
                case "System.Decimal":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Decimal(deger.ToString()), null);
                    break;
                case "System.Char":
                    p.SetValue(customObject, deger.ToString(), null);
                    break;
                case "System.Single":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Single(deger.ToString()), null);
                    break;
                case "System.Double":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Double(deger.ToString().Replace(",", ".")), null);
                    break;
                case "System.Guid":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Guid(deger.ToString()), null);
                    break;
                case "System.Byte[]":
                    p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Image(deger), null);
                    break;
                case "System.TimeSpan":
                    if (deger.ToString() == "" || deger == null)
                        p.SetValue(customObject, TimeSpan.Zero, null);
                    else
                        p.SetValue(customObject, ObjSqlHelper.GetDataColumnValue_Time(TimeSpan.Parse(deger.ToString())), null);
                    break;
                default:
                    p.SetValue(customObject, deger.ToString(), null);
                    break;
            }
        }

        public T GetObject<T>(Guid identityId)
        {
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;
            string sql_string = "Select Top 1 * From " + customObject.TableName;
            string whereClause = " Where ";
            DataTable dt = new DataTable();
            try
            {
                ObjColumn column = ObjectHelper.GetIdentityColumn(customObject);
                whereClause += column.ColumnName + " = @" + column.ColumnName + "_ax";

                column.ColumnValue = identityId;
                ObjectHelper.AddParameter(db, column);

                dt = db.ExecuteDataTable(sql_string + whereClause, CommandType.Text);

                if (dt.Rows.Count > 0)
                {
                    PropertyInfo[] properties = GetPublicProperties(customObject.GetType());

                    for (int i = 0; i < properties.Count(); i++)
                    {
                        PropertyInfo p = properties[i];
                        if (IsInColumns(customObject, p.Name))
                        {
                            var deger = dt.Rows[0][((System.Reflection.MemberInfo)(p)).Name];
                            SetProperty(customObject, p, deger);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }

            return (T)customObject;

        }

        public bool CheckObject<T>(Guid identityId)
        {
            bool rTurn = false;

            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;
            string sql_string = "Select Top 1 Ref From " + customObject.TableName;
            string whereClause = " Where ";
            DataTable dt = new DataTable();
            try
            {
                ObjColumn column = ObjectHelper.GetIdentityColumn(customObject);
                whereClause += column.ColumnName + " = @" + column.ColumnName + "_ax";

                column.ColumnValue = identityId;
                ObjectHelper.AddParameter(db, column);

                object Ref = db.ExecuteScalar(sql_string + whereClause, CommandType.Text);

                if (Ref != null)
                    rTurn = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }

            return rTurn;

        }

        public T GetObject<T>(string whereString)
        {
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;
            string sql_string = "Select Top 1 * From " + customObject.TableName;
            string whereClause = "";
            if (whereString != "")
                whereClause = " Where " + whereString;

            DataTable dt = new DataTable();
            try
            {
                if (Parameters.Count > 0)
                {
                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                dt = db.ExecuteDataTable(sql_string + whereClause, CommandType.Text);

                if (dt.Rows.Count > 0)
                {
                    PropertyInfo[] properties = GetPublicProperties(customObject.GetType());

                    for (int i = 0; i < properties.Count(); i++)
                    {
                        PropertyInfo p = properties[i];
                        if (IsInColumns(customObject, p.Name))
                        {
                            var deger = dt.Rows[0][((System.Reflection.MemberInfo)(p)).Name];
                            SetProperty(customObject, p, deger);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ClearParameters();
            }

            return (T)customObject;

        }

        public string GetDocSeri<T>(string Seri)
        {
            ICustomObject baseObject = Activator.CreateInstance<T>() as ICustomObject;
            IDocument customObject = Activator.CreateInstance<T>() as IDocument;



            string sql_string = "Select Top 1 ISNULL(MAX(cast(DocSerialNo as int)),0) From " + baseObject.TableName;
            string whereClause = String.Format(" Where DocSerial='{0}'", Seri);

            var LastNo = db.ExecuteScalar(sql_string + whereClause, CommandType.Text);

            if (LastNo != null)
                return Tool.StringProc.Increment(LastNo.ToString(), true);
            else
                return "";
        }

        public BindingList<T> GetObjectList<T>(string whereString, string orderBy)
        {
            BindingList<T> cs = new BindingList<T>();
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;

            string sql_string = "Select * From " + customObject.TableName;
            string whereClause = "";
            if (whereString != "")
                whereClause = " Where " + whereString;

            if (orderBy != "")
                whereClause += " Order By " + orderBy;
            DataTable dt = new DataTable();

            try
            {
                if (Parameters.Count > 0)
                {
                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                dt = db.ExecuteDataTable(sql_string + whereClause, CommandType.Text);

                PropertyInfo[] properties = GetPublicProperties(customObject.GetType());
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    ICustomObject customObject1 = Activator.CreateInstance<T>() as ICustomObject;

                    for (int i = 0; i < properties.Count(); i++)
                    {
                        PropertyInfo p = properties[i];
                        if (IsInColumns(customObject, p.Name))
                        {
                            var deger = dt.Rows[j][((System.Reflection.MemberInfo)(p)).Name];
                            Type t = p.PropertyType;

                            SetProperty(customObject1, p, deger);
                        }
                    }
                    cs.Add((T)customObject1);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { ClearParameters(); }

            return cs;

        }

        public BindingList<T> GetObjectList<T>(int top, string whereString, string orderBy)
        {
            BindingList<T> cs = new BindingList<T>();
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;

            string sql_string = "Select Top " + top + " * From " + customObject.TableName;
            string whereClause = "";
            if (whereString != "")
                whereClause = " Where " + whereString;

            if (orderBy != "")
                whereClause += " Order By " + orderBy;
            DataTable dt = new DataTable();

            try
            {
                if (Parameters.Count > 0)
                {
                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                dt = db.ExecuteDataTable(sql_string + whereClause, CommandType.Text);

                PropertyInfo[] properties = GetPublicProperties(customObject.GetType());
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    ICustomObject customObject1 = Activator.CreateInstance<T>() as ICustomObject;

                    for (int i = 1; i < properties.Count(); i++)
                    {
                        PropertyInfo p = properties[i];
                        if (IsInColumns(customObject, p.Name))
                        {
                            var deger = dt.Rows[j][((System.Reflection.MemberInfo)(p)).Name];
                            Type t = p.PropertyType;

                            SetProperty(customObject1, p, deger);
                        }
                    }
                    cs.Add((T)customObject1);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { ClearParameters(); }

            return cs;

        }

        public DataTable GetObjectListDT<T>(string whereString)
        {
            return GetObjectListDT<T>(0, whereString, string.Empty);
        }

        public DataTable GetObjectListDT<T>(string whereString, string orderBy)
        {
            return GetObjectListDT<T>(0, whereString, orderBy);
        }

        public DataTable GetObjectListDT<T>(int top, string whereString, string orderBy)
        {
            ICustomObject customObject = Activator.CreateInstance<T>() as ICustomObject;

            string sql_string = "Select {0} * From " + customObject.TableName;
            string whereClause = "";
            if (whereString != "")
                whereClause = " Where " + whereString;

            if (orderBy != "")
                whereClause += " Order By " + orderBy;

            if (top != 0)
                sql_string = string.Format(sql_string, " TOP " + top);
            else
                sql_string = string.Format(sql_string, "");


            DataTable dt = new DataTable();

            try
            {
                if (Parameters.Count > 0)
                {
                    foreach (ObjParam param in Parameters)
                    {
                        db.AddInParameters(param.ParamName, param.ParamType, param.ParamValue);
                    }
                }

                dt = db.ExecuteDataTable(sql_string + whereClause, CommandType.Text);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { ClearParameters(); }

            return dt;

        }

        private static PropertyInfo[] GetPublicProperties(Type type)
        {
            if (type.IsInterface)
            {
                var propertyInfos = new List<PropertyInfo>();

                var considered = new List<Type>();
                var queue = new Queue<Type>();
                considered.Add(type);
                queue.Enqueue(type);
                while (queue.Count > 0)
                {
                    var subType = queue.Dequeue();
                    foreach (var subInterface in subType.GetInterfaces())
                    {
                        if (considered.Contains(subInterface)) continue;

                        considered.Add(subInterface);
                        queue.Enqueue(subInterface);
                    }

                    var typeProperties = subType.GetProperties(
                        BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance);

                    var newPropertyInfos = typeProperties
                        .Where(x => !propertyInfos.Contains(x));

                    propertyInfos.InsertRange(0, newPropertyInfos);
                }

                return propertyInfos.ToArray();
            }

            return type.GetProperties(BindingFlags.FlattenHierarchy
                | BindingFlags.Public | BindingFlags.Instance);
        }

        public void AddParameter(string parameterName, SqlDbType parameterType, object parameterValue)
        {
            Parameters.Add(new ObjParam { ParamName = parameterName, ParamType = parameterType, ParamValue = parameterValue });
        }

        public void ClearParameters()
        {
            Parameters.Clear();
            db.ClearParameters();
        }

        public void Commit()
        {
            if (useTransaction)
                db.Commit();
        }

        public void Rollback()
        {
            if (useTransaction)
                db.RollBack();
        }

        private bool IsInColumns(ICustomObject customObject, string columnName)
        {
            bool sonuc = false;
            foreach (ObjColumn column in customObject.Columns)
            {
                if (column.ColumnName == columnName)
                    sonuc = true;
            }
            return sonuc;
        }
    }
}
