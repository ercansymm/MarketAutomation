namespace marketautomation.Fiche
{
    partial class frmStockLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockLines));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledDocType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grdStockLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmFishNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmFishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClinet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledClinetRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dgwStockLine = new DevExpress.XtraGrid.GridControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledDocType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledClinetRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockLine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.ledDocType);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 74);
            this.panel1.TabIndex = 25;
            // 
            // ledDocType
            // 
            this.ledDocType.Location = new System.Drawing.Point(1091, 11);
            this.ledDocType.Name = "ledDocType";
            this.ledDocType.Properties.Appearance.BackColor = System.Drawing.Color.Coral;
            this.ledDocType.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ledDocType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ledDocType.Properties.Appearance.Options.UseBackColor = true;
            this.ledDocType.Properties.Appearance.Options.UseFont = true;
            this.ledDocType.Properties.Appearance.Options.UseForeColor = true;
            this.ledDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledDocType.Properties.NullText = "";
            this.ledDocType.Size = new System.Drawing.Size(270, 28);
            this.ledDocType.TabIndex = 24;
            this.ledDocType.EditValueChanged += new System.EventHandler(this.ledDocType_EditValueChanged);
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
            // grdStockLine
            // 
            this.grdStockLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmFishNo,
            this.clmFishDate,
            this.clmDescription,
            this.clmClinet});
            this.grdStockLine.GridControl = this.dgwStockLine;
            this.grdStockLine.Name = "grdStockLine";
            this.grdStockLine.OptionsBehavior.Editable = false;
            this.grdStockLine.OptionsView.ShowGroupPanel = false;
            this.grdStockLine.DoubleClick += new System.EventHandler(this.grdStockLine_DoubleClick);
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 25;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 94;
            // 
            // clmFishNo
            // 
            this.clmFishNo.Caption = "Fiş Numarası";
            this.clmFishNo.FieldName = "FishNo";
            this.clmFishNo.MinWidth = 25;
            this.clmFishNo.Name = "clmFishNo";
            this.clmFishNo.Visible = true;
            this.clmFishNo.VisibleIndex = 0;
            this.clmFishNo.Width = 201;
            // 
            // clmFishDate
            // 
            this.clmFishDate.Caption = "Tarihi";
            this.clmFishDate.FieldName = "FishDate";
            this.clmFishDate.MinWidth = 25;
            this.clmFishDate.Name = "clmFishDate";
            this.clmFishDate.Visible = true;
            this.clmFishDate.VisibleIndex = 1;
            this.clmFishDate.Width = 234;
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Açıklama";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.MinWidth = 25;
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 3;
            this.clmDescription.Width = 635;
            // 
            // clmClinet
            // 
            this.clmClinet.Caption = "Tedarikçi";
            this.clmClinet.ColumnEdit = this.riledClinetRef;
            this.clmClinet.FieldName = "ClinetRef";
            this.clmClinet.MinWidth = 25;
            this.clmClinet.Name = "clmClinet";
            this.clmClinet.Visible = true;
            this.clmClinet.VisibleIndex = 2;
            this.clmClinet.Width = 298;
            // 
            // riledClinetRef
            // 
            this.riledClinetRef.AutoHeight = false;
            this.riledClinetRef.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledClinetRef.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledClinetRef.DisplayMember = "CardName";
            this.riledClinetRef.Name = "riledClinetRef";
            this.riledClinetRef.NullText = "";
            this.riledClinetRef.ShowHeader = false;
            this.riledClinetRef.ShowLines = false;
            this.riledClinetRef.ValueMember = "ClinetRef";
            // 
            // dgwStockLine
            // 
            this.dgwStockLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStockLine.Location = new System.Drawing.Point(0, 74);
            this.dgwStockLine.MainView = this.grdStockLine;
            this.dgwStockLine.Name = "dgwStockLine";
            this.dgwStockLine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledClinetRef});
            this.dgwStockLine.Size = new System.Drawing.Size(1398, 471);
            this.dgwStockLine.TabIndex = 26;
            this.dgwStockLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdStockLine});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tedarikçi";
            this.gridColumn1.ColumnEdit = this.riledClinetRef;
            this.gridColumn1.FieldName = "Ref";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 307;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tedarikçi";
            this.gridColumn2.ColumnEdit = this.riledClinetRef;
            this.gridColumn2.FieldName = "Ref";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 307;
            // 
            // frmStockLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 545);
            this.Controls.Add(this.dgwStockLine);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockLines.IconOptions.SvgImage")));
            this.Name = "frmStockLines";
            this.Text = "Stok Takip Paneli";
            this.Load += new System.EventHandler(this.frmStockLines_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledDocType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledClinetRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private DevExpress.XtraEditors.LookUpEdit ledDocType;
        private DevExpress.XtraGrid.Views.Grid.GridView grdStockLine;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmFishDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private DevExpress.XtraGrid.GridControl dgwStockLine;
        private DevExpress.XtraGrid.Columns.GridColumn clmFishNo;
        private DevExpress.XtraGrid.Columns.GridColumn clmClinet;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledClinetRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}