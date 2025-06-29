namespace marketautomation.Stock
{
    partial class frmSubCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ledSub = new DevExpress.XtraEditors.LookUpEdit();
            this.dgwSub = new DevExpress.XtraGrid.GridControl();
            this.grdSub = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSub)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 49);
            this.panel1.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Controls.Add(this.ledSub);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 47);
            this.panel2.TabIndex = 6;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(14, 17);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(88, 20);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Üst Kategori";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ledSub
            // 
            this.ledSub.Location = new System.Drawing.Point(108, 15);
            this.ledSub.Name = "ledSub";
            this.ledSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledSub.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.ledSub.Properties.DisplayMember = "CardName";
            this.ledSub.Properties.NullText = "";
            this.ledSub.Properties.ShowFooter = false;
            this.ledSub.Properties.ShowHeader = false;
            this.ledSub.Properties.ValueMember = "Ref";
            this.ledSub.Size = new System.Drawing.Size(252, 22);
            this.ledSub.TabIndex = 0;
            this.ledSub.EditValueChanged += new System.EventHandler(this.ledSub_EditValueChanged);
            // 
            // dgwSub
            // 
            this.dgwSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSub.Location = new System.Drawing.Point(0, 96);
            this.dgwSub.MainView = this.grdSub;
            this.dgwSub.Name = "dgwSub";
            this.dgwSub.Size = new System.Drawing.Size(440, 511);
            this.dgwSub.TabIndex = 7;
            this.dgwSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdSub});
            // 
            // grdSub
            // 
            this.grdSub.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.SubCategory});
            this.grdSub.GridControl = this.dgwSub;
            this.grdSub.Name = "grdSub";
            this.grdSub.OptionsDetail.EnableMasterViewMode = false;
            this.grdSub.OptionsDetail.ShowDetailTabs = false;
            this.grdSub.OptionsDetail.SmartDetailExpand = false;
            this.grdSub.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.grdSub.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdSub.OptionsView.ShowDetailButtons = false;
            this.grdSub.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "grdRef";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 25;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 94;
            // 
            // SubCategory
            // 
            this.SubCategory.Caption = "Alt Kategorileri";
            this.SubCategory.FieldName = "CardName";
            this.SubCategory.MinWidth = 25;
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.Visible = true;
            this.SubCategory.VisibleIndex = 0;
            this.SubCategory.Width = 531;
            // 
            // frmSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 607);
            this.Controls.Add(this.dgwSub);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubCategory";
            this.Text = "frmSubCategory";
            this.Load += new System.EventHandler(this.frmSubCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private DevExpress.XtraEditors.LookUpEdit ledSub;
        private DevExpress.XtraGrid.GridControl dgwSub;
        private DevExpress.XtraGrid.Views.Grid.GridView grdSub;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn SubCategory;
    }
}