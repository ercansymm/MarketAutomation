using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.PrgClass.MRP.ProductionClasses;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
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
    public partial class frmStockFiche : DevExpress.XtraEditors.XtraForm
    {
        public frmStockFiche()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        StockReceipt myReceipt = new StockReceipt();
        BindingList<NewClinet> myClinet = new BindingList<NewClinet>();
        public Guid Ref;
        public string DocType;
      
        void fillriled()
        {
            riledCardName.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName from Product ", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName from UnitCard", CommandType.Text);
            ledClient.Properties.DataSource = dbm.ExecuteDataTable("Select * From Clinet", CommandType.Text);
        }
        void fillGrid()
        {
            dgwFiche.DataSource = myReceipt.Details;
        }
        void fillText()
        {
            txtFicheNo.Text = myReceipt.FishNo;
            dateFicheDate.DateTime = myReceipt.FishDate;
            rchDecription.Text = myReceipt.Description;
            ledClient.EditValue = myReceipt.ClinetRef;
        }

        private void frmStcokFishe_Load(object sender, EventArgs e)
        {
            fillriled();

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myReceipt = new StockReceipt();
                    string code;

                    if (int.Parse(dbm.ExecuteScalar("select count(FishNo) from StockReceipt", CommandType.Text).ToString()) > 0)
                    {
                        code = dbm.ExecuteScalar("select top 1 FishNo from StockReceipt order by FishNo desc", CommandType.Text).ToString();
                    }
                    else
                    {
                        code = "";
                    }
                    txtFicheNo.Text = StringProc.Increment(code, true);

                    break;

                case GladiusEnum.enmFormMod.UPDATE:
                    myReceipt = myReceipt.getFiche(Ref);
                    fillText();
                    break;
                default:
                    break;
            }


            fillGrid();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");

            try
            {
                myReceipt.FishNo = txtFicheNo.Text;
                myReceipt.Description = rchDecription.Text;
                myReceipt.FishDate = dateFicheDate.DateTime;
                myReceipt.DocType = DocType;
                if (ledClient.EditValue != null)
                {
                    myReceipt.ClinetRef = Guid.Parse(ledClient.EditValue.ToString());

                }
                else
                {
                    XtraMessageBox.Show("Lütfen Cari Seçiniz.");
                    return;
                }
                mng.SaveObject<StockReceipt>(myReceipt);

                foreach (StockReceiptDetail item in myReceipt.Details)
                {
                    if (DocType == "GRS")
                    {
                        item.LineIO = 0;

                    }
                    if (DocType == "CKS")
                    {
                        item.LineIO = 1;
                    }

                    item.StockFishRef = myReceipt.Ref;
                    mng.SaveObject<StockReceiptDetail>(item);
                }

                mng.Commit();
                XtraMessageBox.Show("Kayıt Başarılı");
                this.Close();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Hata"+ex);
            }
        }


    }
}