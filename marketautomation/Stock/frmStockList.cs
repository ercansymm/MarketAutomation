using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using marketautomation.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.Stock
{
    public partial class frmStockList : DevExpress.XtraEditors.XtraForm
    {
        public frmStockList()
        {
            InitializeComponent();
        }
        DbManager dbm = new DbManager(false, "erpConnStr");
        Product myProduct = new Product();

        void fillgrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwProduct.DataSource = dbm.ExecuteDataTable("select * from Product where IsPassive='True' ", CommandType.Text);
            }
            else
            {
                dgwProduct.DataSource = dbm.ExecuteDataTable("select * from Product where IsPassive='False'", CommandType.Text);
            }
        }

        private void frmStockListt_Load(object sender, EventArgs e)
        {
            fillgrid();
            riledUnit.DataSource = dbm.ExecuteDataTable("select Ref UnitRef,CardName from UnitCard ", CommandType.Text);
            riledCategory.DataSource = dbm.ExecuteDataTable("Select Ref CategoryRef,CardName From Category ", CommandType.Text);
            riledSub.DataSource = dbm.ExecuteDataTable("Select Ref SubCategoryRef,CardName From SubCategory ", CommandType.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStockCard frmStock = new frmStockCard();

            if (Application.OpenForms["frmStockCard"] == null)
            {
                frmStock.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
                frmStock.ShowDialog();
                fillgrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmStockCard frmStock = new frmStockCard();
            if (Application.OpenForms["frmStockCard"] == null)
            {
                frmStock.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                if (dgwProduct.DataSource != null)
                {
                    frmStock.productRef = Guid.Parse(grdProduct.GetFocusedRowCellValue(grdRef).ToString());
                    frmStock.ShowDialog();
                    fillgrid();
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Öncelikle Bir Ürün Seçiniz");
                }
            }
        }

        private void grdProduct_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}