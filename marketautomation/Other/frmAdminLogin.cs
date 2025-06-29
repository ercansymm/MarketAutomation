using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.Other
{
    public partial class frmAdminLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        NewEmployee Myemployee = new NewEmployee();
        int userExisting;
        int userStating;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtUserName.Text != null && txtUserName.Text != "") && (txtPassword.Text != null && txtPassword.Text != ""))
                {

                    userExisting = int.Parse(dbm.ExecuteScalar("select COUNT(Ref) from NewEmployee where UserStatus = 0 and UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "' ", CommandType.Text).ToString());
                    userStating = int.Parse(dbm.ExecuteScalar("Select COUNT(Ref) from NewEmployee where IsPassive='True' and UserStatus = 0 and UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "'", CommandType.Text).ToString());


                    if (userExisting == 1)
                    {
                        if (userStating == 1)
                        {

                            frmMain frmMan = new frmMain();
                            frmMan.Show();
                            this.Hide();
                        }
                        else
                        {
                            XtraMessageBox.Show("Kullanıcı Pasif Durumda Lütfen Yöneticiniz İle İrtibata Geçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı");
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
    }
}