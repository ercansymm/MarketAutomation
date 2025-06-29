using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Provider;
using marketautomation.Other;
using marketautomation.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marketautomation.Employee;
using GladiusObjex.Tool;
using DevExpress.XtraRichEdit.Services;
using DevExpress.ExpressApp.Model;



namespace marketautomation.Employee
{
    public partial class FrmUsers : DevExpress.XtraEditors.XtraForm
    {

        public FrmUsers()
        {
            InitializeComponent();
        }

        DbManager dbm = new DbManager(false, "erpConnStr");
        NewEmployee myEmployee = new NewEmployee();

        void fillgrid()
        {
            if (tglsActive.IsOn == true)
            {
                dgwUserkList.DataSource = dbm.ExecuteDataTable("select * from NewEmployee where IsPassive='True'", CommandType.Text);
            }
            else
            {
                dgwUserkList.DataSource = dbm.ExecuteDataTable("select * from NewEmployee where Ispassive='False'", CommandType.Text);
            }
        }
        public void fillLokup()
        {
            riledPersonelType.DataSource = dbm.ExecuteDataTable(@"select '0' State, 'Yönetici' StateName
            union ALL 
            select '1','Kasiyer'
            union ALL 
            select '2','Garson'", CommandType.Text);
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            fillLokup();
            fillgrid();
            tglsActive.IsOn = true;
        }
        private void btnSaved_Click(object sender, EventArgs e)
        {
            frnUsersCard frmusers = new frnUsersCard();

            if (Application.OpenForms["frmUsersCard"] == null)
            {
                frmusers.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
                frmusers.ShowDialog();

                fillgrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            frnUsersCard frmuserss = new frnUsersCard();

            if (Application.OpenForms["frmUsersCard"] == null)
            {
                frmuserss.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                frmuserss.Ref = Guid.Parse(grdUserList.GetFocusedRowCellValue(usrRef).ToString());
                frmuserss.ShowDialog();
                fillgrid();
            }
        }

        private void dgwUserkList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            frnUsersCard frmuserss = new frnUsersCard();

            if (Application.OpenForms["frmUsersCard"] == null)
            {
                frmuserss.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                frmuserss.Ref = Guid.Parse(grdUserList.GetFocusedRowCellValue(usrRef).ToString());
                frmuserss.ShowDialog();
                fillgrid();
            }
        }

        private void tglsActive_Toggled(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}