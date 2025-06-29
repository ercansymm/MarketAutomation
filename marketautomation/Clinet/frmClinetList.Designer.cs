namespace marketautomation.Clinet
{
    partial class frmClinetList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClinetList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwClient = new DevExpress.XtraGrid.GridControl();
            this.grdClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClientNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClientAddres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClientPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClinetPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClinetDepoAddres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 74);
            this.panel1.TabIndex = 2;
            // 
            // tglActive
            // 
            this.tglActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(1196, 0);
            this.tglActive.Name = "tglActive";
            this.tglActive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F);
            this.tglActive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglActive.Properties.Appearance.Options.UseFont = true;
            this.tglActive.Properties.Appearance.Options.UseForeColor = true;
            this.tglActive.Properties.OffText = "Pasif Tedarikçiler";
            this.tglActive.Properties.OnText = "Aktif Tedarikçiler";
            this.tglActive.Size = new System.Drawing.Size(222, 74);
            this.tglActive.TabIndex = 34;
            this.tglActive.Toggled += new System.EventHandler(this.tglActive_Toggled);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 40;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Düzenle";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Coral;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 30;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.Coral;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.Coral;
            this.btnUpdate.Location = new System.Drawing.Point(187, 14);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 51);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 40;
            this.btnNew.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.ActiveForecolor = System.Drawing.Color.White;
            this.btnNew.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "Yeni";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 30;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Location = new System.Drawing.Point(14, 14);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 51);
            this.btnNew.TabIndex = 13;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgwClient
            // 
            this.dgwClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwClient.Location = new System.Drawing.Point(0, 74);
            this.dgwClient.MainView = this.grdClient;
            this.dgwClient.Name = "dgwClient";
            this.dgwClient.Size = new System.Drawing.Size(1418, 471);
            this.dgwClient.TabIndex = 3;
            this.dgwClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdClient});
            // 
            // grdClient
            // 
            this.grdClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmClientNo,
            this.clmCardName,
            this.clmClientAddres,
            this.clmClientPhone,
            this.clmClinetPhone2,
            this.clmClinetDepoAddres});
            this.grdClient.GridControl = this.dgwClient;
            this.grdClient.Name = "grdClient";
            this.grdClient.OptionsBehavior.Editable = false;
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick);
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 25;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 94;
            // 
            // clmClientNo
            // 
            this.clmClientNo.Caption = "Tedarikçi No";
            this.clmClientNo.FieldName = "ClientNo";
            this.clmClientNo.MinWidth = 25;
            this.clmClientNo.Name = "clmClientNo";
            this.clmClientNo.Visible = true;
            this.clmClientNo.VisibleIndex = 0;
            this.clmClientNo.Width = 94;
            // 
            // clmCardName
            // 
            this.clmCardName.Caption = "Tedarikçi Adı";
            this.clmCardName.FieldName = "CardName";
            this.clmCardName.MinWidth = 25;
            this.clmCardName.Name = "clmCardName";
            this.clmCardName.Visible = true;
            this.clmCardName.VisibleIndex = 1;
            this.clmCardName.Width = 94;
            // 
            // clmClientAddres
            // 
            this.clmClientAddres.Caption = "Adresi";
            this.clmClientAddres.FieldName = "ClientAddres";
            this.clmClientAddres.MinWidth = 25;
            this.clmClientAddres.Name = "clmClientAddres";
            this.clmClientAddres.Visible = true;
            this.clmClientAddres.VisibleIndex = 5;
            this.clmClientAddres.Width = 94;
            // 
            // clmClientPhone
            // 
            this.clmClientPhone.Caption = "Telefon Numarası";
            this.clmClientPhone.FieldName = "ClientPhone";
            this.clmClientPhone.MinWidth = 25;
            this.clmClientPhone.Name = "clmClientPhone";
            this.clmClientPhone.Visible = true;
            this.clmClientPhone.VisibleIndex = 2;
            this.clmClientPhone.Width = 94;
            // 
            // clmClinetPhone2
            // 
            this.clmClinetPhone2.Caption = "Telefon Numarası 2";
            this.clmClinetPhone2.FieldName = "ClinetPhone2";
            this.clmClinetPhone2.MinWidth = 25;
            this.clmClinetPhone2.Name = "clmClinetPhone2";
            this.clmClinetPhone2.Visible = true;
            this.clmClinetPhone2.VisibleIndex = 3;
            this.clmClinetPhone2.Width = 94;
            // 
            // clmClinetDepoAddres
            // 
            this.clmClinetDepoAddres.Caption = "Depo Adresi";
            this.clmClinetDepoAddres.FieldName = "ClinetDepoAddres";
            this.clmClinetDepoAddres.MinWidth = 25;
            this.clmClinetDepoAddres.Name = "clmClinetDepoAddres";
            this.clmClinetDepoAddres.Visible = true;
            this.clmClinetDepoAddres.VisibleIndex = 4;
            this.clmClinetDepoAddres.Width = 94;
            // 
            // frmClinetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 545);
            this.Controls.Add(this.dgwClient);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmClinetList.IconOptions.SvgImage")));
            this.Name = "frmClinetList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Listeleri";
            this.Load += new System.EventHandler(this.frmClinetList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private DevExpress.XtraGrid.GridControl dgwClient;
        private DevExpress.XtraGrid.Views.Grid.GridView grdClient;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmCardName;
        private DevExpress.XtraGrid.Columns.GridColumn clmClientAddres;
        private DevExpress.XtraGrid.Columns.GridColumn clmClientPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmClinetPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn clmClinetDepoAddres;
        private DevExpress.XtraGrid.Columns.GridColumn clmClientNo;
    }
}