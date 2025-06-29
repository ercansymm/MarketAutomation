using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace GladiusObjex.SystemClass
{
    public class ExchangeRate : gsBase
    {
        private DateTime _CurrDate;
        [Display(Name = "Son Güncelleme ")]
        public DateTime CurrDate { get => _CurrDate; set { _CurrDate = value; SetUpdated("CurrDate", value); } }

        private string _Name;

        [Display(Name = "Döviz İsmi")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string Name { get => _Name; set { _Name = value; SetUpdated("Name", value); } }

        private string _Code;

        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string Code { get => _Code; set { _Code = value; SetUpdated("Code", value); } }

        private string _CrossRateName;

        [Display(Name = "Çapraz Kur İsmi")]
        [DataType("nvarchar")]
        [StringLength(25)]
        public string CrossRateName { get => _CrossRateName; set { _CrossRateName = value; SetUpdated("CrossRateName", value); } }

        private decimal _ForexBuying;
        public decimal ForexBuying { get => _ForexBuying; set { _ForexBuying = value; SetUpdated("ForexBuying", value); } }

        private decimal _ForexSelling;
        public decimal ForexSelling { get => _ForexSelling; set { _ForexSelling = value; SetUpdated("ForexSelling", value); } }

        private decimal _BanknoteBuying;
        public decimal BanknoteBuying { get => _BanknoteBuying; set { _BanknoteBuying = value; SetUpdated("BanknoteBuying", value); } }

        private decimal _BanknoteSelling;
        public decimal BanknoteSelling { get => _BanknoteSelling; set { _BanknoteSelling = value; SetUpdated("BanknoteSelling", value); } }




        public ExchangeRate()
        {
            TableName = "ExchangeRate";

            Columns.Add(new ObjColumn("CurrDate", SqlDbType.DateTime2, "1900-01-01", false, false));
            Columns.Add(new ObjColumn("Name", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Code", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CrossRateName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ForexBuying", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("ForexSelling", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("BanknoteBuying", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("BanknoteSelling", SqlDbType.Decimal, 0, false, false));


            this.Ref = Guid.NewGuid();
            this.CurrDate = DateTime.Today;
            this.Name = "";
            this.Code = "";
            this.CrossRateName = "";
            this.ForexBuying = 0;
            this.ForexSelling = 0;
            this.BanknoteBuying = 0;
            this.BanknoteSelling = 0;
        }

        public ExchangeRate(Guid refx, DateTime currDate, string name, string code, string crossRateName, decimal forexBuying, decimal forexSelling, decimal banknoteBuying, decimal banknoteSelling)
        {
            Ref = refx;
            CurrDate = currDate;
            Name = name;
            Code = code;
            CrossRateName = crossRateName;
            ForexBuying = forexBuying;
            ForexSelling = forexSelling;
            BanknoteBuying = banknoteBuying;
            BanknoteSelling = banknoteSelling;

        }

        public static bool CurrencySaveOrUpdate(string ConnStr, BindingList<ExchangeRate> CurrList)
        {
            bool result = false;

            if (CurrList == null)
                return false;


            using (TransactionScope Ts = new TransactionScope())
            {


                SqlConnection Con = new SqlConnection(ConnStr);

                if (Con.State == System.Data.ConnectionState.Closed)
                {
                    Con.Open();
                }

                try
                {
                    for (int i = 0; i < CurrList.Count; i++)
                    {
                        #region
                        string Qry = String.Format(@"IF NOT EXISTS (select Ref from ExchangeRate where currDate = '{1}' and Code = '{3}')
            BEGIN
            INSERT INTO ExchangeRate
            select '{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8}
            SELECT SCOPE_IDENTITY()
            END
            ELSE
            BEGIN
            UPDATE [ExchangeRate]
             SET Ref = '{0}',
            CurrDate = '{1}',
            Name = '{2}',
            Code = '{3}',
            CrossRateName = '{4}',
            ForexBuying = {5},
            ForexSelling = {6},
            BanknoteBuying = {7},
            BanknoteSelling = {8}
            Where currDate = '{1}' and Code = '{3}'
            select '{0}'
            END            ",
                    CurrList[i].Ref,
                    CurrList[i].CurrDate.ToString("yyyy-MM-dd"),
                    CurrList[i].Name,
                    CurrList[i].Code,
                    CurrList[i].CrossRateName,
                    CurrList[i].ForexBuying.ToString().Replace(',', '.'),
                    CurrList[i].ForexSelling.ToString().Replace(',', '.'),
                    CurrList[i].BanknoteBuying.ToString().Replace(',', '.'),
                    CurrList[i].BanknoteSelling.ToString().Replace(',', '.')
                    );
                        #endregion

                        SqlCommand Com = new SqlCommand(Qry, Con);

                        Com.ExecuteNonQuery();
                    }
                    Ts.Complete();
                    result = true;
                }
                catch (SqlException)
                {
                    result = false;
                }
                finally { Con.Close(); Con.Dispose(); }
            }

            return result;
        }
    }
}
