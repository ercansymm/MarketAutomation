using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.Tracing
{
    public class P_ClientGroup : gsBase
    {
        private string _GroupName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string GroupName { get => _GroupName; set { _GroupName = value; SetUpdated("GroupName", value); } }

        public P_ClientGroup()
        {
            TableName = "P_ClientGroup";

            Columns.Add(new ObjColumn("GroupName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.GroupName = "";
        }

    }
}
