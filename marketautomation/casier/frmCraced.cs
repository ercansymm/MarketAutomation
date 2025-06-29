using DevExpress.CodeParser;
using DevExpress.Pdf.ContentGeneration;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UserDesigner;
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

namespace marketautomation.casier
{
    public partial class frmCraced : DevExpress.XtraEditors.XtraForm
    {

        public frmCraced()
        {
            InitializeComponent();
        }
        public Sales mySales = new Sales();
        public CaseTransactions myCaseTrans = new CaseTransactions();
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        decimal generalTotal;
        decimal change;
        decimal num1, num2;
        void fillgrid()
        {

            foreach (SalesDetails item in mySales.Details)
            {
                if (item.CoveredPrice != 0)
                {
                    item.UnitPrice = (item.UnitTotalPrice / item.Amount);

                }
                item.TotalAmount = item.Amount - item.CoveredAmount;
                item.TotalPrice = item.TotalAmount * item.UnitPrice;
            }
            dgwDetails.DataSource = mySales.Details;
        }
        
        
        private void frmCraced_Load(object sender, EventArgs e)
        {

            fillgrid();
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Product", CommandType.Text);
            riletUnit.DataSource = dbm.ExecuteDataTable("Select Ref UnitCardRef,CardName From UnitCard", CommandType.Text);
            //filltotal();
            decimal chaked = decimal.Parse(grdPrice.GetFocusedRowCellValue(clmTotal).ToString());

            if (chaked == 0)
            {
                this.Close();
                frmOrders frmor = new frmOrders();
                frmor.Show();

            }

        }


