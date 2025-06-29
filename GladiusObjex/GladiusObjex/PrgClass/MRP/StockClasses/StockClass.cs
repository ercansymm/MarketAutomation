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
    public class StockClass:gsBase
    {
        private string _CardName;
        [Display(Name = "Sınıf")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        //public virtual BindingList<StockClassSub> SubClass { get; set; }
        public StockClass()
        {
            TableName = "StockClass";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();

        }
    }
}
