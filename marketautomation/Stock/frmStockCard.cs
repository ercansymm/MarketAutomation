using DevExpress.DataAccess.Native.Sql.MasterDetail;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using GladiusObjex.PrgClass.MRP.StockClasses;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.Stock
{
    public partial class frmStockCard : DevExpress.XtraEditors.XtraForm
    {
        public frmStockCard()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        Product myProduct = new Product();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        public Guid productRef;
        byte[] myImage = new byte[] { };
        BindingList<SubCategory> subs = new BindingList<SubCategory>();
        void Filled()
        {
            subs = mng.GetObjectList<SubCategory>(" CategoryRef = '" + Guid.Parse(ledCatagory.EditValue.ToString()) + "'", "");
            ledSub.Properties.DataSource = subs;
        }
        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtCardName.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Ürün İsmini Boş Geçemezsiniz.");

            if (txtCardPrice.Text.Length == 0 || txtCardPrice.Text == null)
                stb.AppendLine("Ürün Fiyatını Boş Geçemezsini.");

            if (txtSpecialCode.Text.Length == 0 || txtSpecialCode.Text == null)
                stb.AppendLine("Özel Kodu Boş Geçemezsiniz.");

            if (txtKdv.Text.Length == 0 || txtKdv.Text == null)
                stb.AppendLine("Kdv'yi Boş Geçemezsiniz.");

            if (ledCatagory.Text.Length == 0 || ledCatagory.EditValue == null)
                stb.AppendLine("Kategoriyi Boş Geçemezsiniz.");

            if (ledUnitRef.Text.Length == 0 || ledUnitRef.EditValue == null)
                stb.AppendLine("Kategoriyi Boş Geçemezsiniz.");
            if (peProduct.Image == null)
            {
                stb.AppendLine("Ürün Resmini Boş Geçemezsiniz.");
            }

            if (ledSub.Text.Length == 0 || ledSub.EditValue == null)
            {
                stb.AppendLine("Alt Kategoriyi Boş Geçemezsiniz.");
            }
            
            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }
        void fillForm()
        {
            txtBarcode.Text = myProduct.Barcode;
            txtCardName.Text = myProduct.CardName;
            txtCardPrice.Text = myProduct.CardPrice.ToString();
            txtKdv.Text = myProduct.Kdv.ToString();
            txtSpecialCode.Text = myProduct.SpecialCode;
            ledUnitRef.EditValue = myProduct.UnitRef;
            rchDec.Text = myProduct.Description;
            tglActive.EditValue = myProduct.IsPassive;
            ledCatagory.EditValue = myProduct.CategoryRef;
            ledSub.EditValue = myProduct.SubCategoryRef;
            if (myProduct.Image != null && myProduct.Image.Length > 0)
            {
                MemoryStream ms = new MemoryStream(myProduct.Image);
                peProduct.Image = Image.FromStream(ms);
                myImage = myProduct.Image;
            }
        }
        private void frmStockCard_Load(object sender, EventArgs e)
        {
            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myProduct = new Product();
                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    myProduct = myProduct.getProduct(productRef);
                    fillForm();
                    break;
                default:
                    break;
            }
            ledUnitRef.Properties.DataSource = dbm.ExecuteDataTable("select Ref,CardName From UnitCard", CommandType.Text);
            ledCatagory.Properties.DataSource = dbm.ExecuteDataTable("select Ref,CardName From Category", CommandType.Text);

        }
        private void btnSaved_Click(object sender, EventArgs e)
        {
            int barcode;
            if (SaveControl())
            {
                try
                {
                    barcode = int.Parse(dbm.ExecuteScalar("Select COUNT(Ref) from Product where Barcode = '" + txtBarcode.Text + "'", CommandType.Text).ToString());

                    mng = new ObjectManager(true, "erpConnStr");

                    myProduct.CardName = txtCardName.Text;
                    myProduct.Barcode = txtBarcode.Text;
                    myProduct.CardPrice = decimal.Parse(txtCardPrice.Text);
                    myProduct.Kdv = decimal.Parse(txtKdv.Text);
                    myProduct.Description = rchDec.Text;
                    myProduct.SpecialCode = txtSpecialCode.Text;
                    myProduct.IsPassive = tglActive.IsOn;
                    myProduct.CategoryRef = Guid.Parse(ledCatagory.EditValue.ToString());
                    
                    if (ledSub.EditValue != null)
                    {
                        myProduct.SubCategoryRef = Guid.Parse(ledSub.EditValue.ToString());

                    }

                    if (peProduct.Image != null)
                    {
                        myProduct.Image = myImage;
                    }

                    if (ledUnitRef.EditValue != null)
                    {
                        myProduct.UnitRef = Guid.Parse(ledUnitRef.EditValue.ToString());
                    }

                    mng.SaveObject<Product>(myProduct);
                    mng.Commit();
                    XtraMessageBox.Show("Ürün Kaydınız && Güncellemeniz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    ledUnitRef.Properties.DataSource = dbm.ExecuteDataTable("select Ref,CardName From UnitCard", CommandType.Text);





                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("" + ex, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void lnkPicure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp)|.png;*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);

                    myProduct.Image = System.IO.File.ReadAllBytes(fi.FullName);

                    using (var ms = new MemoryStream(myProduct.Image))
                    {
                        peProduct.Image = Image.FromStream(ms);
                        myImage = System.IO.File.ReadAllBytes(fi.FullName);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("" + ex, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void ledCatagory_EditValueChanged(object sender, EventArgs e)
        {
            Filled();
        }
    }

}