        private void btnCash_Click(object sender, EventArgs e)
        {
            txtTotal.Text = num1.ToString();
            txtChange.Text = num2.ToString();


            try
            {
                if (txtChange.Text != "" || txtChange.Text != null)
                {

                    if (num1 == num2 || num1 > num2)
                    {
                        mng = new ObjectManager(true, "erpConnStr");

                        decimal totalValue = 0;
                        foreach (SalesDetails item in mySales.Details)
                        {
                            item.SalesRef = mySales.Ref;
                            item.CoveredPrice = item.CoveredPrice + decimal.Parse(txtChange.Text);
                            totalValue += item.TotalPrice;
                            mng.SaveObject<SalesDetails>(item);
                            ////
                            StockLines myLines = new StockLines();
                            myLines.LinelO = 1;
                            myLines.StockRef = item.StockRef;
                            myLines.StockFicheRef = mySales.Ref;
                            myLines.StockFishDetailRef = item.Ref;
                            myLines.Amount = item.CoveredAmount;
                            myLines.UnitRef = item.UnitRef;
                            myLines.FicheDate = mySales.SalesDate;
                            mng.SaveObject<StockLines>(myLines);
                        }

                        myCaseTrans.CaseType = 0;
                        myCaseTrans.Date_ = DateTime.Now;
                        myCaseTrans.LinelO = 0;
                        myCaseTrans.Total = generalTotal;

                        mng.SaveObject<CaseTransactions>(myCaseTrans);
                        mng.Commit();
                        mng = new ObjectManager(true, "erpConnStr");

                        XtraMessageBox.Show("Ödeme İşlemi Tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen Eksik ödeme Almayınız", "Dikkat");
                    }

                }
                else
                {
                    XtraMessageBox.Show("Ödeme giriniz");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            txtTotal.Text = num1.ToString();
            txtChange.Text = num2.ToString();


            try
            {

                if (num1 == num2)
                {

                    mng = new ObjectManager(true, "erpConnStr");


                    foreach (SalesDetails item in mySales.Details)
                    {
                        item.SalesRef = mySales.Ref;
                        item.CoveredPrice = item.CoveredPrice + decimal.Parse(txtChange.Text);
                        mng.SaveObject<SalesDetails>(item);

                        StockLines myLines = new StockLines();

                        myLines.LinelO = 1;
                        myLines.StockRef = item.StockRef;
                        myLines.StockFicheRef = mySales.Ref;
                        myLines.StockFishDetailRef = item.Ref;
                        myLines.Amount = item.CoveredAmount;
                        myLines.UnitRef = item.UnitRef;
                        myLines.FicheDate = mySales.SalesDate;
                        mng.SaveObject<StockLines>(myLines);
                    }
                    myCaseTrans.CaseType = 1;
                    myCaseTrans.Date_ = DateTime.Now;
                    myCaseTrans.LinelO = 0;
                    myCaseTrans.Total = generalTotal;

                    mng.SaveObject<CaseTransactions>(myCaseTrans);
                    mng.Commit();

                    decimal chaked = Convert.ToDecimal(grdPrice.Columns["TotalPrice"].SummaryItem.SummaryValue);
                    if (chaked == 0)
                    {
                        DialogResult result = XtraMessageBox.Show("Ödeme İşlemi Tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }



                }

                else
                {
                    XtraMessageBox.Show("Lütfen Eksik Ödeme Almayınız");
                }
                fillgrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            txtTotal.Text = num1.ToString();
            txtChange.Text = num2.ToString();
            try
            {

                if (num1 == num2)
                {

                    mng = new ObjectManager(true, "erpConnStr");


                    foreach (SalesDetails item in mySales.Details)
                    {
                        item.SalesRef = mySales.Ref;
                        item.CoveredPrice = item.CoveredPrice + decimal.Parse(txtChange.Text);
                        mng.SaveObject<SalesDetails>(item);

                        StockLines myLines = new StockLines();

                        myLines.LinelO = 1;
                        myLines.StockRef = item.StockRef;
                        myLines.StockFicheRef = mySales.Ref;
                        myLines.StockFishDetailRef = item.Ref;
                        myLines.Amount = item.CoveredAmount;
                        myLines.UnitRef = item.UnitRef;
                        myLines.FicheDate = mySales.SalesDate;
                        mng.SaveObject<StockLines>(myLines);
                    }
                    myCaseTrans.CaseType = 2;
                    myCaseTrans.Date_ = DateTime.Now;
                    myCaseTrans.LinelO = 0;
                    myCaseTrans.Total = generalTotal;

                    mng.SaveObject<CaseTransactions>(myCaseTrans);
                    mng.Commit();
                    XtraMessageBox.Show("Ödeme İşlemi Tamamlanmışıtr");

                }

                else
                {
                    XtraMessageBox.Show("Lütfen Eksik Ödeme Almayınız");
                }
                fillgrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void grdPrice_DoubleClick(object sender, EventArgs e)
        {

            if (grdPrice.RowCount > 0)
            {
                Guid lineRef = Guid.Parse(grdPrice.GetFocusedRowCellValue(clmRef).ToString());

                frmNumber frmNum = new frmNumber();

                if (Application.OpenForms["frmNumber"] == null)
                {
                    frmNum.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                    frmNum.amount = decimal.Parse(grdPrice.GetFocusedRowCellValue(clmAmount).ToString());
                    frmNum.ShowDialog();

                    if (frmNum.DialogResult == DialogResult.OK)
                    {
                        decimal checkedAmount = decimal.Parse(grdPrice.GetFocusedRowCellValue(clmTotalAmount).ToString());
                        if ((checkedAmount - frmNum.amount) >= 0)
                        {
                            foreach (SalesDetails item in mySales.Details)
                            {
                                if (frmNum.amount <= item.Amount)
                                {

                                    if (item.Ref == lineRef)
                                    {
                                        item.CoveredAmount = item.CoveredAmount + frmNum.amount;

                                        item.CoveredPrice = /*item.CoveredPrice +*/ (item.UnitPrice * item.CoveredAmount);

                                        generalTotal += (item.UnitPrice * frmNum.amount);
                                        txtTotal.Text = generalTotal.ToString();

                                        item.TotalAmount = item.Amount - item.CoveredAmount;

                                        item.TotalPrice = item.UnitTotalPrice - item.CoveredPrice;


                                        break;

                                    }

                                }
                            }
                            fillgrid();
                        }
                        else
                        {
                            XtraMessageBox.Show("Ürün 0 Olamaz", "Dikkat", MessageBoxButtons.OK);
                        }


                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void btnCallculeted_Click(object sender, EventArgs e)
        {
            if (txtChange.Text == null || txtChange.Text == "")
            {
                XtraMessageBox.Show("Lütfen Müşteri Ödemesini Girniz");

            }
            else
            {
                change = decimal.Parse(txtChange.Text);
                generalTotal = decimal.Parse(txtTotal.Text);

                foreach (SalesDetails item in mySales.Details)
                {
                    txtSubtotal.Text = (generalTotal - change).ToString();
                }
            }
        }

    }
}