namespace marketautomation.Finance
{
    partial class frmCaseTransef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaseTransef));
            this.dgwCase = new DevExpress.XtraGrid.GridControl();
            this.grdCase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCardType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledCaseType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmLinelO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledLinelO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCaseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledLinelO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCase
            // 
            this.dgwCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCase.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCase.Location = new System.Drawing.Point(0, 0);
            this.dgwCase.MainView = this.grdCase;
            this.dgwCase.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCase.Name = "dgwCase";
            this.dgwCase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledCaseType,
            this.riledLinelO});
            this.dgwCase.Size = new System.Drawing.Size(1280, 679);
            this.dgwCase.TabIndex = 0;
            this.dgwCase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCase});
            // 
            // grdCase
            // 
            this.grdCase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmCardType,
            this.clmLinelO,
            this.clmDate,
            this.clmTotal});
            this.grdCase.DetailHeight = 437;
            this.grdCase.GridControl = this.dgwCase;
            this.grdCase.Name = "grdCase";
            this.grdCase.OptionsBehavior.Editable = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmCardType
            // 
            this.clmCardType.Caption = "Ödeme Tipi";
            this.clmCardType.ColumnEdit = this.riledCaseType;
            this.clmCardType.FieldName = "CaseType";
            this.clmCardType.MinWidth = 31;
            this.clmCardType.Name = "clmCardType";
            this.clmCardType.Visible = true;
            this.clmCardType.VisibleIndex = 0;
            this.clmCardType.Width = 585;
            // 
            // riledCaseType
            // 
            this.riledCaseType.AutoHeight = false;
            this.riledCaseType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledCaseType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseTypeName", "CaseTypeName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledCaseType.DisplayMember = "CaseTypeName";
            this.riledCaseType.Name = "riledCaseType";
            this.riledCaseType.NullText = "";
            this.riledCaseType.ValueMember = "CaseType";
            // 
            // clmLinelO
            // 
            this.clmLinelO.Caption = "Kasaya-Giriş-Çıkış";
            this.clmLinelO.ColumnEdit = this.riledLinelO;
            this.clmLinelO.FieldName = "LinelO";
            this.clmLinelO.MinWidth = 31;
            this.clmLinelO.Name = "clmLinelO";
            this.clmLinelO.Visible = true;
            this.clmLinelO.VisibleIndex = 1;
            this.clmLinelO.Width = 444;
            // 
            // riledLinelO
            // 
            this.riledLinelO.AutoHeight = false;
            this.riledLinelO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledLinelO.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LinelName", "LinelName", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.riledLinelO.DisplayMember = "LinelName";
            this.riledLinelO.Name = "riledLinelO";
            this.riledLinelO.NullText = "";
            this.riledLinelO.ValueMember = "LinelO";
            // 
            // clmDate
            // 
            this.clmDate.Caption = "Tarih";
            this.clmDate.FieldName = "Date_";
            this.clmDate.MinWidth = 31;
            this.clmDate.Name = "clmDate";
            this.clmDate.Visible = true;
            this.clmDate.VisibleIndex = 3;
            this.clmDate.Width = 271;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Toplam";
            this.clmTotal.FieldName = "Total";
            this.clmTotal.MinWidth = 31;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 2;
            this.clmTotal.Width = 262;
            // 
            // frmCaseTransef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 679);
            this.Controls.Add(this.dgwCase);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCaseTransef.IconOptions.SvgImage")));
            this.Name = "frmCaseTransef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCaseTransef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledCaseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledLinelO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwCase;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCase;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmCardType;
        private DevExpress.XtraGrid.Columns.GridColumn clmLinelO;
        private DevExpress.XtraGrid.Columns.GridColumn clmDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledCaseType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledLinelO;
    }
}