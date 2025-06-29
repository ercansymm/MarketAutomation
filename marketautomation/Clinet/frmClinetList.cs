using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
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

namespace marketautomation.Clinet
{
    public partial class frmClinetList : DevExpress.XtraEditors.XtraForm
    {
        public frmClinetList()
        {
            InitializeComponent();
        }

        DbManager dbm = new DbManager(false, "erpConnStr");

        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwClient.DataSource = dbm.ExecuteDataTable("Select * From Clinet where IsPassive = 'True' ", CommandType.Text);

            }
            else
            {
                dgwClient.DataSource = dbm.ExecuteDataTable("Select * From Clinet where IsPassive = 'False' ", CommandType.Text);
            }
        }

        private void frmClinetList_Load(object sender, EventArgs e)
        {

            fillGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmClientCard frmClientCard = new frmClientCard();

            if (Application.OpenForms["frmStockCard"] == null)
            {
                frmClientCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
                frmClientCard.ShowDialog();
                fillGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmClientCard frmClientCard = new frmClientCard();
            if (Application.OpenForms["frmClientCard"] == null)
            {
                frmClientCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                if (dgwClient.DataSource != null)
                {
                    frmClientCard.ClinetRef = Guid.Parse(grdClient.GetFocusedRowCellValue(clmRef).ToString());
                    frmClientCard.ShowDialog();
                    fillGrid();
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Öncelikle Bir Tedarikçi Seçiniz");
                }

            }
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
               
        }
    }
}