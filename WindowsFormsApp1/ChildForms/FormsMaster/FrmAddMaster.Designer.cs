
namespace WindowsFormsApp1.ChildForms.FrmMaster
{
    partial class frmAddMaster
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
            this.btnAddFlightToDb = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmCinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSifreTekrar = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSifre = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTel = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSoyad = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtMail = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAd = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTC = new Guna.UI.WinForms.GunaLineTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbYetki = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUyari = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnAddFlightToDb
            // 
            this.btnAddFlightToDb.BorderRadius = 20;
            this.btnAddFlightToDb.CheckedState.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.CustomImages.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFlightToDb.ForeColor = System.Drawing.Color.White;
            this.btnAddFlightToDb.HoverState.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Location = new System.Drawing.Point(294, 486);
            this.btnAddFlightToDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFlightToDb.Name = "btnAddFlightToDb";
            this.btnAddFlightToDb.ShadowDecoration.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Size = new System.Drawing.Size(269, 43);
            this.btnAddFlightToDb.TabIndex = 7;
            this.btnAddFlightToDb.Text = "Yönetici Ekle";
            this.btnAddFlightToDb.Click += new System.EventHandler(this.btnAddFlightToDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Cinsiyet";
            // 
            // cbmCinsiyet
            // 
            this.cbmCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.cbmCinsiyet.BorderRadius = 20;
            this.cbmCinsiyet.BorderThickness = 3;
            this.cbmCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmCinsiyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.cbmCinsiyet.FocusedColor = System.Drawing.Color.Empty;
            this.cbmCinsiyet.FocusedState.Parent = this.cbmCinsiyet;
            this.cbmCinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmCinsiyet.ForeColor = System.Drawing.Color.White;
            this.cbmCinsiyet.FormattingEnabled = true;
            this.cbmCinsiyet.HoverState.Parent = this.cbmCinsiyet;
            this.cbmCinsiyet.ItemHeight = 30;
            this.cbmCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbmCinsiyet.ItemsAppearance.Parent = this.cbmCinsiyet;
            this.cbmCinsiyet.Location = new System.Drawing.Point(442, 128);
            this.cbmCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cbmCinsiyet.Name = "cbmCinsiyet";
            this.cbmCinsiyet.ShadowDecoration.Parent = this.cbmCinsiyet;
            this.cbmCinsiyet.Size = new System.Drawing.Size(204, 36);
            this.cbmCinsiyet.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbmCinsiyet.TabIndex = 99;
            this.cbmCinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtSifreTekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifreTekrar.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifreTekrar.ForeColor = System.Drawing.Color.White;
            this.txtSifreTekrar.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSifreTekrar.Location = new System.Drawing.Point(442, 326);
            this.txtSifreTekrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.SelectedText = "";
            this.txtSifreTekrar.Size = new System.Drawing.Size(200, 37);
            this.txtSifreTekrar.TabIndex = 98;
            this.txtSifreTekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSifre.Location = new System.Drawing.Point(215, 326);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(179, 37);
            this.txtSifre.TabIndex = 97;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTel.Location = new System.Drawing.Point(443, 255);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.SelectedText = "";
            this.txtTel.Size = new System.Drawing.Size(200, 37);
            this.txtTel.TabIndex = 96;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSoyad.Location = new System.Drawing.Point(443, 187);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.Size = new System.Drawing.Size(200, 37);
            this.txtSoyad.TabIndex = 95;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMail.Location = new System.Drawing.Point(215, 255);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(179, 37);
            this.txtMail.TabIndex = 94;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAd.Location = new System.Drawing.Point(215, 187);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(179, 37);
            this.txtAd.TabIndex = 93;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTC.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTC.Location = new System.Drawing.Point(215, 127);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.PasswordChar = '\0';
            this.txtTC.SelectedText = "";
            this.txtTC.Size = new System.Drawing.Size(179, 37);
            this.txtTC.TabIndex = 92;
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(211, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(439, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Şifre Tekrar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(211, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 86;
            this.label8.Text = "E-Posta :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(439, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 85;
            this.label9.Text = "Soyad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(440, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 84;
            this.label10.Text = "Telefon :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(211, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Ad :";
            // 
            // cmbYetki
            // 
            this.cmbYetki.BackColor = System.Drawing.Color.Transparent;
            this.cmbYetki.BorderRadius = 20;
            this.cmbYetki.BorderThickness = 3;
            this.cmbYetki.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYetki.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.cmbYetki.FocusedColor = System.Drawing.Color.Empty;
            this.cmbYetki.FocusedState.Parent = this.cmbYetki;
            this.cmbYetki.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYetki.ForeColor = System.Drawing.Color.White;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.HoverState.Parent = this.cmbYetki;
            this.cmbYetki.ItemHeight = 30;
            this.cmbYetki.Items.AddRange(new object[] {
            "master",
            "normal"});
            this.cmbYetki.ItemsAppearance.Parent = this.cmbYetki;
            this.cmbYetki.Location = new System.Drawing.Point(326, 409);
            this.cmbYetki.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.ShadowDecoration.Parent = this.cmbYetki;
            this.cmbYetki.Size = new System.Drawing.Size(204, 36);
            this.cmbYetki.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbYetki.TabIndex = 101;
            this.cmbYetki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Yetki :";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUyari.ForeColor = System.Drawing.Color.White;
            this.lblUyari.Location = new System.Drawing.Point(389, 46);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 20);
            this.lblUyari.TabIndex = 103;
            // 
            // frmAddMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1052, 576);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmCinsiyet);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddFlightToDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddMaster";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddFlightToDb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbmCinsiyet;
        private Guna.UI.WinForms.GunaLineTextBox txtSifreTekrar;
        private Guna.UI.WinForms.GunaLineTextBox txtSifre;
        private Guna.UI.WinForms.GunaLineTextBox txtTel;
        private Guna.UI.WinForms.GunaLineTextBox txtSoyad;
        private Guna.UI.WinForms.GunaLineTextBox txtMail;
        private Guna.UI.WinForms.GunaLineTextBox txtAd;
        private Guna.UI.WinForms.GunaLineTextBox txtTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYetki;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel lblUyari;
    }
}