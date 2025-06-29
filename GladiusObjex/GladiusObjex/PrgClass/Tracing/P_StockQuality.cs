using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class P_StockQuality : gsBase
    {
        private string _QualityName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string QualityName { get => _QualityName; set { _QualityName = value; SetUpdated("QualityName", value); } }

        public P_StockQuality()
        {
            TableName = "P_StockQuality";

            Columns.Add(new ObjColumn("QualityName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.QualityName = "";
        }

    }
}
