using GladiusObjex.BaseClass;
using GladiusObjex.PrgClass.MRP.SalesClasses;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.LogoServiceClasses
{
    public class LogoInfo:gsBase
    {
        private string _CompanyNo;
        [Display(Name = "ŞirketNo")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string CompanyNo { get => _CompanyNo; set { _CompanyNo = value; SetUpdated("CompanyNo", value); } }

        private string _CompanyDB;
        [Display(Name = "FirmaDB")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CompanyDB { get => _CompanyDB; set { _CompanyDB = value; SetUpdated("CompanyDB", value); } }

        private string _CompanySqlPass;
        [Display(Name = "Şifre")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CompanySqlPass { get => _CompanySqlPass; set { _CompanySqlPass = value; SetUpdated("CompanySqlPass", value); } }

        private string _CompanySqlUser;
        [Display(Name = "Kullanıcı Adı")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CompanySqlUser { get => _CompanySqlUser; set { _CompanySqlUser = value; SetUpdated("CompanySqlUser", value); } }

        private string _CompanyName;
        [Display(Name = "Firma Adı")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string CompanyName { get => _CompanyName; set { _CompanyName = value; SetUpdated("CompanyName", value); } }

        private string _ErpFirmNo;
        [Display(Name = "ERPFirmaNo")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ErpFirmNo { get => _ErpFirmNo; set { _ErpFirmNo = value; SetUpdated("ErpFirmNo", value); } }

        private string _ErpPeriodeNo;
        [Display(Name = "ERPPeriyot")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string ErpPeriodeNo { get => _ErpPeriodeNo; set { _ErpPeriodeNo = value; SetUpdated("ErpPeriodeNo", value); } }

        private string _CompanyServer;
        [Display(Name = "CompanyServer")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string CompanyServer { get => _CompanyServer; set { _CompanyServer = value; SetUpdated("CompanyServer", value); } }

        private string _ExpCompanyNo;
        [Display(Name = "DT ŞirketNo")]
        [DataType("nvarchar")]
        [StringLength(200)]
        public string ExpCompanyNo { get => _ExpCompanyNo; set { _ExpCompanyNo = value; SetUpdated("ExpCompanyNo", value); } }

        private string _ExpCompanyDB;
        [Display(Name = "DT FirmaDB")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ExpCompanyDB { get => _ExpCompanyDB; set { _ExpCompanyDB = value; SetUpdated("ExpCompanyDB", value); } }

        private string _ExpCompanySqlPass;
        [Display(Name = "DT Şifre")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string ExpCompanySqlPass { get => _ExpCompanySqlPass; set { _ExpCompanySqlPass = value; SetUpdated("ExpCompanySqlPass", value); } }

        private string _ExpCompanySqlUser;
        [Display(Name = "DT Kullanıcı Adı")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string ExpCompanySqlUser { get => _ExpCompanySqlUser; set { _ExpCompanySqlUser = value; SetUpdated("ExpCompanySqlUser", value); } }

        private string _ExpCompanyName;
        [Display(Name = "DT Firma Adı")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string ExpCompanyName { get => _ExpCompanyName; set { _ExpCompanyName = value; SetUpdated("ExpCompanyName", value); } }

        private string _ExpErpFirmNo;
        [Display(Name = "Dt ERPFirmaNo")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string ExpErpFirmNo { get => _ExpErpFirmNo; set { _ExpErpFirmNo = value; SetUpdated("ExpErpFirmNo", value); } }

        private string _ExpErpPeriodeNo;
        [Display(Name = "DT ERPPeriyot")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string ExpErpPeriodeNo { get => _ExpErpPeriodeNo; set { _ExpErpPeriodeNo = value; SetUpdated("ExpErpPeriodeNo", value); } }

        private string _ExpCompanyServer;
        [Display(Name = "DT CompanyServer")]
        [DataType("nvarchar")]
        [StringLength(700)]
        public string ExpCompanyServer { get => _ExpCompanyServer; set { _ExpCompanyServer = value; SetUpdated("ExpCompanyServer", value); } }

        public LogoInfo getLogo(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            LogoInfo myLogo = new LogoInfo();

            myLogo = mng.GetObject<LogoInfo>(Ref);

            return myLogo;
        }


        public LogoInfo()
        {
            TableName = "LogoInfo";

            Columns.Add(new ObjColumn("CompanyNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CompanyDB", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CompanySqlPass", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CompanySqlUser", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CompanyName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ErpFirmNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ErpPeriodeNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CompanyServer", SqlDbType.NVarChar, "", false, false));

            Columns.Add(new ObjColumn("ExpCompanyNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpCompanyDB", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpCompanySqlPass", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpCompanySqlUser", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpCompanyName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpErpFirmNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpErpPeriodeNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ExpCompanyServer", SqlDbType.NVarChar, "", false, false));


            this.CompanyNo = "";
            this.CompanyDB = "";
            this.CompanySqlPass = "";
            this.CompanySqlUser = "";
            this.CompanyName = "";
            this.ErpFirmNo = "";
            this.ErpPeriodeNo = "";
            this.CompanyServer = "";

            this.ExpCompanyNo = "";
            this.ExpCompanyDB = "";
            this.ExpCompanySqlPass = "";
            this.ExpCompanySqlUser = "";
            this.ExpCompanyName = "";
            this.ExpErpFirmNo = "";
            this.ExpErpPeriodeNo = "";
            this.ExpCompanyServer = "";
        }
    }
}
