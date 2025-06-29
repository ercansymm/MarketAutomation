using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace GladiusObjex.SystemClass
{
    public class Branches : gsBase
    {
        public Guid _FirmRef;

        public Guid FirmRef { get => _FirmRef; set { _FirmRef = value; SetUpdated("FirmRef", value); } }

        private int _BranchNo;
        public int BranchNo { get => _BranchNo; set { _BranchNo = value; SetUpdated("BranchNo", value); } }

        private string _CardCode;

        [Display(Name = "Şube Kodu")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardCode { get => _CardCode; set { _CardCode = value; SetUpdated("CardCode", value); } }

        private string _CardName;

        [Display(Name = "Şube Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _District;

        [Display(Name = "İlçe")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string District { get => _District; set { _District = value; SetUpdated("District", value); } }


        private string _City;

        [Display(Name = "Şehir")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string City { get => _City; set { _City = value; SetUpdated("City", value); } }

        [ForeignKey("FirmRef")]
        public virtual Firms myFirm { get; set; }

        public virtual BindingList<WareHouses> WareHouseDetail { get; set; }

        public Branches GetBranches(Guid _REF)
        {
            ObjectManager mng = new ObjectManager(false, "erpConnStr");

            Branches myBranches = new Branches();

            myBranches = mng.GetObject<Branches>(_REF);
            myBranches.WareHouseDetail = mng.GetObjectList<WareHouses>(String.Format(" BranchRef = '{0}'", _REF), " WhouseNo ");

            return myBranches;
        }

        public Branches()
        {
            TableName = "Branches";

            Columns.Add(new ObjColumn("FirmRef", SqlDbType.UniqueIdentifier, "00000000-0000-0000-0000-000000000000", false, false));
            Columns.Add(new ObjColumn("BranchNo", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("District", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("City", SqlDbType.NVarChar, "", false, false));

            this.FirmRef = Guid.Empty; this.BranchNo = 0;
            this.CardCode = ""; this.CardName = "";
            this.District = ""; this.City = "";

            WareHouseDetail = new BindingList<WareHouses>();

        }
    }
}
