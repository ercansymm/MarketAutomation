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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockSubClass:gsBase
    {
        private string _CardName;
        [Display(Name = "Model")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _ClassRef;
        public Guid ClassRef { get => _ClassRef; set { _ClassRef = value; SetUpdated("ClassRef", value); } }

        public StockSubClass()
        {
            TableName = "StockSubClass";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClassRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
            this.ClassRef = Guid.Empty;
        }
    }
}
