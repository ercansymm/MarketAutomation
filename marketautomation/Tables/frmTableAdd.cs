using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Provider;
using marketautomation.SpecialClass;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace marketautomation.Tables
{
    public partial class frmTableAdd : DevExpress.XtraEditors.XtraForm
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<SalonTables> myTables = new BindingList<SalonTables>();

        void fillGrid()
        {
            myTables = mng.GetObjectList<SalonTables>("  AreaRef ='" + Guid.Parse(ledArea.EditValue.ToString()) + "'", "TableNo asc");
            dgwTables.DataSource = myTables;
        }
        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (ledArea.EditValue == null)
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
                    grdTables.FocusedRowHandle = -1;

                    try
                    {
                        foreach (SalonTables item in myTables)
                        {
                            if (item.TableNo != "")
                            {
                                item.AreaRef = Guid.Parse(ledArea.EditValue.ToString());
                                mng.SaveObject<SalonTables>(item);

                            }
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


            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private void frmTableAdd_Load(object sender, EventArgs e)
        {
            ledArea.Properties.DataSource = dbm.ExecuteDataTable("SELECT * FROM Area CardName", CommandType.Text);

        }

        private void ledArea_EditValueChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void dgwTables_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (grdTables.RowCount > 0)
                {
                    if (grdTables.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from SalonTables where Ref = '" + grdTables.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<SalonTables>(Guid.Parse(grdTables.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdTables.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdTables.DeleteSelectedRows();
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

        private void frmTableAdd_Load_1(object sender, EventArgs e)
        {

        }
    }

}