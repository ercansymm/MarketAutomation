using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Tool;
using marketautomation.Other;
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

namespace marketautomation.Fiche
{
    public partial class frmStockLines : DevExpress.XtraEditors.XtraForm
    {
        public frmStockLines()
        {
            InitializeComponent();
        }

        DbManager dbm = new DbManager(false, "erpConnStr");
        StockReceiptDetail myRecipt = new StockReceiptDetail();
        BaseList mylist = new BaseList();
        void fillLed()
        {
            ledDocType.Properties.DataSource = mylist.StockType();
        }

        void fillGrid()
        {
            if (ledDocType.EditValue == "GRS")
            {
                dgwStockLine.DataSource = dbm.ExecuteDataTable("Select * From StockReceipt where DocType = 'GRS' order by FishDate asc ", CommandType.Text);
            }
            if (ledDocType.EditValue == "CKS")
            {
                dgwStockLine.DataSource = dbm.ExecuteDataTable("Select * from StockReceipt Where DocType = 'CKS' order by FishDate asc", CommandType.Text);

            }

        }


        private void frmStockLines_Load(object sender, EventArgs e)
        {
            fillLed();

            riledClinetRef.DataSource = dbm.ExecuteDataTable("Select Ref ClinetRef,CardName From Clinet", CommandType.Text);

            ledDocType.EditValue = "GRS";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmStockFiche frmStock = new frmStockFiche();

            if (Application.OpenForms["frmStockFiche"] == null)
            {
                frmStock.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                frmStock.DocType = ledDocType.EditValue.ToString();
                frmStock.Ref = Guid.Parse(grdStockLine.GetFocusedRowCellValue(clmRef).ToString());
                frmStock.ShowDialog();
                fillGrid();
            }
        }

        private void ledDocType_EditValueChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            frmStockFiche frmFish = new frmStockFiche();

            if (Application.OpenForms["frmStockFiche"] == null)
            {
                frmFish.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
                frmFish.DocType = ledDocType.EditValue.ToString();
                frmFish.ShowDialog();
                fillGrid();
            }
        }

        private void grdStockLine_DoubleClick(object sender, EventArgs e)
        {
            frmStockFiche frmStock = new frmStockFiche();

            if (Application.OpenForms["frmStockFiche"] == null)
            {
                frmStock.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                frmStock.DocType = ledDocType.EditValue.ToString();
                frmStock.Ref = Guid.Parse(grdStockLine.GetFocusedRowCellValue(clmRef).ToString());
                frmStock.ShowDialog();
                fillGrid();
            }
        }
    }
}