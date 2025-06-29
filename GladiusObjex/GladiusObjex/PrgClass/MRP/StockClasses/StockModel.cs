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
    public class StockModel:gsBase
    {
        private string _CardName;
        [Display(Name = "Model")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _BrandRef;
        public Guid BrandRef { get => _BrandRef; set { _BrandRef = value; SetUpdated("BrandRef", value); } }

        public StockModel()
        {
            TableName = "StockModel";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("BrandRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
            this.BrandRef = Guid.Empty;
        }
    }
}
