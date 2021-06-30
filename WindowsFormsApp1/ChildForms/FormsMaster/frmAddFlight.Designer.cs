
namespace WindowsFormsApp1.ChildForms.frmMaster
{
    partial class frmAddFlight
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
            this.txtFiyat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddFlightToDb = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cmbNereden = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNereye = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbFirma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.db_FlightDataSet = new WindowsFormsApp1.db_FlightDataSet();
            this.dbFlightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFlightDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSaat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblUyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtFiyat.ForeColor = System.Drawing.Color.White;
            this.txtFiyat.HintForeColor = System.Drawing.Color.White;
            this.txtFiyat.HintText = "";
            this.txtFiyat.isPassword = false;
            this.txtFiyat.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtFiyat.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiyat.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtFiyat.LineThickness = 3;
            this.txtFiyat.Location = new System.Drawing.Point(181, 435);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(340, 41);
            this.txtFiyat.TabIndex = 4;
            this.txtFiyat.Text = "Fiyat";
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiyat.OnValueChanged += new System.EventHandler(this.txtPrice_OnValueChanged);
            this.txtFiyat.Click += new System.EventHandler(this.txtFiyat_Click);
            this.txtFiyat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrice_MouseClick);
            // 
            // btnAddFlightToDb
            // 
            this.btnAddFlightToDb.BorderRadius = 20;
            this.btnAddFlightToDb.CheckedState.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.CustomImages.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFlightToDb.ForeColor = System.Drawing.Color.White;
            this.btnAddFlightToDb.HoverState.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Location = new System.Drawing.Point(616, 435);
            this.btnAddFlightToDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFlightToDb.Name = "btnAddFlightToDb";
            this.btnAddFlightToDb.ShadowDecoration.Parent = this.btnAddFlightToDb;
            this.btnAddFlightToDb.Size = new System.Drawing.Size(269, 43);
            this.btnAddFlightToDb.TabIndex = 5;
            this.btnAddFlightToDb.Text = "Uçuş Ekle";
            this.btnAddFlightToDb.Click += new System.EventHandler(this.btnAddFlightToDb_Click);
            // 
            // cmbNereden
            // 
            this.cmbNereden.BackColor = System.Drawing.Color.Transparent;
            this.cmbNereden.BorderRadius = 20;
            this.cmbNereden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cmbNereden.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNereden.FocusedState.Parent = this.cmbNereden;
            this.cmbNereden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNereden.ForeColor = System.Drawing.Color.White;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.HoverState.Parent = this.cmbNereden;
            this.cmbNereden.ItemHeight = 30;
            this.cmbNereden.ItemsAppearance.Parent = this.cmbNereden;
            this.cmbNereden.Location = new System.Drawing.Point(182, 117);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.ShadowDecoration.Parent = this.cmbNereden;
            this.cmbNereden.Size = new System.Drawing.Size(339, 36);
            this.cmbNereden.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbNereden.TabIndex = 6;
            this.cmbNereden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbNereden.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // cmbNereye
            // 
            this.cmbNereye.BackColor = System.Drawing.Color.Transparent;
            this.cmbNereye.BorderRadius = 20;
            this.cmbNereye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cmbNereye.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNereye.FocusedState.Parent = this.cmbNereye;
            this.cmbNereye.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNereye.ForeColor = System.Drawing.Color.White;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.HoverState.Parent = this.cmbNereye;
            this.cmbNereye.ItemHeight = 30;
            this.cmbNereye.ItemsAppearance.Parent = this.cmbNereye;
            this.cmbNereye.Location = new System.Drawing.Point(182, 203);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.ShadowDecoration.Parent = this.cmbNereye;
            this.cmbNereye.Size = new System.Drawing.Size(339, 36);
            this.cmbNereye.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbNereye.TabIndex = 7;
            this.cmbNereye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(178, 122);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Nereden";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(178, 203);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 20);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Nereye";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(178, 286);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 20);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Tarih";
            // 
            // cmbFirma
            // 
            this.cmbFirma.BackColor = System.Drawing.Color.Transparent;
            this.cmbFirma.BorderRadius = 20;
            this.cmbFirma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cmbFirma.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFirma.FocusedState.Parent = this.cmbFirma;
            this.cmbFirma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFirma.ForeColor = System.Drawing.Color.White;
            this.cmbFirma.FormattingEnabled = true;
            this.cmbFirma.HoverState.Parent = this.cmbFirma;
            this.cmbFirma.ItemHeight = 30;
            this.cmbFirma.ItemsAppearance.Parent = this.cmbFirma;
            this.cmbFirma.Location = new System.Drawing.Point(182, 47);
            this.cmbFirma.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.ShadowDecoration.Parent = this.cmbFirma;
            this.cmbFirma.Size = new System.Drawing.Size(339, 36);
            this.cmbFirma.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbFirma.TabIndex = 12;
            this.cmbFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbFirma.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(178, 52);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Firma";
            // 
            // cmbTarih
            // 
            this.cmbTarih.BackColor = System.Drawing.Color.Transparent;
            this.cmbTarih.BorderRadius = 0;
            this.cmbTarih.ForeColor = System.Drawing.Color.White;
            this.cmbTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbTarih.FormatCustom = null;
            this.cmbTarih.Location = new System.Drawing.Point(182, 308);
            this.cmbTarih.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(339, 43);
            this.cmbTarih.TabIndex = 14;
            this.cmbTarih.Value = new System.DateTime(2021, 6, 19, 0, 0, 0, 0);
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
            // dbFlightDataSetBindingSource1
            // 
            this.dbFlightDataSetBindingSource1.DataSource = this.db_FlightDataSet;
            this.dbFlightDataSetBindingSource1.Position = 0;
            // 
            // txtSaat
            // 
            this.txtSaat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaat.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSaat.ForeColor = System.Drawing.Color.White;
            this.txtSaat.HintForeColor = System.Drawing.Color.White;
            this.txtSaat.HintText = "";
            this.txtSaat.isPassword = false;
            this.txtSaat.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtSaat.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSaat.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtSaat.LineThickness = 3;
            this.txtSaat.Location = new System.Drawing.Point(181, 363);
            this.txtSaat.Margin = new System.Windows.Forms.Padding(5);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(340, 41);
            this.txtSaat.TabIndex = 16;
            this.txtSaat.Text = "Saat";
            this.txtSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSaat.Click += new System.EventHandler(this.txtSaat_Click);
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(280, 505);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 17);
            this.lblUyari.TabIndex = 17;
            // 
            // frmAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1044, 547);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.cmbFirma);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.btnAddFlightToDb);
            this.Controls.Add(this.txtFiyat);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddFlight";
            this.Text = "frmAddFlight";
            this.Load += new System.EventHandler(this.frmAddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiyat;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddFlightToDb;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNereden;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNereye;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFirma;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker cmbTarih;
        private db_FlightDataSet db_FlightDataSet;
        private System.Windows.Forms.BindingSource dbFlightDataSetBindingSource;
        private System.Windows.Forms.BindingSource dbFlightDataSetBindingSource1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSaat;
        private System.Windows.Forms.Label lblUyari;
    }
}