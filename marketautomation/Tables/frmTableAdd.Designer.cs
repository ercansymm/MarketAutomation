namespace marketautomation.Tables
{
    partial class frmTableAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTableAdd
            // 
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Name = "frmTableAdd";
            this.Load += new System.EventHandler(this.frmTableAdd_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private DevExpress.XtraEditors.LookUpEdit ledArea;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgwTables;
        private DevExpress.XtraGrid.Views.Grid.GridView grdTables;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn TableNo;
    }
}