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

namespace marketautomation.Clinet
{
    public partial class frmClientCard : DevExpress.XtraEditors.XtraForm
    {
        public frmClientCard()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        NewClinet myClient = new NewClinet();
        public Guid ClinetRef;
        string Clinetcode;

        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtCardName.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Tedarikçi İsmini Boş Geçemezsiniz.");

            if (txtPhoneNo.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Tedarikçi Numarasını Boş Geçemezsiniz.");

            if (rchClientAddres.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Tedarikçi Adresini Boş Geçemezsiniz.");

            if (rchDepoAddres.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Tedarikçi Depo Adresini Boş Geçemezsiniz.");


            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;

        }

        void fillform()
        {
            txtCardName.Text = myClient.CardName;
            txtPhoneNo.Text = myClient.ClientPhone.ToString();
            txtPhoneNo2.Text = myClient.ClientPhone2.ToString();
            rchClientAddres.Text = myClient.ClientAddres.ToString();
            rchDepoAddres.Text = myClient.ClientDepoAddres;
            tglActive.EditValue = myClient.IsPassive;
            txtNo.Text = myClient.ClientNo.ToString();


        }
        private void frmClientCard_Load(object sender, EventArgs e)
        {

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myClient = new NewClinet();
                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    myClient = myClient.getClient(ClinetRef);
                    fillform();
                    break;
                default:
                    break;
            }


        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveControl())
                {
                    mng = new ObjectManager(true, "erpConnStr");

                    myClient.CardName = txtCardName.Text;
                    myClient.ClientPhone = txtPhoneNo.Text;
                    myClient.ClientPhone2 = txtPhoneNo2.Text;
                    myClient.ClientAddres = rchClientAddres.Text;
                    myClient.ClientDepoAddres = rchDepoAddres.Text;
                    myClient.IsPassive = tglActive.IsOn;
                    int clientCount = int.Parse(dbm.ExecuteScalar("Select Count(ClientNo) from Clinet", CommandType.Text).ToString());

                    if (clientCount > 0)
                    {
                        // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                        Clinetcode = dbm.ExecuteScalar("select top 1 ClientNo From Clinet order by ClientNo desc", CommandType.Text).ToString();
                        int nextClientNo = int.Parse(Clinetcode) + 1;
                        myClient.ClientNo = nextClientNo.ToString();
                    }
                    else
                    {
                        // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                        Clinetcode = "1";
                        myClient.ClientNo = Clinetcode;
                    }

                    // TextBox'a güncellenmiş değeri atıyoruz
                    txtNo.Text = StringProc.Increment(Clinetcode, true);

                    mng.SaveObject<NewClinet>(myClient);
                    mng.Commit();
                    XtraMessageBox.Show("Ürün Kaydınız && Güncellemeniz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                else
                {
                    return;
                }


            }

            catch (Exception ex)
            {


                XtraMessageBox.Show("" + ex, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}