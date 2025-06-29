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

namespace marketautomation.Tables
{
    public partial class frmTabelArea : DevExpress.XtraEditors.XtraForm
    {
        public frmTabelArea()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<Area> myArea = new BindingList<Area>();

        void fillgrid()
        {
            myArea = mng.GetObjectList<Area>("", "");
            dgwArea.DataSource = myArea;
        }


        private void frmTabelArea_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");
            grdArea.FocusedRowHandle = -1;

            int count = 0;
            bool exceededLimit = false; // Sınır aşımı kontrolü

            try
            {
                foreach (Area item in myArea)
                {
                    if (item.CardName.Trim().Length > 0)
                    {
                        count++;

                        if (count > 7)
                        {
                            XtraMessageBox.Show("7'den fazla kayıt yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            exceededLimit = true; // Sınır aşıldı
                            break; // Döngüden çık
                        }

                        mng.SaveObject<Area>(item);
                    }
                }

                if (!exceededLimit) // Sınır aşılmadıysa işlemi tamamla
                {
                    mng.Commit();
                    XtraMessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                XtraMessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void dgwArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grdArea.RowCount > 0)
                {
                    if (grdArea.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from Area where Ref = '" + grdArea.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<Area>(Guid.Parse(grdArea.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdArea.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdArea.DeleteSelectedRows();
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