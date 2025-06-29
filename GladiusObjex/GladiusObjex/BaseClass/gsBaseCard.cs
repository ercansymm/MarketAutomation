using GladiusObjex.Base;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.BaseClass
{
    public class gsBaseCard : gsBase, IBaseCard
    {

        #region IBaseCard


        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }


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

        private string _CardDesc;

        [Display(Name = "Kart Açıklaması")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardDesc { get => _CardDesc; set { _CardDesc = value; SetUpdated("CardDesc", value); } }

        private string _SpeCode1;

        [Display(Name = "Özel Kod 1")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode1 { get => _SpeCode1; set { _SpeCode1 = value; SetUpdated("SpeCode1", value); } }

        private string _SpeCode2;

        [Display(Name = "Özel Kod 2")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode2 { get => _SpeCode2; set { _SpeCode2 = value; SetUpdated("SpeCode2", value); } }

        private string _SpeCode3;

        [Display(Name = "Özel Kod 3")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string SpeCode3 { get => _SpeCode3; set { _SpeCode3 = value; SetUpdated("SpeCode3", value); } }


        private string _DbSource;

        [Display(Name = "Veri Kaynağı")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string DbSource { get => _DbSource; set { _DbSource = value; SetUpdated("DbSource", value); } }


        private string _DbSourceRef;

        [Display(Name = "Veri Kaynağı")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string DbSourceRef { get => _DbSourceRef; set { _DbSourceRef = value; SetUpdated("DbSourceRef", value); } }


        private DateTime _LastUpdate;
        [Display(Name = "Son Güncelleme ")]
        public DateTime LastUpdate { get => _LastUpdate; set { _LastUpdate = value; SetUpdated("LastUpdate", value); } }


        #endregion



        public gsBaseCard()
        {
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, false, false, false));
            Columns.Add(new ObjColumn("CardCode", SqlDbType.NVarChar, 0, false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, 0, false, false));
            Columns.Add(new ObjColumn("CardDesc", SqlDbType.NVarChar, 0, false, false));
            Columns.Add(new ObjColumn("DbSource", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DbSourceRef", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LastUpdate", SqlDbType.DateTime, "", false, false));

            IsPassive = false;
            CardCode = ""; CardName = ""; CardDesc = "";
            DbSource = ""; DbSourceRef = "";
            LastUpdate = DateTime.Now;

        }

    }
}
