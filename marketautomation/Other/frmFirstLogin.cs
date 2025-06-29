using DevExpress.XtraEditors;
using marketautomation.casier;
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
    public partial class frmFirstLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmFirstLogin()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminLogin frmAdminLogin = new frmAdminLogin();
            frmAdminLogin.Show();
            
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCassier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCasierLogin frmCasierLogin = new frmCasierLogin();
            frmCasierLogin.Show();
        }
    }
}