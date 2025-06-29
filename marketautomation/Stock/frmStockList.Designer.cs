namespace marketautomation.Stock
{
    partial class frmStockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwProduct = new DevExpress.XtraGrid.GridControl();
            this.grdProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdSpecialCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCardPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdSubCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledSub = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1398, 74);
            this.panel1.TabIndex = 1;
            // 
            // tglActive
            // 
            this.tglActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(1176, 0);
            this.tglActive.Name = "tglActive";
            this.tglActive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F);
            this.tglActive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglActive.Properties.Appearance.Options.UseFont = true;
            this.tglActive.Properties.Appearance.Options.UseForeColor = true;
            this.tglActive.Properties.OffText = "Pasif Ürünler";
            this.tglActive.Properties.OnText = "Aktif Ürünler";
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
            // dgwProduct
            // 
            this.dgwProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.dgwProduct.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgwProduct.Location = new System.Drawing.Point(0, 74);
            this.dgwProduct.MainView = this.grdProduct;
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(6);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledUnit,
            this.riledCategory,
            this.riledSub});
            this.dgwProduct.Size = new System.Drawing.Size(1398, 471);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProduct});
            // 
            // grdProduct
            // 
            this.grdProduct.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.grdProduct.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdUnit,
            this.grdRef,
            this.grdBarcode,
            this.grdKdv,
            this.grdSpecialCode,
            this.grdCardPrice,
            this.grdCardName,
            this.grdDescription,
            this.grdCategory,
            this.grdSubCategory});
            this.grdProduct.DetailHeight = 682;
            this.grdProduct.GridControl = this.dgwProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.OptionsBehavior.Editable = false;
            this.grdProduct.OptionsPrint.EnableAppearanceEvenRow = true;
            this.grdProduct.OptionsPrint.PrintGroupFooter = false;
            this.grdProduct.OptionsPrint.PrintHorzLines = false;
            this.grdProduct.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdProduct.OptionsView.ShowGroupPanel = false;
            this.grdProduct.DoubleClick += new System.EventHandler(this.grdProduct_DoubleClick);
            // 
            // grdUnit
            // 
            this.grdUnit.Caption = "Birimi";
            this.grdUnit.ColumnEdit = this.riledUnit;
            this.grdUnit.FieldName = "UnitRef";
            this.grdUnit.MinWidth = 49;
            this.grdUnit.Name = "grdUnit";
            this.grdUnit.OptionsColumn.AllowEdit = false;
            this.grdUnit.Visible = true;
            this.grdUnit.VisibleIndex = 2;
            this.grdUnit.Width = 175;
            // 
            // riledUnit
            // 
            this.riledUnit.AutoHeight = false;
            this.riledUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledUnit.DisplayMember = "CardName";
            this.riledUnit.Name = "riledUnit";
            this.riledUnit.NullText = "";
            this.riledUnit.ValueMember = "UnitRef";
            // 
            // grdRef
            // 
            this.grdRef.Caption = "Ref";
            this.grdRef.FieldName = "Ref";
            this.grdRef.MinWidth = 49;
            this.grdRef.Name = "grdRef";
            this.grdRef.Width = 182;
            // 
            // grdBarcode
            // 
            this.grdBarcode.Caption = "Barkod";
            this.grdBarcode.FieldName = "Barcode";
            this.grdBarcode.MinWidth = 49;
            this.grdBarcode.Name = "grdBarcode";
            this.grdBarcode.OptionsColumn.AllowEdit = false;
            this.grdBarcode.Visible = true;
            this.grdBarcode.VisibleIndex = 6;
            this.grdBarcode.Width = 121;
            // 
            // grdKdv
            // 
            this.grdKdv.Caption = "Kdv";
            this.grdKdv.FieldName = "Kdv";
            this.grdKdv.MinWidth = 49;
            this.grdKdv.Name = "grdKdv";
            this.grdKdv.OptionsColumn.AllowEdit = false;
            this.grdKdv.Visible = true;
            this.grdKdv.VisibleIndex = 5;
            this.grdKdv.Width = 142;
            // 
            // grdSpecialCode
            // 
            this.grdSpecialCode.Caption = "Özel Kod";
            this.grdSpecialCode.FieldName = "SpecialCode";
            this.grdSpecialCode.MinWidth = 49;
            this.grdSpecialCode.Name = "grdSpecialCode";
            this.grdSpecialCode.OptionsColumn.AllowEdit = false;
            this.grdSpecialCode.Visible = true;
            this.grdSpecialCode.VisibleIndex = 7;
            this.grdSpecialCode.Width = 83;
            // 
            // grdCardPrice
            // 
            this.grdCardPrice.Caption = "Fiyat";
            this.grdCardPrice.FieldName = "CardPrice";
            this.grdCardPrice.MinWidth = 49;
            this.grdCardPrice.Name = "grdCardPrice";
            this.grdCardPrice.OptionsColumn.AllowEdit = false;
            this.grdCardPrice.Visible = true;
            this.grdCardPrice.VisibleIndex = 1;
            this.grdCardPrice.Width = 175;
            // 
            // grdCardName
            // 
            this.grdCardName.Caption = "Ürün Adı";
            this.grdCardName.FieldName = "CardName";
            this.grdCardName.MinWidth = 49;
            this.grdCardName.Name = "grdCardName";
            this.grdCardName.OptionsColumn.AllowEdit = false;
            this.grdCardName.Visible = true;
            this.grdCardName.VisibleIndex = 0;
            this.grdCardName.Width = 175;
            // 
            // grdDescription
            // 
            this.grdDescription.Caption = "açıklama";
            this.grdDescription.FieldName = "Description";
            this.grdDescription.MinWidth = 49;
            this.grdDescription.Name = "grdDescription";
            this.grdDescription.OptionsColumn.AllowEdit = false;
            this.grdDescription.Visible = true;
            this.grdDescription.VisibleIndex = 8;
            this.grdDescription.Width = 134;
            // 
            // grdCategory
            // 
            this.grdCategory.Caption = "Kategori";
            this.grdCategory.ColumnEdit = this.riledCategory;
            this.grdCategory.FieldName = "CategoryRef";
            this.grdCategory.MinWidth = 25;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Visible = true;
            this.grdCategory.VisibleIndex = 3;
            this.grdCategory.Width = 216;
            // 
            // riledCategory
            // 
            this.riledCategory.AutoHeight = false;
            this.riledCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledCategory.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledCategory.DisplayMember = "CardName";
            this.riledCategory.Name = "riledCategory";
            this.riledCategory.NullText = "";
            this.riledCategory.ValueMember = "CategoryRef";
            // 
            // grdSubCategory
            // 
            this.grdSubCategory.Caption = "Alt Kategorisi";
            this.grdSubCategory.ColumnEdit = this.riledSub;
            this.grdSubCategory.FieldName = "SubCategoryRef";
            this.grdSubCategory.MinWidth = 25;
            this.grdSubCategory.Name = "grdSubCategory";
            this.grdSubCategory.Visible = true;
            this.grdSubCategory.VisibleIndex = 4;
            this.grdSubCategory.Width = 147;
            // 
            // riledSub
            // 
            this.riledSub.AutoHeight = false;
            this.riledSub.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledSub.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledSub.DisplayMember = "CardName";
            this.riledSub.Name = "riledSub";
            this.riledSub.NullText = "";
            this.riledSub.ShowHeader = false;
            this.riledSub.ShowLines = false;
            this.riledSub.ValueMember = "SubCategoryRef";
            // 
            // frmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 545);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockList.IconOptions.SvgImage")));
            this.Name = "frmStockList";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStockListt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private DevExpress.XtraGrid.GridControl dgwProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProduct;
        private DevExpress.XtraGrid.Columns.GridColumn grdRef;
        private DevExpress.XtraGrid.Columns.GridColumn grdBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn grdKdv;
        private DevExpress.XtraGrid.Columns.GridColumn grdSpecialCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdCardPrice;
        private DevExpress.XtraGrid.Columns.GridColumn grdCardName;
        private DevExpress.XtraGrid.Columns.GridColumn grdUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnit;
        private DevExpress.XtraGrid.Columns.GridColumn grdDescription;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledCategory;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn grdSubCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledSub;
    }
}