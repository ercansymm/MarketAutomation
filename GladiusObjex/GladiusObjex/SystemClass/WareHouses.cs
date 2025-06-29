using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.SystemClass
{
    public class WareHouses : gsBase
    {
        public Guid _BranchRef;

        public Guid BranchRef { get => _BranchRef; set { _BranchRef = value; SetUpdated("BranchRef", value); } }

        private int _WhouseNo;
        public int WhouseNo { get => _WhouseNo; set { _WhouseNo = value; SetUpdated("WhouseNo", value); } }

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

        [ForeignKey("BranchRef")]
        public virtual Branches myBranches { get; set; }

        public virtual BindingList<Shelfs> ShelfsDetail { get; set; }

        public WareHouses GetWareHouses(Guid _REF)
        {
            ObjectManager mng = new ObjectManager(false, "erpConnStr");


            WareHouses myWareHouses = new WareHouses();

            myWareHouses = mng.GetObject<WareHouses>(_REF);
            myWareHouses.ShelfsDetail = mng.GetObjectList<Shelfs>(String.Format(" WareHouseRef = '{0}'", _REF), " ShelfNo ");

            return myWareHouses;

        }

        public WareHouses()
        {
            TableName = "WareHouses";

            Columns.Add(new ObjColumn("BranchRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("WhouseNo", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            this.WhouseNo = 0; this.BranchRef = Guid.Empty;
            this.CardCode = ""; this.CardName = "";

            ShelfsDetail = new BindingList<Shelfs>();
        }
    }
}
