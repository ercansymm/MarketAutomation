using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GladiusObjex.SystemClass
{
    public enum ExchangeType
    {
        ForexBuying, ForexSelling,
        BanknoteBuying, BanknoteSelling
    }

    public enum CurrencyCode
    {
        USD, AUD, DKK,
        EUR, GBP, CHF,
        SEK, CAD, KWD,
        NOK, SAR, JPY,
        BGN, RON, RUB,
        IRR, CNY, PKR,
        TRY
    }
    public class CurrencyExchange : IDisposable
    {
        private static Dictionary<string, ExchangeRate> GetCurrencyRates(string Link)
        {
            try
            {
                XmlTextReader rdr = new XmlTextReader(Link);
                // XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
                // XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
                XmlDocument myxml = new XmlDocument();
                // XmlDocument nesnesini yaratıyoruz.
                myxml.Load(rdr);
                // Load metodu ile xml yüklüyoruz
                XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
                XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
                XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
                XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
                XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

                Dictionary<string, ExchangeRate> ExchangeRates = new Dictionary<string, ExchangeRate>();

                ExchangeRates.Add("TRY", new ExchangeRate(Guid.NewGuid(), DateTime.Today, "Türk Lirası", "TRY", "TRY/TRY", 1, 1, 1, 1));



                for (int i = 0; i < adi.Count; i++)
                {
                    ExchangeRate cur = new ExchangeRate(Guid.NewGuid(), DateTime.Today, adi.Item(i).InnerText.ToString(),
                        kod.Item(i).InnerText.ToString(),
                        kod.Item(i).InnerText.ToString() + "/TRY",
                        (String.IsNullOrWhiteSpace(doviz_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDecimal(doviz_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(doviz_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDecimal(doviz_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(efektif_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDecimal(efektif_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        (String.IsNullOrWhiteSpace(efektif_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDecimal(efektif_satis.Item(i).InnerText.ToString().Replace(".", ","))
                        );

                    ExchangeRates.Add(kod.Item(i).InnerText.ToString(), cur);
                }

                return ExchangeRates;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Dictionary<string, ExchangeRate> GetAllCurrenciesTodaysExchangeRates()
        {
            try
            {
                return GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesTodaysExchangeRates()
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(decimal));
                dt.Columns.Add("ForexSelling", typeof(decimal));
                dt.Columns.Add("BanknoteBuying", typeof(decimal));
                dt.Columns.Add("BanknoteSelling", typeof(decimal));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static BindingList<ExchangeRate> GetListAllCurrenciesTodaysExchangeRates()
        {
            BindingList<ExchangeRate> currList = new BindingList<ExchangeRate>();

            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");



                foreach (string item in CurrencyRates.Keys)
                {
                    ExchangeRate curr = new ExchangeRate();

                    curr.BanknoteBuying = CurrencyRates[item].BanknoteBuying;
                    curr.BanknoteSelling = CurrencyRates[item].BanknoteSelling;
                    curr.Code = CurrencyRates[item].Code;
                    curr.CrossRateName = CurrencyRates[item].CrossRateName;
                    curr.CurrDate = DateTime.Today;
                    curr.ForexBuying = CurrencyRates[item].ForexBuying;
                    curr.ForexSelling = CurrencyRates[item].ForexSelling;
                    curr.Name = CurrencyRates[item].Name;
                    curr.Ref = Guid.NewGuid();

                    currList.Add(curr);
                }


            }
            catch (Exception)
            {
                currList = null;
            }

            return currList;
        }

        public static Dictionary<string, ExchangeRate> GetAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                return GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(decimal));
                dt.Columns.Add("ForexSelling", typeof(decimal));
                dt.Columns.Add("BanknoteBuying", typeof(decimal));
                dt.Columns.Add("BanknoteSelling", typeof(decimal));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;

            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static BindingList<ExchangeRate> GetListAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            BindingList<ExchangeRate> currList = new BindingList<ExchangeRate>();

            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");



                foreach (string item in CurrencyRates.Keys)
                {
                    ExchangeRate curr = new ExchangeRate();

                    curr.BanknoteBuying = CurrencyRates[item].BanknoteBuying;
                    curr.BanknoteSelling = CurrencyRates[item].BanknoteSelling;
                    curr.Code = CurrencyRates[item].Code;
                    curr.CrossRateName = CurrencyRates[item].CrossRateName;
                    curr.CurrDate = DateTime.Parse(SYear + "-" + SMonth + "-" + SDay);
                    curr.ForexBuying = CurrencyRates[item].ForexBuying;
                    curr.ForexSelling = CurrencyRates[item].ForexSelling;
                    curr.Name = CurrencyRates[item].Name;
                    curr.Ref = Guid.NewGuid();

                    currList.Add(curr);
                }


            }
            catch (Exception)
            {
                currList = null;
            }

            return currList;
        }

        public static Dictionary<string, ExchangeRate> GetAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                return GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Code", typeof(string));
                dt.Columns.Add("CrossRateName", typeof(string));
                dt.Columns.Add("ForexBuying", typeof(decimal));
                dt.Columns.Add("ForexSelling", typeof(decimal));
                dt.Columns.Add("BanknoteBuying", typeof(decimal));
                dt.Columns.Add("BanknoteSelling", typeof(decimal));

                foreach (string item in CurrencyRates.Keys)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = CurrencyRates[item].Name;
                    dr["Code"] = CurrencyRates[item].Code;
                    dr["CrossRateName"] = CurrencyRates[item].CrossRateName;
                    dr["ForexBuying"] = CurrencyRates[item].ForexBuying;
                    dr["ForexSelling"] = CurrencyRates[item].ForexSelling;
                    dr["BanknoteBuying"] = CurrencyRates[item].BanknoteBuying;
                    dr["BanknoteSelling"] = CurrencyRates[item].BanknoteSelling;
                    dt.Rows.Add(dr);
                }

                return dt;

            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetTodaysExchangeRates(CurrencyCode Currency)
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency(" + Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetHistoricalExchangeRates(CurrencyCode Currency, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency(" + Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetHistoricalExchangeRates(CurrencyCode Currency, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (CurrencyRates.Keys.Contains(Currency.ToString()))
                {
                    return CurrencyRates[Currency.ToString()];
                }
                else
                {
                    throw new Exception("The specified currency(" + Currency.ToString() + ") was not found!");
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetTodaysCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new ExchangeRate(Guid.NewGuid(),
                        DateTime.Today,
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code + "/" + MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round((OtherCurrency.ForexSelling / MainCurrency.ForexSelling), 4),
                        (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round((OtherCurrency.BanknoteBuying / MainCurrency.BanknoteBuying), 4),
                        (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round((OtherCurrency.BanknoteSelling / MainCurrency.BanknoteSelling), 4)
                    );
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal GetTodaysCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new ExchangeRate(
                        Guid.NewGuid(),
                        DateTime.Parse(SYear + "-" + SMonth + "-" + SDay),
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code + "/" + MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4)
                    );
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static ExchangeRate GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return new ExchangeRate(
                        Guid.NewGuid(),
                        DateTime.Parse(SYear + "-" + SMonth + "-" + SDay),
                        OtherCurrency.Name,
                        OtherCurrency.Code,
                        OtherCurrency.Code + "/" + MainCurrency.Code,
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4),
                        (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4)
                    );
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round((OtherCurrency.ForexBuying / MainCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateTodaysExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode)
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateTodaysExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType)
        {
            try
            {
                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/today.xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateHistoricalExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateHistoricalExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType, DateTime date)
        {
            try
            {
                string SYear = String.Format("{0:0000}", date.Year);
                string SMonth = String.Format("{0:00}", date.Month);
                string SDay = String.Format("{0:00}", date.Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateHistoricalExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public static decimal CalculateHistoricalExchange(decimal Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType, int Year, int Month, int Day)
        {
            try
            {
                string SYear = String.Format("{0:0000}", Year);
                string SMonth = String.Format("{0:00}", Month);
                string SDay = String.Format("{0:00}", Day);

                Dictionary<string, ExchangeRate> CurrencyRates = GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");

                if (!CurrencyRates.Keys.Contains(FromCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + FromCurrencyCode.ToString() + ") was not found!");
                }
                else if (!CurrencyRates.Keys.Contains(ToCurrencyCode.ToString()))
                {
                    throw new Exception("The specified currency(" + ToCurrencyCode.ToString() + ") was not found!");
                }
                else
                {
                    ExchangeRate MainCurrency = CurrencyRates[FromCurrencyCode.ToString()];
                    ExchangeRate OtherCurrency = CurrencyRates[ToCurrencyCode.ToString()];

                    switch (exchangeType)
                    {
                        case ExchangeType.ForexBuying:
                            return (OtherCurrency.ForexBuying == 0 || MainCurrency.ForexBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexBuying / OtherCurrency.ForexBuying), 4);
                        case ExchangeType.ForexSelling:
                            return (OtherCurrency.ForexSelling == 0 || MainCurrency.ForexSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.ForexSelling / OtherCurrency.ForexSelling), 4);
                        case ExchangeType.BanknoteBuying:
                            return (OtherCurrency.BanknoteBuying == 0 || MainCurrency.BanknoteBuying == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteBuying / OtherCurrency.BanknoteBuying), 4);
                        case ExchangeType.BanknoteSelling:
                            return (OtherCurrency.BanknoteSelling == 0 || MainCurrency.BanknoteSelling == 0) ? 0 : Math.Round(Amount * (MainCurrency.BanknoteSelling / OtherCurrency.BanknoteSelling), 4);
                        default:
                            return 0;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
