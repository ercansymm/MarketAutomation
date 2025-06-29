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

namespace marketautomation
{
    public partial class frmCatagory : DevExpress.XtraEditors.XtraForm
    {
        public frmCatagory()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<Category> myCatagory = new BindingList<Category>();

        void fillgrid()
        {
            myCatagory = mng.GetObjectList<Category>("","");
            dgwCatagory.DataSource= myCatagory;
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");
            grdCategory.FocusedRowHandle = -1;
            try
            {
                foreach (Category item in myCatagory)
                {
                    mng.SaveObject<Category>(item);
             
                }

                mng.Commit();
                XtraMessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void grdCategory_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (grdCategory.RowCount > 0)
                {
                    if (grdCategory.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from Category where Ref = '" + grdCategory.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<Category>(Guid.Parse(grdCategory.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdCategory.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdCategory.DeleteSelectedRows();
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
    }
}