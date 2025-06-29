using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using DevExpress.Pdf.Native.BouncyCastle.Asn1;
using DevExpress.SpreadsheetSource.Implementation;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.PrgClass.MRP.ProductionClasses;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.Provider;
using marketautomation.casier;
using marketautomation.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.watier
{
    public partial class frmTablesPanel : DevExpress.XtraEditors.XtraForm
    {
        public frmTablesPanel()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        SalonTables myTables = new SalonTables();
        SalesDetails mySalesDetails = new SalesDetails();
        BunifuThinButton2 mybutton = new BunifuThinButton2();

        int CardLocationx = 20;
        int CardLocationy = -5;
        void ExiteButton(Panel panel1)
        {
            mybutton.BackColor = System.Drawing.Color.FromArgb(33,9,65);
            mybutton.ActiveCornerRadius = 50;
            mybutton.IdleCornerRadius = 50;
            mybutton.ActiveFillColor = Color.FromArgb(33, 9, 65);
            mybutton.ActiveLineColor = Color.FromArgb(33, 9, 65);
            mybutton.ForeColor = Color.White;
            mybutton.IdleFillColor = Color.White;
            mybutton.IdleForecolor = Color.FromArgb(33, 9, 65);
            mybutton.IdleLineColor = Color.FromArgb(33, 9, 65); 
            mybutton.Size = new Size(170, 20);
            mybutton.Size = new System.Drawing.Size(150, 100);
            mybutton.Dock = DockStyle.Right;
            mybutton.ButtonText = "Sepete Geri Dön";
            mybutton.Click += Mybutton_Click;
            mybutton.ActiveForecolor= Color.FromArgb(255, 107, 107);

        }

        private void Mybutton_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            frm.FormClosed += (s, args) => this.Close(); // frmOrders kapanınca mevcut form kapanacak
            frm.Show();
            this.Hide();



        }

        private void CreateButton(Panel panel1)
        {

            panel1.Controls.Clear();

            mng = new ObjectManager(true, "erpConnStr");

            BindingList<Area> myArea = new BindingList<Area>();

            myArea = mng.GetObjectList<Area>("", "CardName");



            foreach (Area item in myArea)
            {

                BunifuThinButton2 myBunifuButton = new BunifuThinButton2();
                myBunifuButton.BackColor = System.Drawing.Color.FromArgb(33, 9, 65);
                myBunifuButton.ActiveCornerRadius = 50;
                myBunifuButton.IdleCornerRadius = 50;
                myBunifuButton.Location = new System.Drawing.Point(CardLocationx, CardLocationy);
                myBunifuButton.ActiveFillColor = Color.FromArgb(33, 9, 65);
                myBunifuButton.ActiveLineColor = Color.FromArgb(33, 9, 65);
                myBunifuButton.ForeColor = Color.White;
                myBunifuButton.IdleFillColor = Color.White;
                myBunifuButton.IdleForecolor = Color.FromArgb(33, 9, 65);
                myBunifuButton.IdleLineColor = Color.FromArgb(33, 9, 65);
                myBunifuButton.Size = new Size(170, 20);
                myBunifuButton.Name = item.CardName;
                myBunifuButton.Size = new System.Drawing.Size(150, 100);
                myBunifuButton.TabIndex = 7;
                myBunifuButton.Tag = item.Ref;  // Ref bilgisi
                myBunifuButton.Click += MyBunifuButton_Click;
                myBunifuButton.ButtonText = item.CardName;
                myBunifuButton.ActiveForecolor = Color.FromArgb(255, 107, 107);

                //ekleme
                panel1.Controls.Add(myBunifuButton);
                panel1.Controls.Add(mybutton);
                CardLocationx = CardLocationx + 200;
            }


        }

        private void MyBunifuButton_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 clickedButton = sender as BunifuThinButton2;

            if (clickedButton != null && clickedButton.Tag != null)
            {
                CreateCards(clickedButton, panel2);

            }
        }

        // Kart Oluşturma
        private void CreateCards(BunifuThinButton2 myBtns, Panel panel2)
        {
            panel2.Controls.Clear();
            mng = new ObjectManager(true, "erpConnStr");

            BindingList<SalonTables> myTables = new BindingList<SalonTables>();


            myTables = mng.GetObjectList<SalonTables>("AreaRef = '" + Guid.Parse(myBtns.Tag.ToString()) + "'", "TableNo");

            int CardLocationx = 6;
            int CardLocationy = 30;

            foreach (SalonTables item in myTables)
            {
                SalesDetails mySalesDetails = new SalesDetails();
                Sales mySales = new Sales();
                mySales = mng.GetObject<Sales>(item.Ref);

                DataTable dt = dbm.ExecuteDataTable("Select TotalPrice From SalesDetails", CommandType.Text);

                DataTable dr = dbm.ExecuteDataTable("Select CardName From NewEmployee Where UserStatus = '2'", CommandType.Text);


                string EmployeeName = "";
                DateTime date = DateTime.Now;
                if (EmployeeName == "")
                {
                    EmployeeName = dr.Rows[0]["CardName"].ToString();
                }


                BunifuCards myBunifuCard = new BunifuCards();
                myBunifuCard.BackColor = System.Drawing.Color.WhiteSmoke;
                myBunifuCard.BorderRadius = 20;
                myBunifuCard.BottomSahddow = true;
                myBunifuCard.color = System.Drawing.Color.Green;
                myBunifuCard.LeftSahddow = false;
                myBunifuCard.Location = new System.Drawing.Point(CardLocationx, CardLocationy);
                myBunifuCard.Name = item.TableNo;
                myBunifuCard.RightSahddow = true;
                myBunifuCard.ShadowDepth = 20;
                myBunifuCard.Size = new System.Drawing.Size(200, 180);
                myBunifuCard.TabIndex = 7;
                myBunifuCard.Tag = item.Ref;  // Ref bilgisi
                myBunifuCard.DoubleClick += MyBunifuCard_DoubleClick;



                LabelControl lblTableName = new LabelControl();
                lblTableName.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
                lblTableName.Appearance.Options.UseFont = true;
                lblTableName.Appearance.Options.UseTextOptions = true;
                lblTableName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                lblTableName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                lblTableName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                lblTableName.Dock = System.Windows.Forms.DockStyle.Top;
                lblTableName.Location = new System.Drawing.Point(0, 5);
                lblTableName.Name = "lblTableName";
                lblTableName.Size = new System.Drawing.Size(253, 37);
                lblTableName.TabIndex = 10;
                lblTableName.Text = item.TableNo;
                myBunifuCard.Controls.Add(lblTableName);

                // Kartın üzerine toplam fiyat bilgisini ekleme
                LabelControl lblToal = new LabelControl();
                lblToal.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
                lblToal.Appearance.Options.UseFont = true;
                lblToal.Appearance.Options.UseTextOptions = true;
                lblToal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                lblToal.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                lblToal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                lblToal.Dock = System.Windows.Forms.DockStyle.Top;
                lblToal.Location = new System.Drawing.Point(0, 42);
                lblToal.Name = "lblTotal";
                lblToal.Size = new System.Drawing.Size(253, 37);
                lblToal.TabIndex = 11;
                lblToal.Text = mySalesDetails.UnitTotalPrice.ToString();
                myBunifuCard.Controls.Add(lblToal);
                if (lblToal.Text == 0.ToString())
                {
                    lblToal.Visible = false;
                }

                // Kartın üzerine tarih bilgisini ekleme
                LabelControl lblDate = new LabelControl();
                lblDate.Location = new System.Drawing.Point(3, 144);
                lblDate.Name = "lblDate";
                lblDate.Size = new System.Drawing.Size(121, 20);
                lblDate.TabIndex = 12;
                lblDate.Text = mySales.SalesDate.ToString();
                myBunifuCard.Controls.Add(lblDate);

                // Kartın Üzerine Garson Bilgisi Yazma
                LabelControl lblEmployee = new LabelControl();
                lblEmployee.Location = new System.Drawing.Point(60, 100);
                lblEmployee.Name = "lblEmployee";
                lblEmployee.Size = new System.Drawing.Size(110, 15);
                lblEmployee.TabIndex = 12;
                lblEmployee.Text = EmployeeName;
                lblEmployee.ForeColor = Color.Black;
                myBunifuCard.Controls.Add(lblEmployee);

                // Kartı panele ekleme
                panel2.Controls.Add(myBunifuCard);

                // Kartın konumunu ayarlama (x ve y koordinatları)
                CardLocationx = CardLocationx + 300;
                if (CardLocationx > 3500)
                {
                    CardLocationx = 6;
                    CardLocationy = CardLocationy + 250;
                }
            }
        }

        // tıklama olayı
        private void MyBunifuCard_DoubleClick(object sender, EventArgs e)
        {
            BunifuCards clickedCard = sender as BunifuCards;

            if (clickedCard != null && clickedCard.Tag != null)
            {
                string refValue = clickedCard.Tag.ToString();
                Tag = clickedCard.Tag.ToString();

                DialogResult res = XtraMessageBox.Show("Masaya Sipriş Girmek && Sipraişi Görüntülemek ister Misiniz", "Dikkat", MessageBoxButtons.OKCancel);

                if (res == DialogResult.OK)
                {

                    if (Application.OpenForms["frmOrders"] == null)
                    {
                        frmCostumerPays  frmcos = new frmCostumerPays();
                        frmcos.ShowDialog();
                       
                    }
                }

            }
        }


        private void btnGarden_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 myBtns = sender as BunifuThinButton2;
            CreateCards(myBtns, panel2);
        }

        private void btnSalon2_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 myBtns = sender as BunifuThinButton2;
            CreateCards(myBtns, panel2);
        }

        private void btnSalon3_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 myBtns = sender as BunifuThinButton2;
            CreateCards(myBtns, panel2);
        }

        private void btnTerace_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 myBtns = sender as BunifuThinButton2;
            CreateCards(myBtns, panel2);
        }

        private void btnSalon1_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 myBtns = sender as BunifuThinButton2;
            CreateCards(myBtns, panel2);
        }

        private void frmWaiter_Load(object sender, EventArgs e)
        {
            CreateButton(panel1);
            ExiteButton(panel1);
        }

     

    }
}