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
    public class StockGroup:gsBase
    {

        private string _CardName;
        [Display(Name = "Grup Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public StockGroup()
        {
            TableName = "StockGroup";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
        }
    }
}
