namespace marketautomation.Finance
{
    partial class frmStockTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockTracking));
            this.dgwReports = new DevExpress.XtraGrid.GridControl();
            this.grdReports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ledStockRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStockRef)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwReports
            // 
            this.dgwReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwReports.Location = new System.Drawing.Point(0, 0);
            this.dgwReports.MainView = this.grdReports;
            this.dgwReports.Name = "dgwReports";
            this.dgwReports.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ledStockRef});
            this.dgwReports.Size = new System.Drawing.Size(1194, 603);
            this.dgwReports.TabIndex = 0;
            this.dgwReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdReports});
            // 
            // grdReports
            // 
            this.grdReports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmStock,
            this.clmAmount,
            this.clmUnitRef});
            this.grdReports.GridControl = this.dgwReports;
            this.grdReports.Name = "grdReports";
            this.grdReports.OptionsBehavior.Editable = false;
            // 
            // clmStock
            // 
            this.clmStock.Caption = "Ürün Adı";
            this.clmStock.FieldName = "Stock";
            this.clmStock.MinWidth = 25;
            this.clmStock.Name = "clmStock";
            this.clmStock.Visible = true;
            this.clmStock.VisibleIndex = 0;
            this.clmStock.Width = 94;
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 25;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 2;
            this.clmAmount.Width = 94;
            // 
            // clmUnitRef
            // 
            this.clmUnitRef.Caption = "Birim";
            this.clmUnitRef.FieldName = "Unit";
            this.clmUnitRef.MinWidth = 25;
            this.clmUnitRef.Name = "clmUnitRef";
            this.clmUnitRef.Visible = true;
            this.clmUnitRef.VisibleIndex = 1;
            this.clmUnitRef.Width = 94;
            // 
            // ledStockRef
            // 
            this.ledStockRef.AutoHeight = false;
            this.ledStockRef.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledStockRef.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.ledStockRef.Name = "ledStockRef";
            this.ledStockRef.NullText = "";
            this.ledStockRef.ShowFooter = false;
            this.ledStockRef.ShowHeader = false;
            this.ledStockRef.ValueMember = "StockRef";
            // 
            // frmStockTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 603);
            this.Controls.Add(this.dgwReports);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockTracking.IconOptions.SvgImage")));
            this.Name = "frmStockTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStockRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwReports;
        private DevExpress.XtraGrid.Views.Grid.GridView grdReports;
        private DevExpress.XtraGrid.Columns.GridColumn clmStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnitRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ledStockRef;
    }
}