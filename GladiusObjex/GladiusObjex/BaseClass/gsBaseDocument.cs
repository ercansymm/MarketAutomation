using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.BaseClass
{
    public class gsDocument : gsBaseRecord
    {
        #region IDocument Properties

        private string _Modul;

        [Display(Name = "Modül")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Modul { get { return _Modul; } set { _Modul = value; SetUpdated("Modul", value); } }

        /*    MTR   Material            Stok Yönetimi
    *    SLS   Sales               Satış Yönetimi
    *    PRC   Purchase            Satınalma Yönetimi
    *    PRD   Production          Üretim Yönetimi
    *    LGS   Logistik            Depo Yönetimi
    *    SRV   Service             Service Yönetimi
    *    FNC   Finance             Finans Yönetimi
    */





        private string _DocType;

        [Display(Name = "Belge Tipi")]
        [DataType("nvarchar")]
        [StringLength(15)]
        public string DocType { get { return _DocType; } set { _DocType = value; SetUpdated("DocType", value); } }


        private DateTime _DocDate;

        [Display(Name = "Belge Tarihi")]
        public DateTime DocDate { get { return _DocDate; } set { _DocDate = value; SetUpdated("DocDate", value); } }


        private string _DocSerial;

        [Display(Name = "Belge Seri")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string DocSerial { get { return _DocSerial; } set { _DocSerial = value; SetUpdated("DocSerial", value); } }


        private string _DocSerialNo;

        [Display(Name = "Belge Seri No")]
        [DataType("nvarchar")]
        [StringLength(15)]
        public string DocSerialNo { get { return _DocSerialNo; } set { _DocSerialNo = value; SetUpdated("DocSerialNo", value); } }


        private string _DocFormalNo;

        [Display(Name = "Matbu No")]
        [DataType("nvarchar")]
        [StringLength(15)]
        public string DocFormalNo { get { return _DocFormalNo; } set { _DocFormalNo = value; SetUpdated("DocFormalNo", value); } }



        private string _DocDesc;

        [Display(Name = "Belge Açıklama")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string DocDesc { get { return _DocDesc; } set { _DocDesc = value; SetUpdated("DocDesc", value); } }


        #endregion


        public gsDocument()
        {

            Columns.Add(new ObjColumn("Modul", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocType", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("DocSerial", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocSerialNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocFormalNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("DocDesc", SqlDbType.NVarChar, "", false, false));


            Modul = ""; DocType = ""; DocDate = DateTime.Parse("1900-01-01"); DocSerial = ""; DocSerialNo = ""; DocFormalNo = ""; DocDesc = "";

        }



    }
}
