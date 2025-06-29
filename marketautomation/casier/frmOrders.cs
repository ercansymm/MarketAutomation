using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.Provider;
using marketautomation.Other;
using marketautomation.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GladiusObjex.Tool;
using marketautomation.watier;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using Utilities.BunifuGradientPanel.Transitions;
using DevExpress.XtraReports.Design;
using Bunifu.Framework.UI;
using DevExpress.XtraTab;
using static DevExpress.XtraReports.Design.XtraTabControl;
using System.IO;
using DevExpress.XtraBars.Ribbon.Customization.UI;
using DevExpress.XtraExport.Implementation;
using Bunifu.UI.WinForms;
using DevExpress.XtraCharts;
using DevExpress.Utils.Drawing;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;


namespace marketautomation.casier
{
    public partial class frmOrders : DevExpress.XtraEditors.XtraForm
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        public Sales mySales = new Sales();
        Product myProduct = new Product();
        Category category = new Category();
        BindingList<SubCategory> mySub = new BindingList<SubCategory>();
        BindingList<Product> myProductList = new BindingList<Product>();
        BindingList<Product> myProductCategoryList = new BindingList<Product>();
        int Picureeditlocaionx;
        int Picureeditlocationy;
        public static GladiusEnum.enmFormMod ScreenEnum { get; private set; }
        void CreaatTabPage()
        {
            mng = new ObjectManager(true, "erpConnStr");
            BindingList<Category> myCategory = new BindingList<Category>();
            BindingList<SubCategory> mySub = new BindingList<SubCategory>();
            myCategory = mng.GetObjectList<Category>("", "CardName");
            mySub = mng.GetObjectList<SubCategory>("", "CardName");

            foreach (Category item in myCategory)
            {
                // Ana kategori sekmesini oluştur
                DevExpress.XtraTab.XtraTabPage mainTabPage = new DevExpress.XtraTab.XtraTabPage
                {
                    Text = item.CardName
                };

                //// Sekme başlığının ve sayfa arka plan rengini ayarla
                //mainTabPage.Appearance.Header.BackColor = Color.FromArgb(85, 38, 130);
                //mainTabPage.Appearance.Header.ForeColor = Color.FromArgb(255, 107, 107);
                //mainTabPage.Appearance.PageClient.BackColor = Color.FromArgb(255, 107, 107);

                mainTabPage.Appearance.Header.BackColor = Color.FromArgb(62, 11, 75);
                mainTabPage.Appearance.Header.ForeColor = Color.FromArgb(33,9,65);
                mainTabPage.Appearance.PageClient.BackColor = Color.FromArgb(62, 11, 75);


                DevExpress.XtraTab.XtraTabControl subTabControl = new DevExpress.XtraTab.XtraTabControl
                {
                    Dock = DockStyle.Fill
                };
                mainTabPage.Controls.Add(subTabControl);

                // Alt kategorileri getir ve sekmelerini oluştur
                BindingList<SubCategory> subCategories = mng.GetObjectList<SubCategory>($"CategoryRef = '{item.Ref}'", "CardName");

                foreach (SubCategory subCategory in subCategories)
                {
                    DevExpress.XtraTab.XtraTabPage subTabPage = new DevExpress.XtraTab.XtraTabPage
                    {
                        Text = subCategory.CardName
                    };

                    // Alt sekme başlığı ve sayfa arka plan rengini ayarla
                    subTabPage.Appearance.Header.BackColor = Color.FromArgb(62, 11, 75);
                    subTabPage.Appearance.Header.ForeColor = Color.FromArgb(33,9,65);
                    subTabPage.Appearance.PageClient.BackColor = Color.FromArgb(62, 11, 75);

                    PanelControl panel = new PanelControl
                    {
                        Dock = DockStyle.Fill
                    };
                    subTabPage.Controls.Add(panel);

                    // Alt kategoriye ait ürünleri getir
                    myProductList = mng.GetObjectList<Product>($"SubCategoryRef = '{subCategory.Ref}' AND IsPassive = 'True'", "");

                    int pictureEditLocationX = 10;
                    int pictureEditLocationY = 10;
                    int pictureWidth = 200;
                    int pictureHeight = 200;
                    int spacing = 20;
                    int panelMaxWidth = 882;

                    foreach (Product product in myProductList)
                    {
                        if (product.Image != null && product.Image.Length > 0)
                        {
                            MemoryStream ms = new MemoryStream(product.Image);

                            // PictureEdit ve Label oluştur
                            PictureEdit picture = new PictureEdit
                            {
                                Tag = product.Ref.ToString(),
                                Size = new Size(pictureWidth, pictureHeight),
                                Location = new Point(pictureEditLocationX, pictureEditLocationY),
                                Image = Image.FromStream(ms),
                                Properties = { SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch }
                            };

                            picture.Click += new EventHandler(Picture_Click);

                            BunifuLabel label = new BunifuLabel
                            {
                                ForeColor = Color.Black,
                                Text = product.CardName,
                                Size = new Size(100, 30),
                                Location = new Point(pictureEditLocationX + (picture.Width - 100) / 2, pictureEditLocationY + pictureHeight + 5)
                            };

                            panel.Controls.Add(picture);
                            panel.Controls.Add(label);

                            pictureEditLocationX += pictureWidth + spacing;
                            if (pictureEditLocationX + pictureWidth > panelMaxWidth)
                            {
                                pictureEditLocationX = 10;
                                pictureEditLocationY += pictureHeight + spacing;
                            }
                        }
                    }
                    subTabControl.TabPages.Add(subTabPage);
                }
                xtraTabControl1.TabPages.Add(mainTabPage);
            }
        }




