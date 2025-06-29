namespace marketautomation.casier
{
    partial class frmOrders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCellDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTabelGo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPayed = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMoneyTotal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtBarcode = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwDetails = new DevExpress.XtraGrid.GridControl();
            this.grdPrice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Topam Tutar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCellDelete);
            this.panel3.Controls.Add(this.btnTabelGo);
            this.panel3.Controls.Add(this.btnPayed);
            this.panel3.Controls.Add(this.txtMoneyTotal);
            this.panel3.Controls.Add(this.txtBarcode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 623);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1617, 109);
            this.panel3.TabIndex = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.Red;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Red;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Siparişi iptal Et";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.Red;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1418, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 61);
            this.btnDelete.TabIndex = 145;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCellDelete
            // 
            this.btnCellDelete.ActiveBorderThickness = 1;
            this.btnCellDelete.ActiveCornerRadius = 20;
            this.btnCellDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCellDelete.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnCellDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCellDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnCellDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCellDelete.BackgroundImage")));
            this.btnCellDelete.ButtonText = "Satırı Sil";
            this.btnCellDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCellDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCellDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCellDelete.IdleBorderThickness = 1;
            this.btnCellDelete.IdleCornerRadius = 20;
            this.btnCellDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnCellDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCellDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCellDelete.Location = new System.Drawing.Point(1176, 17);
            this.btnCellDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnCellDelete.Name = "btnCellDelete";
            this.btnCellDelete.Size = new System.Drawing.Size(185, 61);
            this.btnCellDelete.TabIndex = 144;
            this.btnCellDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCellDelete.Click += new System.EventHandler(this.btnCellDelete_Click);
            // 
            // btnTabelGo
            // 
            this.btnTabelGo.ActiveBorderThickness = 1;
            this.btnTabelGo.ActiveCornerRadius = 20;
            this.btnTabelGo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnTabelGo.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnTabelGo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnTabelGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnTabelGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTabelGo.BackgroundImage")));
            this.btnTabelGo.ButtonText = "Masalara Git";
            this.btnTabelGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabelGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabelGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnTabelGo.IdleBorderThickness = 1;
            this.btnTabelGo.IdleCornerRadius = 20;
            this.btnTabelGo.IdleFillColor = System.Drawing.Color.White;
            this.btnTabelGo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnTabelGo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnTabelGo.Location = new System.Drawing.Point(933, 17);
            this.btnTabelGo.Margin = new System.Windows.Forms.Padding(5);
            this.btnTabelGo.Name = "btnTabelGo";
            this.btnTabelGo.Size = new System.Drawing.Size(185, 61);
            this.btnTabelGo.TabIndex = 143;
            this.btnTabelGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTabelGo.Click += new System.EventHandler(this.btnTabelGo_Click);
            // 
            // btnPayed
            // 
            this.btnPayed.ActiveBorderThickness = 1;
            this.btnPayed.ActiveCornerRadius = 20;
            this.btnPayed.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnPayed.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnPayed.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnPayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnPayed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayed.BackgroundImage")));
            this.btnPayed.ButtonText = "Ödeme al";
            this.btnPayed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnPayed.IdleBorderThickness = 1;
            this.btnPayed.IdleCornerRadius = 20;
            this.btnPayed.IdleFillColor = System.Drawing.Color.White;
            this.btnPayed.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnPayed.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnPayed.Location = new System.Drawing.Point(672, 17);
            this.btnPayed.Margin = new System.Windows.Forms.Padding(5);
            this.btnPayed.Name = "btnPayed";
            this.btnPayed.Size = new System.Drawing.Size(185, 61);
            this.btnPayed.TabIndex = 142;
            this.btnPayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayed.Click += new System.EventHandler(this.btnPayed_Click);
            // 
            // txtMoneyTotal
            // 
            this.txtMoneyTotal.AcceptsReturn = false;
            this.txtMoneyTotal.AcceptsTab = false;
            this.txtMoneyTotal.AnimationSpeed = 200;
            this.txtMoneyTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMoneyTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMoneyTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtMoneyTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMoneyTotal.BackgroundImage")));
            this.txtMoneyTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtMoneyTotal.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtMoneyTotal.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtMoneyTotal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtMoneyTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtMoneyTotal.BorderRadius = 26;
            this.txtMoneyTotal.BorderThickness = 1;
            this.txtMoneyTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMoneyTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyTotal.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMoneyTotal.DefaultText = "";
            this.txtMoneyTotal.Enabled = false;
            this.txtMoneyTotal.FillColor = System.Drawing.Color.White;
            this.txtMoneyTotal.ForeColor = System.Drawing.Color.Lime;
            this.txtMoneyTotal.HideSelection = true;
            this.txtMoneyTotal.IconLeft = null;
            this.txtMoneyTotal.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyTotal.IconPadding = 10;
            this.txtMoneyTotal.IconRight = null;
            this.txtMoneyTotal.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyTotal.Lines = new string[0];
            this.txtMoneyTotal.Location = new System.Drawing.Point(170, 64);
            this.txtMoneyTotal.MaxLength = 32767;
            this.txtMoneyTotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMoneyTotal.Modified = false;
            this.txtMoneyTotal.Multiline = false;
            this.txtMoneyTotal.Name = "txtMoneyTotal";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMoneyTotal.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMoneyTotal.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMoneyTotal.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Lime;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMoneyTotal.OnIdleState = stateProperties4;
            this.txtMoneyTotal.Padding = new System.Windows.Forms.Padding(3);
            this.txtMoneyTotal.PasswordChar = '\0';
            this.txtMoneyTotal.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtMoneyTotal.PlaceholderText = "";
            this.txtMoneyTotal.ReadOnly = false;
            this.txtMoneyTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMoneyTotal.SelectedText = "";
            this.txtMoneyTotal.SelectionLength = 0;
            this.txtMoneyTotal.SelectionStart = 0;
            this.txtMoneyTotal.ShortcutsEnabled = true;
            this.txtMoneyTotal.Size = new System.Drawing.Size(186, 41);
            this.txtMoneyTotal.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMoneyTotal.TabIndex = 141;
            this.txtMoneyTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMoneyTotal.TextMarginBottom = 0;
            this.txtMoneyTotal.TextMarginLeft = 3;
            this.txtMoneyTotal.TextMarginTop = 0;
            this.txtMoneyTotal.TextPlaceholder = "";
            this.txtMoneyTotal.UseSystemPasswordChar = false;
            this.txtMoneyTotal.WordWrap = true;
            // 
            // txtBarcode
            // 
            this.txtBarcode.AcceptsReturn = false;
            this.txtBarcode.AcceptsTab = false;
            this.txtBarcode.AnimationSpeed = 200;
            this.txtBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBarcode.BackColor = System.Drawing.Color.Transparent;
            this.txtBarcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBarcode.BackgroundImage")));
            this.txtBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtBarcode.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtBarcode.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtBarcode.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.txtBarcode.BorderRadius = 26;
            this.txtBarcode.BorderThickness = 1;
            this.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.FillColor = System.Drawing.Color.White;
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.HideSelection = true;
            this.txtBarcode.IconLeft = null;
            this.txtBarcode.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.IconPadding = 10;
            this.txtBarcode.IconRight = null;
            this.txtBarcode.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(170, 11);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBarcode.Modified = false;
            this.txtBarcode.Multiline = false;
            this.txtBarcode.Name = "txtBarcode";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBarcode.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBarcode.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBarcode.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBarcode.OnIdleState = stateProperties8;
            this.txtBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBarcode.PlaceholderText = "";
            this.txtBarcode.ReadOnly = false;
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(186, 41);
            this.txtBarcode.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBarcode.TabIndex = 140;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.TextMarginBottom = 0;
            this.txtBarcode.TextMarginLeft = 3;
            this.txtBarcode.TextMarginTop = 0;
            this.txtBarcode.TextPlaceholder = "";
            this.txtBarcode.UseSystemPasswordChar = false;
            this.txtBarcode.WordWrap = true;
            this.txtBarcode.TextChange += new System.EventHandler(this.txtBarcode_TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 137;
            this.label1.Text = "Barkod";
            // 
            // dgwDetails
            // 
            this.dgwDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(19);
            this.dgwDetails.Location = new System.Drawing.Point(2, 2);
            this.dgwDetails.MainView = this.grdPrice;
            this.dgwDetails.Margin = new System.Windows.Forms.Padding(19);
            this.dgwDetails.Name = "dgwDetails";
            this.dgwDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledUnit,
            this.riledStock});
            this.dgwDetails.Size = new System.Drawing.Size(683, 619);
            this.dgwDetails.TabIndex = 42;
            this.dgwDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPrice,
            this.gridView2});
            this.dgwDetails.DoubleClick += new System.EventHandler(this.dgwDetails_DoubleClick);
            // 
            // grdPrice
            // 
            this.grdPrice.Appearance.FixedLine.Options.UseTextOptions = true;
            this.grdPrice.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdPrice.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.grdPrice.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdPrice.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdPrice.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdPrice.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdPrice.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdPrice.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdPrice.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdPrice.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdPrice.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdPrice.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.grdPrice.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.grdPrice.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.grdPrice.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdPrice.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdPrice.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.grdPrice.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.grdPrice.Appearance.Row.Options.UseBackColor = true;
            this.grdPrice.Appearance.Row.Options.UseForeColor = true;
            this.grdPrice.Appearance.SelectedRow.BackColor = System.Drawing.Color.Teal;
            this.grdPrice.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.grdPrice.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdPrice.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdPrice.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.grdPrice.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdPrice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmStock,
            this.clmRef,
            this.clmAmount,
            this.clmPrice,
            this.clmTotal});
            this.grdPrice.DetailHeight = 2080;
            this.grdPrice.GridControl = this.dgwDetails;
            this.grdPrice.Name = "grdPrice";
            this.grdPrice.OptionsBehavior.Editable = false;
            this.grdPrice.OptionsDetail.EnableMasterViewMode = false;
            this.grdPrice.OptionsDetail.ShowDetailTabs = false;
            this.grdPrice.OptionsDetail.SmartDetailExpand = false;
            this.grdPrice.OptionsPrint.PrintGroupFooter = false;
            this.grdPrice.OptionsPrint.PrintSelectedRowsOnly = true;
            this.grdPrice.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdPrice.OptionsView.ShowDetailButtons = false;
            this.grdPrice.OptionsView.ShowGroupPanel = false;
            // 
            // clmStock
            // 
            this.clmStock.Caption = "Ürün Adı";
            this.clmStock.ColumnEdit = this.riledStock;
            this.clmStock.FieldName = "StockRef";
            this.clmStock.MinWidth = 149;
            this.clmStock.Name = "clmStock";
            this.clmStock.Visible = true;
            this.clmStock.VisibleIndex = 0;
            this.clmStock.Width = 229;
            // 
            // riledStock
            // 
            this.riledStock.AutoHeight = false;
            this.riledStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
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
            this.clmRef.MinWidth = 149;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 555;
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 95;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.UnboundDataType = typeof(decimal);
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 1;
            this.clmAmount.Width = 108;
            // 
            // clmPrice
            // 
            this.clmPrice.Caption = "Fiyat";
            this.clmPrice.FieldName = "UnitPrice";
            this.clmPrice.MinWidth = 95;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.UnboundDataType = typeof(decimal);
            this.clmPrice.Visible = true;
            this.clmPrice.VisibleIndex = 2;
            this.clmPrice.Width = 141;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Total";
            this.clmTotal.FieldName = "UnitTotalPrice";
            this.clmTotal.MinWidth = 95;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitTotalPrice", "SUM={0:0.##}")});
            this.clmTotal.UnboundDataType = typeof(decimal);
            this.clmTotal.UnboundExpression = "[UnitPrice] * [Amount]";
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 3;
            this.clmTotal.Width = 115;
            // 
            // riledUnit
            // 
            this.riledUnit.AutoHeight = false;
            this.riledUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledUnit.DisplayMember = "CardName";
            this.riledUnit.Name = "riledUnit";
            this.riledUnit.NullText = "";
            this.riledUnit.ValueMember = "UnitCardRef";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgwDetails;
            this.gridView2.Name = "gridView2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgwDetails);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(687, 623);
            this.panelControl1.TabIndex = 42;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(686, 2);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(15);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(931, 621);
            this.xtraTabControl1.TabIndex = 41;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(298, 270);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(298, 270);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(192, 142);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl2.Size = new System.Drawing.Size(300, 300);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl3.Location = new System.Drawing.Point(1, 1);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.Size = new System.Drawing.Size(888, 627);
            this.xtraTabControl3.TabIndex = 0;
            this.xtraTabControl3.Visible = false;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 732);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmOrders.IconOptions.SvgImage")));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl dgwDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private Bunifu.UI.WinForms.BunifuTextBox txtMoneyTotal;
        private Bunifu.UI.WinForms.BunifuTextBox txtBarcode;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPayed;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTabelGo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCellDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
    }
}