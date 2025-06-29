namespace marketautomation
{
    partial class frmStockFiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockFiche));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ledClient = new DevExpress.XtraEditors.LookUpEdit();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtFicheNo = new DevExpress.XtraEditors.TextEdit();
            this.dateFicheDate = new DevExpress.XtraEditors.DateEdit();
            this.rchDecription = new System.Windows.Forms.RichTextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgwFiche = new DevExpress.XtraGrid.GridControl();
            this.grdFiche = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledCardName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmUnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicheNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFicheDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFicheDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCardName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnSaved
            // 
            this.btnSaved.ActiveBorderThickness = 1;
            this.btnSaved.ActiveCornerRadius = 40;
            this.btnSaved.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaved.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnSaved.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaved.BackgroundImage")));
            this.btnSaved.ButtonText = "Kaydet";
            this.btnSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaved.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.IdleBorderThickness = 1;
            this.btnSaved.IdleCornerRadius = 30;
            this.btnSaved.IdleFillColor = System.Drawing.Color.White;
            this.btnSaved.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSaved.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.Location = new System.Drawing.Point(5, 5);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(179, 41);
            this.btnSaved.TabIndex = 13;
            this.btnSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.ledClient);
            this.groupControl1.Controls.Add(this.bunifuLabel2);
            this.groupControl1.Controls.Add(this.txtFicheNo);
            this.groupControl1.Controls.Add(this.dateFicheDate);
            this.groupControl1.Controls.Add(this.rchDecription);
            this.groupControl1.Controls.Add(this.bunifuLabel5);
            this.groupControl1.Controls.Add(this.bunifuLabel3);
            this.groupControl1.Controls.Add(this.bunifuLabel1);
            this.groupControl1.Location = new System.Drawing.Point(-2, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(766, 157);
            this.groupControl1.TabIndex = 3;
            // 
            // ledClient
            // 
            this.ledClient.Location = new System.Drawing.Point(83, 115);
            this.ledClient.Name = "ledClient";
            this.ledClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.ledClient.Properties.DisplayMember = "CardName";
            this.ledClient.Properties.NullText = "";
            this.ledClient.Properties.ShowFooter = false;
            this.ledClient.Properties.ShowHeader = false;
            this.ledClient.Properties.ValueMember = "Ref";
            this.ledClient.Size = new System.Drawing.Size(177, 22);
            this.ledClient.TabIndex = 14;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 117);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(36, 20);
            this.bunifuLabel2.TabIndex = 10;
            this.bunifuLabel2.Text = "Carisi";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFicheNo
            // 
            this.txtFicheNo.Enabled = false;
            this.txtFicheNo.Location = new System.Drawing.Point(83, 35);
            this.txtFicheNo.Name = "txtFicheNo";
            this.txtFicheNo.Size = new System.Drawing.Size(177, 22);
            this.txtFicheNo.TabIndex = 9;
            // 
            // dateFicheDate
            // 
            this.dateFicheDate.EditValue = null;
            this.dateFicheDate.Location = new System.Drawing.Point(83, 75);
            this.dateFicheDate.Name = "dateFicheDate";
            this.dateFicheDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFicheDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFicheDate.Size = new System.Drawing.Size(177, 22);
            this.dateFicheDate.TabIndex = 8;
            // 
            // rchDecription
            // 
            this.rchDecription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.rchDecription.ForeColor = System.Drawing.Color.White;
            this.rchDecription.Location = new System.Drawing.Point(511, 32);
            this.rchDecription.Name = "rchDecription";
            this.rchDecription.Size = new System.Drawing.Size(243, 105);
            this.rchDecription.TabIndex = 5;
            this.rchDecription.Text = "";
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(374, 38);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(61, 20);
            this.bunifuLabel5.TabIndex = 4;
            this.bunifuLabel5.Text = "Açıklama";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(13, 77);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(58, 20);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Fiş Tarihi";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 32);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(41, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Fiş No";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgwFiche
            // 
            this.dgwFiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFiche.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwFiche.Location = new System.Drawing.Point(2, 2);
            this.dgwFiche.MainView = this.grdFiche;
            this.dgwFiche.Margin = new System.Windows.Forms.Padding(4);
            this.dgwFiche.Name = "dgwFiche";
            this.dgwFiche.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledCardName,
            this.riledUnitRef});
            this.dgwFiche.Size = new System.Drawing.Size(760, 479);
            this.dgwFiche.TabIndex = 4;
            this.dgwFiche.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdFiche});
            // 
            // grdFiche
            // 
            this.grdFiche.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmStockRef,
            this.clmUnitRef,
            this.clmAmount});
            this.grdFiche.DetailHeight = 437;
            this.grdFiche.GridControl = this.dgwFiche;
            this.grdFiche.Name = "grdFiche";
            this.grdFiche.OptionsCustomization.AllowGroup = false;
            this.grdFiche.OptionsDetail.EnableMasterViewMode = false;
            this.grdFiche.OptionsDetail.SmartDetailExpand = false;
            this.grdFiche.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdFiche.OptionsView.ShowDetailButtons = false;
            this.grdFiche.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmStockRef
            // 
            this.clmStockRef.Caption = "Stok İsmi";
            this.clmStockRef.ColumnEdit = this.riledCardName;
            this.clmStockRef.FieldName = "StockRef";
            this.clmStockRef.MinWidth = 25;
            this.clmStockRef.Name = "clmStockRef";
            this.clmStockRef.Visible = true;
            this.clmStockRef.VisibleIndex = 0;
            this.clmStockRef.Width = 217;
            // 
            // riledCardName
            // 
            this.riledCardName.AutoHeight = false;
            this.riledCardName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledCardName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledCardName.DisplayMember = "CardName";
            this.riledCardName.Name = "riledCardName";
            this.riledCardName.NullText = "";
            this.riledCardName.ShowHeader = false;
            this.riledCardName.ShowLines = false;
            this.riledCardName.ValueMember = "StockRef";
            // 
            // clmUnitRef
            // 
            this.clmUnitRef.Caption = "Birimi";
            this.clmUnitRef.ColumnEdit = this.riledUnitRef;
            this.clmUnitRef.FieldName = "UnitRef";
            this.clmUnitRef.MinWidth = 25;
            this.clmUnitRef.Name = "clmUnitRef";
            this.clmUnitRef.Visible = true;
            this.clmUnitRef.VisibleIndex = 1;
            this.clmUnitRef.Width = 216;
            // 
            // riledUnitRef
            // 
            this.riledUnitRef.AutoHeight = false;
            this.riledUnitRef.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledUnitRef.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledUnitRef.DisplayMember = "CardName";
            this.riledUnitRef.Name = "riledUnitRef";
            this.riledUnitRef.NullText = "";
            this.riledUnitRef.ValueMember = "UnitRef";
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktarı";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 25;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 2;
            this.clmAmount.Width = 288;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.dgwFiche);
            this.panelControl1.Location = new System.Drawing.Point(0, 206);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 483);
            this.panelControl1.TabIndex = 5;
            // 
            // frmStockFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 689);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockFiche.IconOptions.SvgImage")));
            this.Name = "frmStockFiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Detayları";
            this.Load += new System.EventHandler(this.frmStcokFishe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicheNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFicheDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFicheDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCardName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.RichTextBox rchDecription;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private DevExpress.XtraGrid.GridControl dgwFiche;
        private DevExpress.XtraGrid.Views.Grid.GridView grdFiche;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraEditors.DateEdit dateFicheDate;
        private DevExpress.XtraEditors.TextEdit txtFicheNo;
        private DevExpress.XtraGrid.Columns.GridColumn clmStockRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledCardName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private DevExpress.XtraEditors.LookUpEdit ledClient;
    }
}