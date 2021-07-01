
namespace WindowsFormsApp1.ChildForms
{
    partial class FrmAccountInfo
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
            this.pnlHesab = new System.Windows.Forms.Panel();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoyadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.db_FlightDataSet = new WindowsFormsApp1.db_FlightDataSet();
            this.dbFlightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHesab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHesab
            // 
            this.pnlHesab.Controls.Add(this.btnKaydet);
            this.pnlHesab.Controls.Add(this.btnGuncelle);
            this.pnlHesab.Controls.Add(this.gunaLabel4);
            this.pnlHesab.Controls.Add(this.gunaLabel3);
            this.pnlHesab.Controls.Add(this.gunaLabel2);
            this.pnlHesab.Controls.Add(this.gunaLabel1);
            this.pnlHesab.Controls.Add(this.txtMail);
            this.pnlHesab.Controls.Add(this.txtTel);
            this.pnlHesab.Controls.Add(this.txtSoyadi);
            this.pnlHesab.Controls.Add(this.txtAdi);
            this.pnlHesab.Location = new System.Drawing.Point(0, 2);
            this.pnlHesab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHesab.Name = "pnlHesab";
            this.pnlHesab.Size = new System.Drawing.Size(997, 609);
            this.pnlHesab.TabIndex = 5;
            this.pnlHesab.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHesab_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderRadius = 20;
            this.btnKaydet.CheckedState.Parent = this.btnKaydet;
            this.btnKaydet.CustomImages.Parent = this.btnKaydet;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.HoverState.Parent = this.btnKaydet;
            this.btnKaydet.Location = new System.Drawing.Point(616, 293);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ShadowDecoration.Parent = this.btnKaydet;
            this.btnKaydet.Size = new System.Drawing.Size(269, 43);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderRadius = 20;
            this.btnGuncelle.CheckedState.Parent = this.btnGuncelle;
            this.btnGuncelle.CustomImages.Parent = this.btnGuncelle;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.HoverState.Parent = this.btnGuncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(616, 140);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ShadowDecoration.Parent = this.btnGuncelle;
            this.btnGuncelle.Size = new System.Drawing.Size(269, 43);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(117, 366);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(79, 28);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "E-posta";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(123, 274);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(74, 28);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Telefon";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(129, 190);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 28);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Soyad";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(159, 101);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(37, 28);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Ad";
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.HintForeColor = System.Drawing.Color.White;
            this.txtMail.HintText = "";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtMail.LineThickness = 3;
            this.txtMail.Location = new System.Drawing.Point(247, 346);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 47);
            this.txtMail.TabIndex = 8;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTel
            // 
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.HintForeColor = System.Drawing.Color.White;
            this.txtTel.HintText = "";
            this.txtTel.isPassword = false;
            this.txtTel.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtTel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTel.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtTel.LineThickness = 3;
            this.txtTel.Location = new System.Drawing.Point(247, 256);
            this.txtTel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(217, 47);
            this.txtTel.TabIndex = 7;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyadi.Enabled = false;
            this.txtSoyadi.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSoyadi.ForeColor = System.Drawing.Color.White;
            this.txtSoyadi.HintForeColor = System.Drawing.Color.White;
            this.txtSoyadi.HintText = "";
            this.txtSoyadi.isPassword = false;
            this.txtSoyadi.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtSoyadi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoyadi.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtSoyadi.LineThickness = 3;
            this.txtSoyadi.Location = new System.Drawing.Point(247, 171);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(217, 47);
            this.txtSoyadi.TabIndex = 6;
            this.txtSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAdi
            // 
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.Enabled = false;
            this.txtAdi.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAdi.ForeColor = System.Drawing.Color.White;
            this.txtAdi.HintForeColor = System.Drawing.Color.White;
            this.txtAdi.HintText = "";
            this.txtAdi.isPassword = false;
            this.txtAdi.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdi.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtAdi.LineThickness = 3;
            this.txtAdi.Location = new System.Drawing.Point(247, 82);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(217, 47);
            this.txtAdi.TabIndex = 5;
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // db_FlightDataSet
            // 
            this.db_FlightDataSet.DataSetName = "db_FlightDataSet";
            this.db_FlightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbFlightDataSetBindingSource
            // 
            this.dbFlightDataSetBindingSource.DataSource = this.db_FlightDataSet;
            this.dbFlightDataSetBindingSource.Position = 0;
            // 
            // FrmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1012, 625);
            this.Controls.Add(this.pnlHesab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAccountInfo";
            this.Text = "FrmAccountInfo";
            this.pnlHesab.ResumeLayout(false);
            this.pnlHesab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHesab;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnKaydet;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnGuncelle;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoyadi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdi;
        private db_FlightDataSet db_FlightDataSet;
        private System.Windows.Forms.BindingSource dbFlightDataSetBindingSource;
    }
}