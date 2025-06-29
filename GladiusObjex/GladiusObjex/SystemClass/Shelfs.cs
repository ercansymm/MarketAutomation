using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.SystemClass
{
    public class Shelfs : gsBase
    {
        public Guid _WareHouseRef;

        public Guid WareHouseRef { get => _WareHouseRef; set { _WareHouseRef = value; SetUpdated("WareHouseRef", value); } }

        private int _ShelfNo;
        public int ShelfNo { get => _ShelfNo; set { _ShelfNo = value; SetUpdated("ShelfNo", value); } }

        private string _CardCode;

        [Display(Name = "Kart Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private string _CardName;

        [Display(Name = "Kart Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private int _ShelfSize;
        public int ShelfSize { get => _ShelfSize; set { _ShelfSize = value; SetUpdated("ShelfSize", value); } }

        [ForeignKey("WareHouseRef")]
        public virtual WareHouses myWareHouse { get; set; }

        public Shelfs()
        {
            TableName = "Shelfs";

            Columns.Add(new ObjColumn("WareHouseRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("ShelfNo", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ShelfSize", SqlDbType.Int, 0, false, false));


            this.ShelfNo = 0; this.ShelfSize = 0; this.CardCode = ""; this.CardName = "";
            this.WareHouseRef = Guid.Empty;
        }
    }
}
