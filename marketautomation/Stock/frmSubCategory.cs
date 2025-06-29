using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.PrgClass.MRP.StockClasses;
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

namespace marketautomation.Stock
{
    public partial class frmSubCategory : DevExpress.XtraEditors.XtraForm
    {
        public frmSubCategory()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<SubCategory> sub = new BindingList<SubCategory>();
        void filled()
        {
            ledSub.Properties.DataSource = dbm.ExecuteDataTable("Select * From Category ", CommandType.Text);
        }
        void FillGrid()
        {

            sub = mng.GetObjectList<SubCategory>(" CategoryRef = '" + Guid.Parse(ledSub.EditValue.ToString()) + "'", "");
            dgwSub.DataSource = sub;
        }

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (ledSub.EditValue == null)
                stb.AppendLine("Bölge belirtmelisiniz...");

            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveControl())
                {
                    mng = new ObjectManager(true, "erpConnStr");
                    grdSub.FocusedRowHandle = -1;

                    foreach (SubCategory item in sub)
                    {
                        if (item.CardName != "")
                        {
                            item.CategoryRef = Guid.Parse(ledSub.EditValue.ToString());
                            mng.SaveObject<SubCategory>(item);

                        }
                    }
                    mng.Commit();

                    XtraMessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void frmSubCategory_Load(object sender, EventArgs e)
        {
            filled();
        }

        private void grdCategory_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (grdSub.RowCount > 0)
                {
                    if (grdSub.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from SalonTables where Ref = '" + grdSub.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<SalonTables>(Guid.Parse(grdSub.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdSub.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdSub.DeleteSelectedRows();
                                }
                                XtraMessageBox.Show("Satır Başarıyla Silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void ledSub_EditValueChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}