        private void Picture_Click(object sender, EventArgs e)
        {
            // Tıklanan PictureEdit kontrolünü elde et
            PictureEdit clickedPicture = sender as PictureEdit;

            if (clickedPicture != null && clickedPicture.Tag != null)
            {
                // Tag değerini kullanarak gerekli işlemleri yap
                fillGrid(Guid.Parse(clickedPicture.Tag.ToString()));

                moneyTotal();
            }

        }
        public void moneyTotal()
        {
            decimal total = Convert.ToDecimal(grdPrice.Columns["UnitTotalPrice"].SummaryItem.SummaryValue);
            txtMoneyTotal.Text = total.ToString("C");
        }
        void Del()
        {
            if (grdPrice.DataSource is BindingList<SalesDetails> bindingList)
            {
                bindingList.Clear();
            }
            else if (grdPrice.DataSource is DataTable dataTable)
            {
                dataTable.Clear();
            }
            txtMoneyTotal.Text = "0,00";
        }

        void fillGrid(Guid productRef)
        {

            if (Application.OpenForms["frmNumber"] == null)  //frm number var mı yok mu onu kontrol ettim
            {
                frmNumber frmNumber = new frmNumber();
                frmNumber.ShowDialog();

                if (frmNumber.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        myProduct = mng.GetObject<Product>(productRef);
                        if (grdPrice.RowCount < 1)
                        {
                            SalesDetails salesDet = new SalesDetails();
                            salesDet.StockRef = myProduct.Ref;
                            salesDet.Amount = frmNumber.amount;
                            salesDet.SalesRef = mySales.Ref;
                            salesDet.UnitRef = frmNumber.unitRef;
                            salesDet.UnitPrice = myProduct.CardPrice;
                            salesDet.UnitTotalPrice = salesDet.Amount * salesDet.UnitPrice;
                            mySales.Details.Add(salesDet);
                            dgwDetails.DataSource = mySales.Details;
                            dgwDetails.RefreshDataSource();
                        }
                        else
                        {
                            foreach (SalesDetails item in mySales.Details)
                            {
                                int isOk = mySales.Details.Where(x => x.StockRef == myProduct.Ref).Count();
                                if (isOk > 0)
                                {
                                    if (myProduct.Ref == item.StockRef)
                                    {
                                        item.Amount = item.Amount + frmNumber.amount;
                                        break;
                                    }
                                }
                                else
                                {
                                    SalesDetails salesDet = new SalesDetails();
                                    salesDet.StockRef = myProduct.Ref;
                                    salesDet.Amount = frmNumber.amount;
                                    salesDet.SalesRef = mySales.Ref;
                                    salesDet.UnitRef = frmNumber.unitRef;
                                    salesDet.UnitPrice = myProduct.CardPrice;
                                    salesDet.UnitTotalPrice = salesDet.Amount * salesDet.UnitPrice;

                                    mySales.Details.Add(salesDet);
                                    break;
                                }
                            }
                            dgwDetails.DataSource = mySales.Details;
                            dgwDetails.RefreshDataSource();

                        }

                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show(ex.Message);
                    }

                }

            }
        }


        void fillSale()
        {
            mySales.SalesNo = 1;
            mySales.SalesDate = DateTime.Now;
            mySales.EmployeeRef = Guid.Parse("56c16c94-a1de-4e8e-add9-f651ff3c2e71");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Del();
            moneyTotal();
        }
        private void btnPayed_Click(object sender, EventArgs e)
        {
            if (grdPrice.DataSource != null)
            {
                if (mySales.Details.Count > 0)
                {
                    if (Application.OpenForms["frmCostumerPays"] == null)
                    {
                        frmCostumerPays frmcos = new frmCostumerPays();
                        frmcos.mySales = mySales;
                        frmcos.ShowDialog();
                        
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Ürün Seçiniz.");
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Ürün Seçiniz.");
            }
        }
        private void btnTabelGo_Click(object sender, EventArgs e)
        {
            frmTablesPanel frm = new frmTablesPanel();
            frm.FormClosed += (s, args) => this.Close(); // frmOrders kapanınca mevcut form kapanacak
            frm.Show();
            this.Hide();

        }


        private void dgwDetails_DoubleClick(object sender, EventArgs e)
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
                        foreach (SalesDetails item in mySales.Details)
                        {
                            if (item.Ref == lineRef)
                            {
                                item.Amount = frmNum.amount;
                                item.UnitRef = frmNum.unitRef;
                                break;
                            }
                        }
                        dgwDetails.DataSource = mySales.Details;
                        dgwDetails.RefreshDataSource();
                        moneyTotal();
                    }
                }
            }
        }

        private void btnCellDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = grdPrice.FocusedRowHandle;
            if (selectedRow >= 0)
            {
                decimal clmTotalValue = Convert.ToDecimal(grdPrice.GetRowCellValue(selectedRow, "clmTotal"));
                grdPrice.DeleteRow(selectedRow);
                moneyTotal();
            }
            else
            {
                XtraMessageBox.Show("Silinecek Bir Satır Seçilmedi!");
                return;
            }


        }

        private void txtBarcode_TextChange(object sender, EventArgs e)
        {
            int barcode;
            if (txtBarcode.Text != "")
            {
                barcode = int.Parse(dbm.ExecuteScalar("Select COUNT(Ref) from Product where Barcode = '" + txtBarcode.Text + "'", CommandType.Text).ToString());
                if (barcode != 0)
                {
                    myProduct = mng.GetObject<Product>("Barcode ='" + txtBarcode.Text + "'");
                    fillGrid(myProduct.Ref);
                    moneyTotal();
                }
                else
                {
                    XtraMessageBox.Show("Böyle Bir Ürün Bulunamadı");

                }
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            riledUnit.DataSource = dbm.ExecuteDataTable("Select Ref UnitCardRef,CardName From UnitCard", CommandType.Text);
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Product", CommandType.Text);
            dgwDetails.DataSource = mySales.Details;
            moneyTotal();
            CreaatTabPage();
      
        }
    }
}
