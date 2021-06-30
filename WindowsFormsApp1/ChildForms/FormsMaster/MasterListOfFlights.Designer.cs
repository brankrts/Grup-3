
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridListofFlight = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UcusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SirketAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridListofFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListofFlight
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridListofFlight.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListofFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListofFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridListofFlight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListofFlight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListofFlight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListofFlight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListofFlight.ColumnHeadersHeight = 40;
            this.gridListofFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListofFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcusID,
            this.SirketAdi,
            this.SehirAdi,
            this.SehirAdi1,
            this.Tarih,
            this.Saat,
            this.Fiyat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListofFlight.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridListofFlight.DoubleBuffered = true;
            this.gridListofFlight.EnableHeadersVisualStyles = false;
            this.gridListofFlight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridListofFlight.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.gridListofFlight.HeaderForeColor = System.Drawing.Color.Snow;
            this.gridListofFlight.Location = new System.Drawing.Point(12, -1);
            this.gridListofFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridListofFlight.Name = "gridListofFlight";
            this.gridListofFlight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridListofFlight.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListofFlight.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridListofFlight.RowHeadersVisible = false;
            this.gridListofFlight.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridListofFlight.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridListofFlight.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridListofFlight.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridListofFlight.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.gridListofFlight.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridListofFlight.RowTemplate.DividerHeight = 3;
            this.gridListofFlight.RowTemplate.Height = 40;
            this.gridListofFlight.RowTemplate.ReadOnly = true;
            this.gridListofFlight.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListofFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListofFlight.Size = new System.Drawing.Size(1073, 554);
            this.gridListofFlight.TabIndex = 14;
            this.gridListofFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListofFlight_CellContentClick_1);
            // 
            // UcusID
            // 
            this.UcusID.DataPropertyName = "UcusID";
            this.UcusID.HeaderText = "UcusID";
            this.UcusID.MinimumWidth = 6;
            this.UcusID.Name = "UcusID";
            this.UcusID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UcusID.Visible = false;
            // 
            // SirketAdi
            // 
            this.SirketAdi.DataPropertyName = "SirketAdi";
            this.SirketAdi.HeaderText = "Firma";
            this.SirketAdi.MinimumWidth = 6;
            this.SirketAdi.Name = "SirketAdi";
            this.SirketAdi.ReadOnly = true;
            this.SirketAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SehirAdi
            // 
            this.SehirAdi.DataPropertyName = "SehirAdi";
            this.SehirAdi.HeaderText = "Nereden";
            this.SehirAdi.MinimumWidth = 6;
            this.SehirAdi.Name = "SehirAdi";
            this.SehirAdi.ReadOnly = true;
            this.SehirAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SehirAdi1
            // 
            this.SehirAdi1.DataPropertyName = "SehirAdi1";
            this.SehirAdi1.HeaderText = "Nereye";
            this.SehirAdi1.MinimumWidth = 6;
            this.SehirAdi1.Name = "SehirAdi1";
            this.SehirAdi1.ReadOnly = true;
            this.SehirAdi1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tarih.FillWeight = 200F;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MasterListOfFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1097, 534);
            this.Controls.Add(this.gridListofFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasterListOfFlights";
            this.Text = "MasterListOfFlights";
            this.Load += new System.EventHandler(this.MasterListOfFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListofFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridListofFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SirketAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}