namespace marketautomation
{
    partial class frmCatagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatagory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgwCatagory = new DevExpress.XtraGrid.GridControl();
            this.grdCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 58);
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
            this.btnSaved.Size = new System.Drawing.Size(165, 41);
            this.btnSaved.TabIndex = 13;
            this.btnSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgwCatagory);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(440, 549);
            this.panelControl1.TabIndex = 4;
            // 
            // dgwCatagory
            // 
            this.dgwCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCatagory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCatagory.Location = new System.Drawing.Point(2, 2);
            this.dgwCatagory.MainView = this.grdCategory;
            this.dgwCatagory.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCatagory.Name = "dgwCatagory";
            this.dgwCatagory.Size = new System.Drawing.Size(436, 545);
            this.dgwCatagory.TabIndex = 1;
            this.dgwCatagory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCategory});
            // 
            // grdCategory
            // 
            this.grdCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmCategory});
            this.grdCategory.DetailHeight = 437;
            this.grdCategory.GridControl = this.dgwCatagory;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.OptionsCustomization.AllowGroup = false;
            this.grdCategory.OptionsDetail.EnableMasterViewMode = false;
            this.grdCategory.OptionsDetail.SmartDetailExpand = false;
            this.grdCategory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdCategory.OptionsView.ShowDetailButtons = false;
            this.grdCategory.OptionsView.ShowGroupPanel = false;
            this.grdCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdCategory_KeyUp);
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmCategory
            // 
            this.clmCategory.Caption = "Kategoriler";
            this.clmCategory.FieldName = "CardName";
            this.clmCategory.MinWidth = 31;
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.Visible = true;
            this.clmCategory.VisibleIndex = 0;
            this.clmCategory.Width = 117;
            // 
            // frmCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 607);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCatagory.IconOptions.SvgImage")));
            this.Name = "frmCatagory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgwCatagory;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCategory;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmCategory;
    }
}