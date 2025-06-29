using DevExpress.CodeParser;
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

namespace marketautomation.watier
{
    public partial class frmWaiterLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmWaiterLogin()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        NewEmployee Myemployee = new NewEmployee();
        int userExisting;
        int userStating;

        private void frmWaiterLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtUserName.Text != null && txtUserName.Text != "") && (txtUserPassword.Text != null && txtUserPassword.Text != ""))
                {

                    userExisting = int.Parse(dbm.ExecuteScalar("select COUNT(Ref) from NewEmployee where UserStatus = 2 and  UserName='" + txtUserName.Text + "' and UserPassword='" + txtUserPassword.Text + "' ", CommandType.Text).ToString());
                    userStating = int.Parse(dbm.ExecuteScalar("Select COUNT(Ref) From NewEmployee where IsPassive='True' and UserStatus= 2 and UserName='" + txtUserName.Text + "' and UserPassword='" + txtUserPassword.Text + "'", CommandType.Text).ToString());
                    if (userExisting == 1)
                    {
                        if (userStating == 1)
                        {
                            frmTablesPanel frmwat = new frmTablesPanel();
                            frmwat.Show();
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
                    XtraMessageBox.Show("Lütfen Tüm Alanları doldurunuz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("", ex.ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmFirstLogin frmFirstLogin = new frmFirstLogin();
            this.Hide();
            frmFirstLogin.Show();

        }
    }
}
