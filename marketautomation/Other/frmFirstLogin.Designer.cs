namespace marketautomation.Other
{
    partial class frmFirstLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirstLogin));
            this.btnAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCassier = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnWaiter = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnAdmin.color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnAdmin.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImagePosition = 20;
            this.btnAdmin.ImageZoom = 50;
            this.btnAdmin.LabelPosition = 41;
            this.btnAdmin.LabelText = "Yönetici";
            this.btnAdmin.Location = new System.Drawing.Point(64, 249);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(364, 271);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCassier
            // 
            this.btnCassier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCassier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnCassier.color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnCassier.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnCassier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCassier.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCassier.ForeColor = System.Drawing.Color.White;
            this.btnCassier.Image = ((System.Drawing.Image)(resources.GetObject("btnCassier.Image")));
            this.btnCassier.ImagePosition = 20;
            this.btnCassier.ImageZoom = 50;
            this.btnCassier.LabelPosition = 41;
            this.btnCassier.LabelText = "Kasiyer";
            this.btnCassier.Location = new System.Drawing.Point(984, 249);
            this.btnCassier.Margin = new System.Windows.Forms.Padding(6);
            this.btnCassier.Name = "btnCassier";
            this.btnCassier.Size = new System.Drawing.Size(359, 271);
            this.btnCassier.TabIndex = 6;
            this.btnCassier.Click += new System.EventHandler(this.btnCassier_Click);
            // 
            // btnWaiter
            // 
            this.btnWaiter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnWaiter.color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(130)))));
            this.btnWaiter.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.btnWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaiter.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnWaiter.ForeColor = System.Drawing.Color.White;
            this.btnWaiter.Image = ((System.Drawing.Image)(resources.GetObject("btnWaiter.Image")));
            this.btnWaiter.ImagePosition = 20;
            this.btnWaiter.ImageZoom = 50;
            this.btnWaiter.LabelPosition = 41;
            this.btnWaiter.LabelText = "Garson";
            this.btnWaiter.Location = new System.Drawing.Point(520, 249);
            this.btnWaiter.Margin = new System.Windows.Forms.Padding(6);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Size = new System.Drawing.Size(364, 271);
            this.btnWaiter.TabIndex = 5;
            this.btnWaiter.Click += new System.EventHandler(this.btnWaiter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::marketautomation.Properties.Resources._5072612;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1375, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmFirstLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 713);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCassier);
            this.Controls.Add(this.btnWaiter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmFirstLogin.IconOptions.SvgImage")));
            this.Name = "frmFirstLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnCassier;
        private Bunifu.Framework.UI.BunifuTileButton btnAdmin;
        private Bunifu.Framework.UI.BunifuTileButton btnWaiter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}