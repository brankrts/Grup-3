
namespace WindowsFormsApp1.ChildForms
{
    partial class FrmLogin
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTC = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnTryLogin = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblUyari);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassword);
            this.guna2ShadowPanel1.Controls.Add(this.txtTC);
            this.guna2ShadowPanel1.Controls.Add(this.btnTryLogin);
            this.guna2ShadowPanel1.Controls.Add(this.bunifuCheckbox1);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.EdgeWidth = 1;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(100, 73);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.ShadowDepth = 250;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(775, 473);
            this.guna2ShadowPanel1.TabIndex = 61;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.White;
            this.lblUyari.Location = new System.Drawing.Point(355, 421);
            this.lblUyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 20);
            this.lblUyari.TabIndex = 73;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(308, 217);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(216, 43);
            this.txtPassword.TabIndex = 72;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTC.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTC.Location = new System.Drawing.Point(308, 130);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTC.Name = "txtTC";
            this.txtTC.PasswordChar = '\0';
            this.txtTC.SelectedText = "";
            this.txtTC.Size = new System.Drawing.Size(216, 43);
            this.txtTC.TabIndex = 71;
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTryLogin
            // 
            this.btnTryLogin.BorderRadius = 20;
            this.btnTryLogin.CheckedState.Parent = this.btnTryLogin;
            this.btnTryLogin.CustomImages.Parent = this.btnTryLogin;
            this.btnTryLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTryLogin.ForeColor = System.Drawing.Color.White;
            this.btnTryLogin.HoverState.Parent = this.btnTryLogin;
            this.btnTryLogin.Location = new System.Drawing.Point(253, 362);
            this.btnTryLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTryLogin.Name = "btnTryLogin";
            this.btnTryLogin.ShadowDecoration.Parent = this.btnTryLogin;
            this.btnTryLogin.Size = new System.Drawing.Size(271, 36);
            this.btnTryLogin.TabIndex = 70;
            this.btnTryLogin.Text = "Giriş Yap";
            this.btnTryLogin.Click += new System.EventHandler(this.btnTryLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(340, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Beni Hatırla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 66;
            this.label2.Text = "Size sunulan tüm özelliklerden \r\nfaydalanmak için giriş yapın !\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "TC :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(256, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Şifre :";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.LightBlue;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Silver;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.LightBlue;
            this.bunifuCheckbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(306, 300);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 69;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(976, 617);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTryLogin;
        private Guna.UI.WinForms.GunaLineTextBox txtPassword;
        private Guna.UI.WinForms.GunaLineTextBox txtTC;
        private System.Windows.Forms.Label lblUyari;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
    }
}