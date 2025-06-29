using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class P_StockType : gsBase
    {
        private string _TypeName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string TypeName { get => _TypeName; set { _TypeName = value; SetUpdated("TypeName", value); } }

        public P_StockType()
        {
            TableName = "P_StockType";

            Columns.Add(new ObjColumn("TypeName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.TypeName = "";
        }
    }
}
