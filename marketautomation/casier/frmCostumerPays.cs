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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.casier
{
    public partial class frmCostumerPays : DevExpress.XtraEditors.XtraForm
    {
        public frmCostumerPays()
        {
            InitializeComponent();

        }
        public Sales mySales = new Sales();
        public CaseTransactions myCaseTrans = new CaseTransactions();
        public BindingList<SalesDetails> mySalesDetails = new BindingList<SalesDetails>();
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        string quantity = "";

        void Write(string value)
        {
            quantity = quantity + value;
            txtCostumer.Text = quantity;
        }

        public void fillgrid()
        {
            decimal totalValue = 0;
            foreach (SalesDetails item in mySales.Details)
            {
                item.TotalAmount = item.Amount - item.CoveredAmount;
                item.TotalPrice = item.TotalAmount * item.UnitPrice;
                totalValue += item.TotalPrice;
            }
            dgwDetails.DataSource = mySales.Details;
            txtTotal.Text = totalValue.ToString("F2");
        }

        private void frmCostumerPays_Load(object sender, EventArgs e)
        {
            decimal totalValue = 0;
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Product", CommandType.Text);
            foreach (SalesDetails item in mySales.Details)
            {
                item.TotalAmount = item.Amount - item.CoveredAmount;
                item.TotalPrice = item.TotalAmount * item.UnitPrice;
                totalValue += item.TotalPrice;
            }
            dgwDetails.DataSource = mySales.Details;
            txtTotal.Text = totalValue.ToString("F2");
            txtTotal.ReadOnly = true;

            // Border colors
            txtTotal.BorderColorActive = Color.FromArgb(33, 9, 65);
            txtTotal.BorderColorHover = Color.FromArgb(33, 9, 65);
            txtTotal.BorderColorIdle = Color.FromArgb(33, 9, 65);
            txtTotal.BorderColorDisabled = Color.Silver;

            // Fill color
            txtTotal.FillColor = Color.FromArgb(33, 9, 65);

            // Foreground colors
            txtTotal.ForeColor = Color.White;
            txtTotal.PlaceholderForeColor = Color.White;


        }





        //1 ler 2 ler 3 ler buranın altında ki kodlarla yazılıyor

        private void btn1_Click(object sender, EventArgs e)
        {
            Write(btn1.ButtonText);
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            Write(btn2.ButtonText);
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            Write(btn3.ButtonText);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Write(btn4.ButtonText);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Write(btn5.ButtonText);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Write(btn6.ButtonText);
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            Write(btn7.ButtonText);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Write(btn8.ButtonText);
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            Write(btn9.ButtonText);
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCostumer.Text))
            {
                txtCostumer.Text = txtTotal.Text.Remove(txtCostumer.Text.Length - 1);
                quantity = txtCostumer.Text;
            }
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (grdPrice.DataSource != null)
            {
                if (grdPrice.DataSource is BindingList<SalesDetails> bindingList && bindingList.Count > 0)
                {
                    // doluysa
                    frmOrders frmOrders = new frmOrders();

                    if (Application.OpenForms["frmOrders"] != null)
                    {
                        frmOrders.mySales = mySales;
                        frmOrders.Show();
                        this.Close();
                    }
                }
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCostumer.Text != "")
                {
                    decimal num1, num2, conclusion;
                    string total = txtTotal.Text;
                    num1 = decimal.Parse(total);
                    num2 = decimal.Parse(txtCostumer.Text);
                    conclusion = num2 - num1;
                    txtChange.Text = conclusion.ToString("F2");

                    if (num2 >= decimal.Parse(total))
                    {
                        mng = new ObjectManager(true, "erpConnStr");

                        mng.SaveObject<Sales>(mySales);

                        foreach (SalesDetails item in mySales.Details)
                        {
                            item.SalesRef = mySales.Ref;
                            mng.SaveObject<SalesDetails>(item);

                            StockLines myLines = new StockLines
                            {
                                LinelO = 1,
                                StockRef = item.StockRef,
                                StockFicheRef = mySales.Ref,
                                StockFishDetailRef = item.Ref,
                                Amount = item.Amount,
                                UnitRef = item.UnitRef,
                                FicheDate = mySales.SalesDate
                            };
                            mng.SaveObject<StockLines>(myLines);
                        }

                        myCaseTrans.CaseType = 0;
                        myCaseTrans.Date_ = DateTime.Now;
                        myCaseTrans.LinelO = 0;
                        myCaseTrans.Total = decimal.Parse(total);

                        mng.SaveObject<CaseTransactions>(myCaseTrans);
                        mng.Commit();

                        DialogResult result = XtraMessageBox.Show("Ödeme İşlemi Tamamlanmıştır" + " " + "Para Üstü" + " " + conclusion + " " + "₺");

                        // Orders formunu yeniden başlat
                        Application.OpenForms["frmOrders"]?.Close();
                        frmOrders newOrders = new frmOrders();   
                        newOrders.Show();                       

                        this.Close(); 
                    }
                    else
                    {
                        XtraMessageBox.Show("Eksik Ödeme Aldınız");
                        return;
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

            try
            {
                foreach (SalesDetails item in mySales.Details)
                {
                    item.SalesRef = mySales.Ref;
                    item.UnitTotalPrice = myCaseTrans.Total;

                    mng.SaveObject<SalesDetails>(item);

                    StockLines myLines = new StockLines();

                    myLines.LinelO = 1;
                    myLines.StockRef = item.StockRef;
                    myLines.StockFicheRef = mySales.Ref;
                    myLines.StockFishDetailRef = item.Ref;
                    myLines.Amount = item.Amount;
                    myLines.UnitRef = item.UnitRef;
                    myLines.FicheDate = mySales.SalesDate;

                    mng.SaveObject<StockLines>(myLines);
                }


                decimal total = Convert.ToDecimal(grdPrice.Columns["UnitTotalPrice"].SummaryItem.SummaryValue);


                myCaseTrans.CaseType = 1;
                myCaseTrans.Date_ = DateTime.Now;
                myCaseTrans.LinelO = 0;
                myCaseTrans.Total = total;

                mng = new ObjectManager(true, "erpConnStr");
                mng.SaveObject<CaseTransactions>(myCaseTrans);
                mng.Commit();
                XtraMessageBox.Show("Ödemeye Pos Cihanızdan devam ediniz" + txtTotal.Text + " " + "₺");


                // Orders formunu yeniden başlat
                Application.OpenForms["frmOrders"]?.Close();
                frmOrders newOrders = new frmOrders();
                newOrders.Show();

                this.Close();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (SalesDetails item in mySales.Details)
                {
                    item.SalesRef = mySales.Ref;
                    item.UnitTotalPrice = myCaseTrans.Total;
                    mng.SaveObject<SalesDetails>(item);

                    StockLines myLines = new StockLines();

                    myLines.LinelO = 1;
                    myLines.StockRef = item.StockRef;
                    myLines.StockFicheRef = mySales.Ref;
                    myLines.StockFishDetailRef = item.Ref;
                    myLines.Amount = item.Amount;
                    myLines.UnitRef = item.UnitRef;
                    myLines.FicheDate = mySales.SalesDate;

                    mng.SaveObject<StockLines>(myLines);
                }

                decimal total = Convert.ToDecimal(grdPrice.Columns["UnitTotalPrice"].SummaryItem.SummaryValue);

                myCaseTrans.CaseType = 2;
                myCaseTrans.Date_ = DateTime.Now;
                myCaseTrans.LinelO = 0;
                myCaseTrans.Total = total;

                mng = new ObjectManager(true, "erpConnStr");
                mng.SaveObject<CaseTransactions>(myCaseTrans);
                mng.Commit();
                XtraMessageBox.Show("Ödemeye Pos Cihanızdan devam ediniz" + txtTotal.Text + " " + "₺");


                // Orders formunu yeniden başlat
                Application.OpenForms["frmOrders"]?.Close();
                frmOrders newOrders = new frmOrders();
                newOrders.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            if (grdPrice.RowCount > 0)
            {
                frmCraced frmcrac = new frmCraced();
                if (Application.OpenForms["frmCraced"] == null)
                {
                    frmcrac.mySales = mySales;
                    frmcrac.ShowDialog();

                    if (frmcrac.DialogResult == DialogResult.OK)
                    {
                        mySales = mySales.getSales(mySales.Ref);
                        fillgrid();
                    }

                }
            }
            else
            {
                XtraMessageBox.Show("Hata");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Write(btnDot.ButtonText);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCostumer.Text))
            {
                txtCostumer.Text = txtCostumer.Text.Remove(txtCostumer.Text.Length - 1);
                quantity = txtCostumer.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Write(btn0.ButtonText);
        }
    }
}



