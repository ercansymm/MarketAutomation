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
    public class StockLanguage:gsBase
    {
        private string _Language;
        [Display(Name = "Dil")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string Language { get => _Language; set { _Language = value; SetUpdated("Language", value); } }

        private string _CardName;
        [Display(Name = "Stok Adı")]
        [DataType("nvarchar")]
        [StringLength(900)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        public StockLanguage()
        {
            TableName = "StockLanguage";

            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Language", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));


            this.Ref = Guid.NewGuid();
            this.StockRef = Guid.Empty;
            this.Language = "";
            this.CardName = "";
        }
    }
}
