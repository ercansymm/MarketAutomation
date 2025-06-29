using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.MRP.Reports
{
    public class sysReport : gsBase
    {
        private string _ReportCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string ReportCode { get => _ReportCode; set { _ReportCode = value; SetUpdated("ReportCode", value); } }

        private string _ReportName;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string ReportName { get => _ReportName; set { _ReportName = value; SetUpdated("ReportName", value); } }

        private string _ReportQuery;
        public string ReportQuery { get => _ReportQuery; set { _ReportQuery = value; SetUpdated("ReportQuery", value); } }

        public sysReport()
        {
            TableName = "sysReport";

            Columns.Add(new ObjColumn("ReportCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ReportName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ReportQuery", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.ReportCode = "";
            this.ReportName = "";
            this.ReportQuery = "";
        }
    }
}
