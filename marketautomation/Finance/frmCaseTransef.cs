using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.Market;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketautomation.Finance
{
    public partial class frmCaseTransef : DevExpress.XtraEditors.XtraForm
    {
        public frmCaseTransef()
        {
            InitializeComponent();
        }

        DbManager dbm = new DbManager(false, "erpConnStr");
        CaseTransactions myCaseTransactions = new CaseTransactions();

        private void linelOO()
        {
            grdCase.Columns["LinelO"].ColumnEdit = riledLinelO;
        }
        private void caseTypee()
        {
            grdCase.Columns["CaseType"].ColumnEdit = riledCaseType;
        }
        public void fillCase()
        {
            riledCaseType.DataSource = dbm.ExecuteDataTable(
           @"Select '0' AS CaseType, 'Nakit' AS CaseTypeName
          UNION ALL 
          Select '1', 'Kredi Kartı' 
          UNION ALL 
          Select '2', 'Yemek Kartı'", CommandType.Text);
        }

        public void fillLinelO()
        {
            riledLinelO.DataSource = dbm.ExecuteDataTable(
            @"Select '0' AS LinelO, 'Giriş' AS LinelName
      UNION ALL 
      Select '1' AS LinelO, 'Çıkış' AS LinelName", CommandType.Text);
        }



        private void frmCaseTransef_Load(object sender, EventArgs e)
        {
            dgwCase.DataSource = dbm.ExecuteDataTable("Select * from CaseTransactions", CommandType.Text);
            fillCase();
            fillLinelO();
            caseTypee();
            linelOO();
        }
    }
}