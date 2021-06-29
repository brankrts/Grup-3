
namespace WindowsFormsApp1.ChildForms.FormsMaster
{
    partial class MasterListOfFlights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SirketAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMaster
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMaster.ColumnHeadersHeight = 40;
            this.gridMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SirketAdi,
            this.SehirAdi,
            this.SehirAdi1,
            this.Tarih,
            this.Saat,
            this.Fiyat});
            this.gridMaster.DoubleBuffered = true;
            this.gridMaster.EnableHeadersVisualStyles = false;
            this.gridMaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridMaster.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.gridMaster.HeaderForeColor = System.Drawing.Color.Snow;
            this.gridMaster.Location = new System.Drawing.Point(2, 2);
            this.gridMaster.Margin = new System.Windows.Forms.Padding(2);
            this.gridMaster.Name = "gridMaster";
            this.gridMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMaster.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridMaster.RowHeadersVisible = false;
            this.gridMaster.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridMaster.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMaster.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridMaster.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridMaster.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.gridMaster.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridMaster.RowTemplate.DividerHeight = 3;
            this.gridMaster.RowTemplate.Height = 40;
            this.gridMaster.RowTemplate.ReadOnly = true;
            this.gridMaster.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMaster.Size = new System.Drawing.Size(810, 421);
            this.gridMaster.TabIndex = 2;
            this.gridMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListofFlight_CellContentClick);
            // 
            // SirketAdi
            // 
            this.SirketAdi.DataPropertyName = "SirketAdi";
            this.SirketAdi.HeaderText = "Firma";
            this.SirketAdi.Name = "SirketAdi";
            // 
            // SehirAdi
            // 
            this.SehirAdi.DataPropertyName = "SehirAdi";
            this.SehirAdi.HeaderText = "Nereden";
            this.SehirAdi.Name = "SehirAdi";
            // 
            // SehirAdi1
            // 
            this.SehirAdi1.DataPropertyName = "SehirAdi1";
            this.SehirAdi1.HeaderText = "Nereye";
            this.SehirAdi1.Name = "SehirAdi1";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // MasterListOfFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(823, 434);
            this.Controls.Add(this.gridMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterListOfFlights";
            this.Text = "MasterListOfFlights";
            this.Load += new System.EventHandler(this.MasterListOfFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn SirketAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}