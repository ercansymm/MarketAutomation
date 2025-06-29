using DevExpress.Office.Utils;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
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
using Utilities.BunifuImageButton.Transitions;

namespace marketautomation.casier
{
    public partial class frmNumber : DevExpress.XtraEditors.XtraForm
    {
        public frmNumber()
        {
            InitializeComponent();
        }
        string quantity = "";
        public decimal amount;
        public Guid unitRef;
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        Product myProduct = new Product();
        void Write(string value)
        {
            quantity = quantity + value;
            txtTotal.Text = quantity;
        }
        void fillform()
        {
            
            txtTotal.Text = amount.ToString();
        }
        private void frmNumber_Load(object sender, EventArgs e)
        {

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    txtTotal.Text = default;
                  
                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    fillform();
                    break;
                default:
                    break;
            }
        }

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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.Text = txtTotal.Text.Remove(txtTotal.Text.Length - 1);
                quantity = txtTotal.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTotal.Text, out int result))
            {
                XtraMessageBox.Show("Lütfen geçerli bir sayı girin.");
                txtTotal.Text = ""; 
                return;
            }

            if (result <= 0)
            {
                XtraMessageBox.Show("Ürün 0 Olamaz");
                txtTotal.Text = ""; 
                return;
            }

            amount = decimal.Parse(txtTotal.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        private void btn0_Clik(object sender, EventArgs e)
        {
            Write(btn0.ButtonText);

        }
    }
}