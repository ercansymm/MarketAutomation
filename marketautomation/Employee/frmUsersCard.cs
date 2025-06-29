using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Services;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.PrgClass.MRP.EmployeeClasses;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using marketautomation.Employee;
using marketautomation.SpecialClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace marketautomation.Other
{
    public partial class frnUsersCard : DevExpress.XtraEditors.XtraForm
    {
        public frnUsersCard()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        NewEmployee myempp = new NewEmployee();
        public Guid Ref;
        BaseList mylist = new BaseList();

        void fillForm()
        {
            txtCaptionName.Text = myempp.UserName;
            txtUserName.Text = myempp.CardName;
            txtPassword.Text = myempp.UserPassword.ToString();
            txtDescription.Text = myempp.Description;
            tglsActive.IsOn = myempp.IsAdmin;
            rchAddress.Text = myempp.UserAddress;
            mskPhoneNumber.Text = myempp.UserPhone;
            ledStatüs.EditValue = myempp.UserStatus;
            tglsActive.IsOn = myempp.IsPassive;

        }
        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtDescription.Text.Length == 0 || txtDescription.EditValue == null)
                stb.AppendLine("Açıklamayı Boş Geçemezsiniz.");

            if (txtUserName.Text.Length == 0 || txtUserName.EditValue == null)
                stb.AppendLine("Kullaınıcı İsmini Boş Geçemezsini.");

            if (txtPassword.Text.Length == 0 || txtPassword.EditValue == null)
                stb.AppendLine("Parolayı Boş Geçemezsiniz.");

            if (ledStatüs.Text.Length == 0 || ledStatüs.EditValue == null)
                stb.AppendLine("Personel Tipini Boş Geçemezsiniz.");

            if (mskPhoneNumber.Text.Length == 0 || mskPhoneNumber == null)
                stb.AppendLine("Telefon Numarasını Boş Geçemezsiniz.");

            if (rchAddress.Text.Length == 0 || rchAddress == null)
                stb.AppendLine("Adresi Boş Geçemezsiniz.");

            if (ledStatüs.Text.Length == 0 || ledStatüs == null)
                stb.AppendLine("Personel Tipini Boş Geçemezsiniz.");

            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }

        private void frmUsersCard_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            ledStatüs.Properties.DataSource = mylist.EmployeeType();
            ledStatüs.Properties.DropDownRows = mylist.EmployeeType().Count;

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myempp = new NewEmployee();
                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    myempp = myempp.getUsers(Ref);
                    fillForm();
                    break;
                default:
                    break;
            }
        }

        private void btnSaved_Click_1(object sender, EventArgs e)
        {
            if (SaveControl())
            {
                try
                {
                    mng = new ObjectManager(true, "erpConnStr");

                    myempp.CardName = txtUserName.Text;
                    myempp.UserName = txtCaptionName.Text;
                    myempp.UserPassword = txtPassword.Text;
                    myempp.Description = txtDescription.Text;
                    myempp.UserStatus = int.Parse(ledStatüs.EditValue.ToString());

                    myempp.UserPhone = mskPhoneNumber.Text;
                    myempp.UserAddress = rchAddress.Text;
                    myempp.IsAdmin = tglsActive.IsOn;
                    myempp.IsPassive = tglsActive.IsOn;
                    mng.SaveObject<NewEmployee>(myempp);
                    mng.Commit();
                    XtraMessageBox.Show("Personel Kaydınız && Güncelleme İşleminiz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("" + ex, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }




        }

        private void tglsActive_Toggled(object sender, EventArgs e)
        {

        }
    }
}