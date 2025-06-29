namespace marketautomation.casier
{
    partial class frmCraced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCraced));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwDetails = new DevExpress.XtraGrid.GridControl();
            this.grdPrice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCoveredAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCoveredPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riletUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtTotal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtChange = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnTicket = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCredit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtSubtotal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnCallculeted = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCash = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riletUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 349);
            this.panel1.TabIndex = 0;
            // 
            // dgwDetails
            // 
            this.dgwDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgwDetails.Location = new System.Drawing.Point(0, 0);
            this.dgwDetails.MainView = this.grdPrice;
            this.dgwDetails.Margin = new System.Windows.Forms.Padding(6);
            this.dgwDetails.Name = "dgwDetails";
            this.dgwDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riletUnit,
            this.riledStock});
            this.dgwDetails.Size = new System.Drawing.Size(780, 349);
            this.dgwDetails.TabIndex = 37;
            this.dgwDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPrice});
            // 
            // grdPrice
            // 
            this.grdPrice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmStock,
            this.clmRef,
            this.clmAmount,
            this.clmUnitPrice,
            this.clmTotal,
            this.clmCoveredAmount,
            this.clmCoveredPrice,
            this.clmTotalAmount});
            this.grdPrice.DetailHeight = 682;
            this.grdPrice.GridControl = this.dgwDetails;
            this.grdPrice.Name = "grdPrice";
            this.grdPrice.OptionsBehavior.Editable = false;
            this.grdPrice.OptionsDetail.EnableMasterViewMode = false;
            this.grdPrice.OptionsDetail.ShowDetailTabs = false;
            this.grdPrice.OptionsDetail.SmartDetailExpand = false;
            this.grdPrice.OptionsView.ShowDetailButtons = false;
            this.grdPrice.OptionsView.ShowGroupPanel = false;
            this.grdPrice.DoubleClick += new System.EventHandler(this.grdPrice_DoubleClick);
            // 
            // clmStock
            // 
            this.clmStock.Caption = "Ürün Adı";
            this.clmStock.ColumnEdit = this.riledStock;
            this.clmStock.FieldName = "StockRef";
            this.clmStock.MinWidth = 49;
            this.clmStock.Name = "clmStock";
            this.clmStock.Visible = true;
            this.clmStock.VisibleIndex = 0;
            this.clmStock.Width = 410;
            // 
            // riledStock
            // 
            this.riledStock.AutoHeight = false;
            this.riledStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledStock.DisplayMember = "CardName";
            this.riledStock.Name = "riledStock";
            this.riledStock.NullText = "";
            this.riledStock.ShowFooter = false;
            this.riledStock.ShowHeader = false;
            this.riledStock.ValueMember = "StockRef";
            // 
            // clmRef
            // 
            this.clmRef.Caption = "clmRef";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 49;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 182;
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 31;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.UnboundDataType = typeof(decimal);
            this.clmAmount.Width = 91;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.Caption = "Fiyat";
            this.clmUnitPrice.FieldName = "UnitPrice";
            this.clmUnitPrice.MinWidth = 31;
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.UnboundDataType = typeof(decimal);
            this.clmUnitPrice.Width = 199;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Total";
            this.clmTotal.FieldName = "TotalPrice";
            this.clmTotal.MinWidth = 31;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:0.##}")});
            this.clmTotal.UnboundDataType = typeof(decimal);
            this.clmTotal.UnboundExpression = "[UnitPrice] * [Amount]";
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 2;
            this.clmTotal.Width = 160;
            // 
            // clmCoveredAmount
            // 
            this.clmCoveredAmount.Caption = "Ödenen ";
            this.clmCoveredAmount.FieldName = "CoveredAmount";
            this.clmCoveredAmount.MinWidth = 25;
            this.clmCoveredAmount.Name = "clmCoveredAmount";
            this.clmCoveredAmount.Width = 94;
            // 
            // clmCoveredPrice
            // 
            this.clmCoveredPrice.Caption = "ÖdenenFiyat";
            this.clmCoveredPrice.FieldName = "CoveredPrice";
            this.clmCoveredPrice.MinWidth = 25;
            this.clmCoveredPrice.Name = "clmCoveredPrice";
            this.clmCoveredPrice.Width = 94;
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.Caption = "Miktar";
            this.clmTotalAmount.FieldName = "TotalAmount";
            this.clmTotalAmount.MinWidth = 25;
            this.clmTotalAmount.Name = "clmTotalAmount";
            this.clmTotalAmount.Visible = true;
            this.clmTotalAmount.VisibleIndex = 1;
            this.clmTotalAmount.Width = 180;
            // 
            // riletUnit
            // 
            this.riletUnit.AutoHeight = false;
            this.riletUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riletUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riletUnit.DisplayMember = "CardName";
            this.riletUnit.Name = "riletUnit";
            this.riletUnit.NullText = "";
            this.riletUnit.ValueMember = "UnitCardRef";
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(798, 23);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(102, 23);
            this.bunifuLabel3.TabIndex = 133;
            this.bunifuLabel3.Text = "Toplam Tutar";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtTotal
            // 
            this.txtTotal.AcceptsReturn = false;
            this.txtTotal.AcceptsTab = false;
            this.txtTotal.AnimationSpeed = 200;
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTotal.BackgroundImage")));
            this.txtTotal.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTotal.BorderColorDisabled = System.Drawing.Color.Silver;
            this.txtTotal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTotal.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTotal.BorderRadius = 40;
            this.txtTotal.BorderThickness = 1;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtTotal.DefaultText = "";
            this.txtTotal.FillColor = System.Drawing.Color.White;
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HideSelection = true;
            this.txtTotal.IconLeft = null;
            this.txtTotal.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.IconPadding = 10;
            this.txtTotal.IconRight = null;
            this.txtTotal.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(940, 12);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTotal.Modified = false;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Silver;
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTotal.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Black;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnIdleState = stateProperties16;
            this.txtTotal.Padding = new System.Windows.Forms.Padding(3);
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 51);
            this.txtTotal.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTotal.TabIndex = 138;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TextMarginBottom = 0;
            this.txtTotal.TextMarginLeft = 3;
            this.txtTotal.TextMarginTop = 0;
            this.txtTotal.TextPlaceholder = "";
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.WordWrap = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(798, 87);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(129, 23);
            this.bunifuLabel1.TabIndex = 140;
            this.bunifuLabel1.Text = "Müşteri Ödemesi";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtChange
            // 
            this.txtChange.AcceptsReturn = false;
            this.txtChange.AcceptsTab = false;
            this.txtChange.AnimationSpeed = 200;
            this.txtChange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtChange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtChange.BackColor = System.Drawing.Color.Transparent;
            this.txtChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtChange.BackgroundImage")));
            this.txtChange.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtChange.BorderColorDisabled = System.Drawing.Color.Silver;
            this.txtChange.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtChange.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtChange.BorderRadius = 40;
            this.txtChange.BorderThickness = 1;
            this.txtChange.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtChange.DefaultText = "";
            this.txtChange.FillColor = System.Drawing.Color.White;
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.HideSelection = true;
            this.txtChange.IconLeft = null;
            this.txtChange.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.IconPadding = 10;
            this.txtChange.IconRight = null;
            this.txtChange.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Lines = new string[0];
            this.txtChange.Location = new System.Drawing.Point(940, 78);
            this.txtChange.MaxLength = 32767;
            this.txtChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtChange.Modified = false;
            this.txtChange.Multiline = false;
            this.txtChange.Name = "txtChange";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtChange.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Silver;
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtChange.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtChange.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Black;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtChange.OnIdleState = stateProperties20;
            this.txtChange.Padding = new System.Windows.Forms.Padding(3);
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtChange.PlaceholderText = "";
            this.txtChange.ReadOnly = false;
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(182, 51);
            this.txtChange.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtChange.TabIndex = 139;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChange.TextMarginBottom = 0;
            this.txtChange.TextMarginLeft = 3;
            this.txtChange.TextMarginTop = 0;
            this.txtChange.TextPlaceholder = "";
            this.txtChange.UseSystemPasswordChar = false;
            this.txtChange.WordWrap = true;
            // 
            // btnTicket
            // 
            this.btnTicket.ActiveBorderThickness = 1;
            this.btnTicket.ActiveCornerRadius = 60;
            this.btnTicket.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnTicket.ActiveForecolor = System.Drawing.Color.White;
            this.btnTicket.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTicket.BackgroundImage")));
            this.btnTicket.ButtonText = "Yemek Kartı";
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.Coral;
            this.btnTicket.IdleBorderThickness = 1;
            this.btnTicket.IdleCornerRadius = 60;
            this.btnTicket.IdleFillColor = System.Drawing.Color.White;
            this.btnTicket.IdleForecolor = System.Drawing.Color.Coral;
            this.btnTicket.IdleLineColor = System.Drawing.Color.Coral;
            this.btnTicket.Location = new System.Drawing.Point(789, 278);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(6);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(195, 71);
            this.btnTicket.TabIndex = 144;
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.ActiveBorderThickness = 1;
            this.btnCredit.ActiveCornerRadius = 60;
            this.btnCredit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCredit.ActiveForecolor = System.Drawing.Color.White;
            this.btnCredit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnCredit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCredit.BackgroundImage")));
            this.btnCredit.ButtonText = "Kredi";
            this.btnCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCredit.IdleBorderThickness = 1;
            this.btnCredit.IdleCornerRadius = 60;
            this.btnCredit.IdleFillColor = System.Drawing.Color.White;
            this.btnCredit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCredit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCredit.Location = new System.Drawing.Point(996, 208);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(6);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(195, 71);
            this.btnCredit.TabIndex = 142;
            this.btnCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(798, 154);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(74, 23);
            this.bunifuLabel2.TabIndex = 146;
            this.bunifuLabel2.Text = "Para Üstü";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AcceptsReturn = false;
            this.txtSubtotal.AcceptsTab = false;
            this.txtSubtotal.AnimationSpeed = 200;
            this.txtSubtotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSubtotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.txtSubtotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSubtotal.BackgroundImage")));
            this.txtSubtotal.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSubtotal.BorderColorDisabled = System.Drawing.Color.Silver;
            this.txtSubtotal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSubtotal.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSubtotal.BorderRadius = 40;
            this.txtSubtotal.BorderThickness = 1;
            this.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSubtotal.DefaultText = "";
            this.txtSubtotal.FillColor = System.Drawing.Color.White;
            this.txtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.HideSelection = true;
            this.txtSubtotal.IconLeft = null;
            this.txtSubtotal.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.IconPadding = 10;
            this.txtSubtotal.IconRight = null;
            this.txtSubtotal.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.Lines = new string[0];
            this.txtSubtotal.Location = new System.Drawing.Point(940, 148);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSubtotal.Modified = false;
            this.txtSubtotal.Multiline = false;
            this.txtSubtotal.Name = "txtSubtotal";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubtotal.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.Silver;
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSubtotal.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubtotal.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Black;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubtotal.OnIdleState = stateProperties24;
            this.txtSubtotal.Padding = new System.Windows.Forms.Padding(3);
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSubtotal.PlaceholderText = "";
            this.txtSubtotal.ReadOnly = false;
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(182, 51);
            this.txtSubtotal.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSubtotal.TabIndex = 145;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubtotal.TextMarginBottom = 0;
            this.txtSubtotal.TextMarginLeft = 3;
            this.txtSubtotal.TextMarginTop = 0;
            this.txtSubtotal.TextPlaceholder = "";
            this.txtSubtotal.UseSystemPasswordChar = false;
            this.txtSubtotal.WordWrap = true;
            // 
            // btnCallculeted
            // 
            this.btnCallculeted.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCallculeted.Appearance.Options.UseBackColor = true;
            this.btnCallculeted.Location = new System.Drawing.Point(1128, 87);
            this.btnCallculeted.Name = "btnCallculeted";
            this.btnCallculeted.Size = new System.Drawing.Size(66, 29);
            this.btnCallculeted.TabIndex = 147;
            this.btnCallculeted.Text = ">";
            this.btnCallculeted.Click += new System.EventHandler(this.btnCallculeted_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 60;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Ödemeyi Sonlandır";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 60;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(996, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 71);
            this.btnCancel.TabIndex = 142;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCash
            // 
            this.btnCash.ActiveBorderThickness = 1;
            this.btnCash.ActiveCornerRadius = 60;
            this.btnCash.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCash.ActiveForecolor = System.Drawing.Color.White;
            this.btnCash.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash.BackgroundImage")));
            this.btnCash.ButtonText = "Nakit";
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCash.IdleBorderThickness = 1;
            this.btnCash.IdleCornerRadius = 60;
            this.btnCash.IdleFillColor = System.Drawing.Color.White;
            this.btnCash.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCash.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCash.Location = new System.Drawing.Point(789, 208);
            this.btnCash.Margin = new System.Windows.Forms.Padding(6);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(195, 71);
            this.btnCash.TabIndex = 148;
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // frmCraced
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 349);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCallculeted);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmCraced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCraced";
            this.Load += new System.EventHandler(this.frmCraced_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riletUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgwDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riletUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuTextBox txtTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtChange;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTicket;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCredit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox txtSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn clmCoveredAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmCoveredPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotalAmount;
        private DevExpress.XtraEditors.SimpleButton btnCallculeted;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCash;
    }
}