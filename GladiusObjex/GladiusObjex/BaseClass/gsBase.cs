using GladiusObjex.Provider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace GladiusObjex.BaseClass
{
    public class gsBase : IDisposable, ICustomObject
    {
        private Guid _Ref;
        [Key]
        public Guid Ref { get => _Ref; set { _Ref = value; SetUpdated("Ref", value); } }

        #region Methods


        [NotMapped]
        [JsonIgnore]
        public string TableName { get; set; }


        private List<ObjColumn> _Columns = new List<ObjColumn>();

        [NotMapped]
        [JsonIgnore]
        public List<ObjColumn> Columns
        {
            get
            {
                return _Columns;
            }
            set { value = _Columns; }

        }


        public void SetUpdated(string columnName, object columnValue)
        {
            foreach (ObjColumn column in Columns)
            {
                if (column.ColumnName == columnName)
                {
                    column.IsUpdated = true;
                    column.ColumnValue = columnValue;
                    break;
                }
            }
        }


        public void ClearUpdateColumns()
        {
            foreach (ObjColumn column in Columns)
            {
                column.IsUpdated = false;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion


        public gsBase()
        {
            Columns.Add(new ObjColumn("Ref", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", true, false));

            Ref = Guid.NewGuid();

        }
    }
}
