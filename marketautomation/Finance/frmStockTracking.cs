using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design.Ruler;
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
    public partial class frmStockTracking : DevExpress.XtraEditors.XtraForm
    {
        public frmStockTracking()
        {
            InitializeComponent();
        }

        DbManager dbm = new DbManager(false, "erpConnStr");
        private void frmReports_Load(object sender, EventArgs e)
        {
           dgwReports.DataSource = dbm.ExecuteDataTable(@"select PD.CardName Stock,UC.CardName Unit, SUM(CASE SL.LinelO WHEN 0 THEN SL.Amount ELSE SL.Amount * -1 END) AS Amount from StockLines SL
left join Product PD ON PD.Ref = SL.StockRef
left join UnitCard UC ON UC.Ref = SL.UnitRef
Group by PD.CardName,UC.CardName
order by PD.CardName asc", CommandType.Text);
        }
    }
}