namespace marketautomation.Unit
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgwUnit = new DevExpress.XtraGrid.GridControl();
            this.grdUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnit)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgwUnit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 49);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(440, 558);
            this.panelControl2.TabIndex = 3;
            // 
            // dgwUnit
            // 
            this.dgwUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUnit.Location = new System.Drawing.Point(2, 2);
            this.dgwUnit.MainView = this.grdUnit;
            this.dgwUnit.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUnit.Name = "dgwUnit";
            this.dgwUnit.Size = new System.Drawing.Size(436, 554);
            this.dgwUnit.TabIndex = 1;
            this.dgwUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUnit});
            this.dgwUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwUnit_KeyUp);
            // 
            // grdUnit
            // 
            this.grdUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmUnit});
            this.grdUnit.DetailHeight = 437;
            this.grdUnit.GridControl = this.dgwUnit;
            this.grdUnit.Name = "grdUnit";
            this.grdUnit.OptionsCustomization.AllowGroup = false;
            this.grdUnit.OptionsDetail.EnableMasterViewMode = false;
            this.grdUnit.OptionsDetail.SmartDetailExpand = false;
            this.grdUnit.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdUnit.OptionsView.ShowDetailButtons = false;
            this.grdUnit.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmUnit
            // 
            this.clmUnit.Caption = "Birim Adı";
            this.clmUnit.FieldName = "CardName";
            this.clmUnit.MinWidth = 31;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.Visible = true;
            this.clmUnit.VisibleIndex = 0;
            this.clmUnit.Width = 117;
            // 
            // frmUnit
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 607);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUnit.IconOptions.SvgImage")));
            this.Name = "frmUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birimler";
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgwUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnit;
    }
}