using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Tool
{
    public class StringProc
    {

        public static string Increment(string value, bool IsNumeric)
        {
            if (value.Length > 0)
            {
                String chars;
                chars = IsNumeric ? "0123456789" : "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char lastChar = value[value.Length - 1];
                string fragment = value.Substring(0, value.Length - 1);

                int lenght = IsNumeric ? 9 : 35;

                if (value == "9" && IsNumeric)
                {
                    return "10";
                }

                if (chars.IndexOf(lastChar) < lenght)
                {
                    lastChar = chars[chars.IndexOf(lastChar) + 1];
                    string nextNumber = fragment + lastChar;
                    return nextNumber;
                }
                return Increment(fragment, IsNumeric) + '0';
            }
            else
            {
                return "00000001";
            }
        }
        public static string IncrementInt(String number, int lenght, bool isIncrement)
        {

            int no = 0;
            int.TryParse(number, out no);
            if (isIncrement)
                no++;

            string noStr = "00000000000000000000000000000000000000000000000000000000" + no;


            return noStr.Substring(noStr.Length - lenght);
        }
        private string DecimalToText(decimal tutar)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " YTL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " KR";
            else
                yazi += "SIFIR KR";

            return yazi;
        }
        public static string IncrementOrderWOffer(string value, bool IsNumeric)
        {
            if (value.Length > 0)
            {
                String chars;
                chars = IsNumeric ? "0123456789" : "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char lastChar = value[value.Length - 1];
                string fragment = value.Substring(0, value.Length - 1);

                int lenght = IsNumeric ? 9 : 35;

                if (value == "9" && IsNumeric)
                {
                    return "10";
                }

                if (chars.IndexOf(lastChar) < lenght)
                {
                    lastChar = chars[chars.IndexOf(lastChar) + 1];
                    string nextNumber = fragment + lastChar;
                    return nextNumber;
                }
                return Increment(fragment, IsNumeric) + '0';
            }
            else
            {
                return "T00000001";
            }
        }
        public static string IncrementOrderWOutOffer(string value, bool IsNumeric)
        {
            if (value.Length > 0)
            {
                String chars;
                chars = IsNumeric ? "0123456789" : "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char lastChar = value[value.Length - 1];
                string fragment = value.Substring(0, value.Length - 1);

                int lenght = IsNumeric ? 9 : 35;

                if (value == "9" && IsNumeric)
                {
                    return "10";
                }

                if (chars.IndexOf(lastChar) < lenght)
                {
                    lastChar = chars[chars.IndexOf(lastChar) + 1];
                    string nextNumber = fragment + lastChar;
                    return nextNumber;
                }
                return Increment(fragment, IsNumeric) + '0';
            }
            else
            {
                return "S00000001";
            }
        }
    }
}
