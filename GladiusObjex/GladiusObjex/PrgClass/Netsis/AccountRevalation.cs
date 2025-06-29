using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Netsis
{
    public class AccountRevalation : gsBase
    {
        private int _Mounth;
        public int Mounth { get => _Mounth; set { _Mounth = value; SetUpdated("Mounth", value); } }

        private decimal _CurrUsd;
        public decimal CurrUsd { get => _CurrUsd; set { _CurrUsd = value; SetUpdated("CurrUsd", value); } }


        private decimal _CurrEur;
        public decimal CurrEur { get => _CurrEur; set { _CurrEur = value; SetUpdated("CurrEur", value); } }

        private decimal _CurrGbp;
        public decimal CurrGbp { get => _CurrGbp; set { _CurrGbp = value; SetUpdated("CurrGbp", value); } }

        private string _Code;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string Code { get => _Code; set { _Code = value; SetUpdated("Code", value); } }

        private string _GroupCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string GroupCode { get => _GroupCode; set { _GroupCode = value; SetUpdated("GroupCode", value); } }

        private string _AccCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string AccCode { get => _AccCode; set { _AccCode = value; SetUpdated("AccCode", value); } }

        private string _Name;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Name { get => _Name; set { _Name = value; SetUpdated("Name", value); } }

        private int _Curr;
        public int Curr { get => _Curr; set { _Curr = value; SetUpdated("Curr", value); } }

        private decimal _CurrAmount;
        public decimal CurrAmount { get => _CurrAmount; set { _CurrAmount = value; SetUpdated("CurrAmount", value); } }


        private decimal _BalanceValue;
        public decimal BalanceValue { get => _BalanceValue; set { _BalanceValue = value; SetUpdated("BalanceValue", value); } }


        private decimal _MustBe;
        public decimal MustBe { get => _MustBe; set { _MustBe = value; SetUpdated("MustBe", value); } }

        private decimal _CurrGap;
        public decimal CurrGap { get => _CurrGap; set { _CurrGap = value; SetUpdated("CurrGap", value); } }

        public AccountRevalation()
        {
            TableName = "AccountRevalation";

            Columns.Add(new ObjColumn("Mounth", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("CurrUsd", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("CurrEur", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("CurrGbp", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("Code", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("GroupCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("AccCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Name", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Curr", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("CurrAmount", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("BalanceValue", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("MustBe", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("CurrGap", SqlDbType.Decimal, 0, false, false));

            this.AccCode = ""; this.BalanceValue = 0; this.Code = ""; this.Curr = 0; this.CurrAmount = 0; this.CurrEur = 0; this.CurrGap = 0; this.CurrGbp = 0; this.CurrUsd = 0; this.GroupCode = ""; this.Mounth = 0; this.MustBe = 0; this.Name = "";


        }
    }
}
