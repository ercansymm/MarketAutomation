using Bunifu.Framework.UI;
using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Provider;
using marketautomation.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.casier
{
    public partial class frmCasierLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmCasierLogin()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        NewEmployee Myemployee = new NewEmployee();
        int userExisting;
        int userStating;
        private void frmCasierLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUserName.Text != null && txtUserName.Text != "") && (txtPassword.Text != null && txtPassword.Text != ""))
                {
                    userExisting = int.Parse(dbm.ExecuteScalar("select COUNT(Ref) from NewEmployee where UserStatus = 1 and UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "' ", CommandType.Text).ToString());
                    userStating = int.Parse(dbm.ExecuteScalar("select COUNT(Ref) from NewEmployee where IsPassive='True'and UserStatus = 1 and UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "' ", CommandType.Text).ToString());
                    if (userExisting == 1)
                    {
                        if (userStating == 1)
                        {
                            frmOrders frmor = new frmOrders();
                            frmor.Show();
                            this.Hide();
                        }
                        else
                        {
                            XtraMessageBox.Show("Kullanıcı Pasif Durumda Lütfen Yöneticiniz İle İrtibata Geçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen Kullanıcı Adı Veya Şifrenizi Kontrol Ediniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Tüm Alanları doldurunuz");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("", ex.ToString());
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmFirstLogin frmFirst = new frmFirstLogin();
            this.Hide();
            frmFirst.Show();
            
        }
    }
}
