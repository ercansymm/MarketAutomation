using DevExpress.XtraBars;
using GladiusObjex.PrgClass.Market;
using marketautomation.Clinet;
using marketautomation.Employee;
using marketautomation.Fiche;
using marketautomation.Finance;
using marketautomation.Stock;
using marketautomation.Tables;
using marketautomation.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace marketautomation
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmStockList frproduce;
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmStockList"] == null)
            {
                frproduce = new frmStockList();
                frproduce.MdiParent = this;
                frproduce.Show();
            }
        }

        private void btnPersonall_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUsers"] == null)
            {
                FrmUsers frs = new FrmUsers();
                frs.MdiParent = this;
                frs.Show();

            }
        }


        private void btnTables_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTableAdd"] == null)
            {
                frmTableAdd frmTables = new frmTableAdd();

                frmTables.ShowDialog();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTabelArea"] == null)
            {
                frmTabelArea frmTabelArea = new frmTabelArea();
                frmTabelArea.ShowDialog();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategory"] == null)
            {
                frmCatagory frmcass = new frmCatagory();
                frmcass.ShowDialog();
            }
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUnit"] == null)
            {
                frmUnit frmUnit = new frmUnit();
                frmUnit.ShowDialog();
            }
        }


        private void btnStockTracking_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmStockTracking"] == null)
            {
                frmStockTracking frmTracking = new frmStockTracking();
                frmTracking.MdiParent = this;
                frmTracking.Show();
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCaseTransef"] == null)
            {
                frmCaseTransef frmCaseTrans = new frmCaseTransef();
                frmCaseTrans.MdiParent = this;
                frmCaseTrans.Show();
            }
        }

        private void btnFicheRecipte_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmStockLines"]==null)
            {
                frmStockLines frmStockLines = new frmStockLines();
                frmStockLines.MdiParent = this;
                frmStockLines.Show();

            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSubCategory"]==null)
            {
                frmSubCategory frmSub = new frmSubCategory();
                frmSub.Show();
            }
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmClinetList"]==null)
            {
                frmClinetList frmClinet = new frmClinetList();
                frmClinet.MdiParent = this; frmClinet.Show();

            }
        }

        private void accordionControlElement3_Click_1(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
