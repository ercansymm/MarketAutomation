namespace marketautomation.Employee
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglsActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grdUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.usrRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usrUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPersoneltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledPersonelType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmUserPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usrDescriptions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usrCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgwUserkList = new DevExpress.XtraGrid.GridControl();
            this.riledPassive = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledPersonelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserkList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledPassive)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.tglsActive);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 74);
            this.panel1.TabIndex = 24;
            // 
            // tglsActive
            // 
            this.tglsActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.tglsActive.Location = new System.Drawing.Point(1124, 0);
            this.tglsActive.Name = "tglsActive";
            this.tglsActive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.tglsActive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglsActive.Properties.Appearance.Options.UseFont = true;
            this.tglsActive.Properties.Appearance.Options.UseForeColor = true;
            this.tglsActive.Properties.OffText = "Pasif Personel";
            this.tglsActive.Properties.OnText = "Aktif Personel";
            this.tglsActive.Size = new System.Drawing.Size(274, 74);
            this.tglsActive.TabIndex = 24;
            this.tglsActive.Toggled += new System.EventHandler(this.tglsActive_Toggled);
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
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSaved.ButtonText = "Yeni";
            this.btnSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaved.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.IdleBorderThickness = 1;
            this.btnSaved.IdleCornerRadius = 30;
            this.btnSaved.IdleFillColor = System.Drawing.Color.White;
            this.btnSaved.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSaved.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSaved.Location = new System.Drawing.Point(14, 14);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(163, 51);
            this.btnSaved.TabIndex = 22;
            this.btnSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // grdUserList
            // 
            this.grdUserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.usrRef,
            this.usrUserName,
            this.clmPersoneltype,
            this.clmUserPhone,
            this.usrDescriptions,
            this.usrCardName,
            this.clmUserAddress});
            this.grdUserList.DetailHeight = 437;
            this.grdUserList.GridControl = this.dgwUserkList;
            this.grdUserList.Name = "grdUserList";
            this.grdUserList.OptionsBehavior.Editable = false;
            this.grdUserList.OptionsCustomization.AllowFilter = false;
            this.grdUserList.OptionsPrint.EnableAppearanceEvenRow = true;
            this.grdUserList.OptionsPrint.PrintGroupFooter = false;
            this.grdUserList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdUserList.OptionsView.ShowGroupPanel = false;
            this.grdUserList.PaintStyleName = "Web";
            // 
            // usrRef
            // 
            this.usrRef.Caption = "Ref";
            this.usrRef.FieldName = "Ref";
            this.usrRef.MinWidth = 31;
            this.usrRef.Name = "usrRef";
            this.usrRef.Width = 117;
            // 
            // usrUserName
            // 
            this.usrUserName.Caption = "Kullanıcı Ad";
            this.usrUserName.FieldName = "UserName";
            this.usrUserName.MinWidth = 31;
            this.usrUserName.Name = "usrUserName";
            this.usrUserName.Visible = true;
            this.usrUserName.VisibleIndex = 1;
            this.usrUserName.Width = 274;
            // 
            // clmPersoneltype
            // 
            this.clmPersoneltype.Caption = "Personel Tipi";
            this.clmPersoneltype.ColumnEdit = this.riledPersonelType;
            this.clmPersoneltype.FieldName = "UserStatus";
            this.clmPersoneltype.MinWidth = 31;
            this.clmPersoneltype.Name = "clmPersoneltype";
            this.clmPersoneltype.Visible = true;
            this.clmPersoneltype.VisibleIndex = 3;
            this.clmPersoneltype.Width = 154;
            // 
            // riledPersonelType
            // 
            this.riledPersonelType.AutoHeight = false;
            this.riledPersonelType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledPersonelType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StateName", "StateName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledPersonelType.DisplayMember = "StateName";
            this.riledPersonelType.Name = "riledPersonelType";
            this.riledPersonelType.NullText = "";
            this.riledPersonelType.ValueMember = "State";
            // 
            // clmUserPhone
            // 
            this.clmUserPhone.Caption = "Telefon Numarası";
            this.clmUserPhone.FieldName = "UserPhone";
            this.clmUserPhone.MinWidth = 31;
            this.clmUserPhone.Name = "clmUserPhone";
            this.clmUserPhone.Visible = true;
            this.clmUserPhone.VisibleIndex = 2;
            this.clmUserPhone.Width = 249;
            // 
            // usrDescriptions
            // 
            this.usrDescriptions.Caption = "Açıklama";
            this.usrDescriptions.FieldName = "Description";
            this.usrDescriptions.MinWidth = 31;
            this.usrDescriptions.Name = "usrDescriptions";
            this.usrDescriptions.Visible = true;
            this.usrDescriptions.VisibleIndex = 4;
            this.usrDescriptions.Width = 202;
            // 
            // usrCardName
            // 
            this.usrCardName.Caption = "Adı Soyad";
            this.usrCardName.FieldName = "CardName";
            this.usrCardName.MinWidth = 31;
            this.usrCardName.Name = "usrCardName";
            this.usrCardName.Visible = true;
            this.usrCardName.VisibleIndex = 0;
            this.usrCardName.Width = 214;
            // 
            // clmUserAddress
            // 
            this.clmUserAddress.Caption = "Adres";
            this.clmUserAddress.FieldName = "UserAddress";
            this.clmUserAddress.MinWidth = 31;
            this.clmUserAddress.Name = "clmUserAddress";
            this.clmUserAddress.Visible = true;
            this.clmUserAddress.VisibleIndex = 5;
            this.clmUserAddress.Width = 192;
            // 
            // dgwUserkList
            // 
            this.dgwUserkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUserkList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgwUserkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dgwUserkList.Location = new System.Drawing.Point(0, 0);
            this.dgwUserkList.MainView = this.grdUserList;
            this.dgwUserkList.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUserkList.Name = "dgwUserkList";
            this.dgwUserkList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledPersonelType,
            this.riledPassive});
            this.dgwUserkList.Size = new System.Drawing.Size(1398, 471);
            this.dgwUserkList.TabIndex = 23;
            this.dgwUserkList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUserList});
            this.dgwUserkList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwUserkList_MouseDoubleClick);
            // 
            // riledPassive
            // 
            this.riledPassive.AutoHeight = false;
            this.riledPassive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledPassive.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledPassive.DisplayMember = "CardName";
            this.riledPassive.Name = "riledPassive";
            this.riledPassive.NullText = "";
            this.riledPassive.ShowFooter = false;
            this.riledPassive.ShowHeader = false;
            this.riledPassive.ValueMember = "IsPassive";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwUserkList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 471);
            this.panel2.TabIndex = 25;
            // 
            // FrmUsers
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmUsers.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledPersonelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserkList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledPassive)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUserList;
        private DevExpress.XtraGrid.Columns.GridColumn usrRef;
        private DevExpress.XtraGrid.Columns.GridColumn usrUserName;
        private DevExpress.XtraGrid.Columns.GridColumn usrDescriptions;
        private DevExpress.XtraGrid.GridControl dgwUserkList;
        private DevExpress.XtraGrid.Columns.GridColumn clmPersoneltype;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserPhone;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledPersonelType;
        private DevExpress.XtraGrid.Columns.GridColumn usrCardName;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledPassive;
        private DevExpress.XtraEditors.ToggleSwitch tglsActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}