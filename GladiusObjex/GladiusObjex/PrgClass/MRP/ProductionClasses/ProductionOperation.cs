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

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class ProductionOperation:gsBase
    {
        private string _CardName;
        [Display(Name = "Model")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _PlaceRef;
        public Guid PlaceRef { get => _PlaceRef; set { _PlaceRef = value; SetUpdated("PlaceRef", value); } }

        private string _CardCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        public ProductionOperation()
        {
            TableName = "ProductionOperation";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("PlaceRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
            this.PlaceRef = Guid.Empty;
            this.CardCode = "";
        }
    }
}
