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
    public class StockBrand:gsBase
    {
        private string _CardName;
        [Display(Name = "Marka")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public StockBrand()
        {
            TableName = "StockBrand";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
        }
    }
}
