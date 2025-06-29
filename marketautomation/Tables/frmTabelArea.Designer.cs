namespace marketautomation.Tables
{
    partial class frmTabelArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabelArea));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgwArea = new DevExpress.XtraGrid.GridControl();
            this.grdArea = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(440, 607);
            this.panelControl2.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgwArea);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 554);
            this.panelControl1.TabIndex = 6;
            // 
            // dgwArea
            // 
            this.dgwArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwArea.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwArea.Location = new System.Drawing.Point(2, 2);
            this.dgwArea.MainView = this.grdArea;
            this.dgwArea.Margin = new System.Windows.Forms.Padding(4);
            this.dgwArea.Name = "dgwArea";
            this.dgwArea.Size = new System.Drawing.Size(432, 550);
            this.dgwArea.TabIndex = 2;
            this.dgwArea.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdArea});
            this.dgwArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwArea_KeyUp);
            // 
            // grdArea
            // 
            this.grdArea.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmArea});
            this.grdArea.DetailHeight = 437;
            this.grdArea.GridControl = this.dgwArea;
            this.grdArea.Name = "grdArea";
            this.grdArea.OptionsCustomization.AllowGroup = false;
            this.grdArea.OptionsDetail.EnableMasterViewMode = false;
            this.grdArea.OptionsDetail.SmartDetailExpand = false;
            this.grdArea.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdArea.OptionsView.ShowDetailButtons = false;
            this.grdArea.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmArea
            // 
            this.clmArea.Caption = "Alan Adı";
            this.clmArea.FieldName = "CardName";
            this.clmArea.MinWidth = 31;
            this.clmArea.Name = "clmArea";
            this.clmArea.Visible = true;
            this.clmArea.VisibleIndex = 0;
            this.clmArea.Width = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 49);
            this.panel1.TabIndex = 5;
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
            this.btnSaved.Location = new System.Drawing.Point(5, 3);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(165, 41);
            this.btnSaved.TabIndex = 13;
            this.btnSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // frmTabelArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 607);
            this.Controls.Add(this.panelControl2);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmTabelArea.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabelArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alanlar";
            this.Load += new System.EventHandler(this.frmTabelArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgwArea;
        private DevExpress.XtraGrid.Views.Grid.GridView grdArea;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmArea;
    }
}