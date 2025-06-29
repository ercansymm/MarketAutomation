using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.BaseClass
{
    public class gsBaseRecord : gsBase
    {
        #region IBaseRecord Properties


        private bool _IsCancelled;
        public bool IsCancelled { get => _IsCancelled; set { _IsCancelled = value; SetUpdated("IsCancelled", value); } }

        private string _Firm;
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Firm { get => _Firm; set { _Firm = value; SetUpdated("Firm", value); } }

        private string _DbSource;
        [DataType("nvarchar")]
        [StringLength(50)]
        public string DbSource { get => _DbSource; set { _DbSource = value; SetUpdated("DbSource", value); } }

        private string _DbSourceRef;
        [DataType("nvarchar")]
        [StringLength(50)]
        public string DbSourceRef { get => _DbSourceRef; set { _DbSourceRef = value; SetUpdated("DbSourceRef", value); } }

        private DateTime _LastUpdate;
        public DateTime LastUpdate { get => _LastUpdate; set { _LastUpdate = value; SetUpdated("LastUpdate", value); } }

        #endregion




        public gsBaseRecord()
        {
            Columns.Add(new ObjColumn("IsCancelled", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Firm", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DbSource", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DbSourceRef", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LastUpdate", SqlDbType.DateTime, "", false, false));


            IsCancelled = false;
            Firm = "";
            DbSource = ""; DbSourceRef = "";
            LastUpdate = DateTime.Now;
        }
    }
}
