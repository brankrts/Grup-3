
namespace WindowsFormsApp1.ChildForms
{
    partial class AlinanBiletler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridmaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.MusteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridmaster)).BeginInit();
            this.SuspendLayout();
            // 
            // gridmaster
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridmaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridmaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmaster.ColumnHeadersHeight = 40;
            this.gridmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridmaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusteriTC,
            this.Nereden,
            this.Nereye,
            this.Tarih,
            this.KoltukNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmaster.DoubleBuffered = true;
            this.gridmaster.EnableHeadersVisualStyles = false;
            this.gridmaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.gridmaster.HeaderForeColor = System.Drawing.Color.Snow;
            this.gridmaster.Location = new System.Drawing.Point(12, 55);
            this.gridmaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridmaster.Name = "gridmaster";
            this.gridmaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridmaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaster.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridmaster.RowHeadersVisible = false;
            this.gridmaster.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridmaster.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridmaster.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridmaster.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.gridmaster.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridmaster.RowTemplate.DividerHeight = 3;
            this.gridmaster.RowTemplate.Height = 40;
            this.gridmaster.RowTemplate.ReadOnly = true;
            this.gridmaster.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmaster.Size = new System.Drawing.Size(1125, 537);
            this.gridmaster.TabIndex = 14;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ıconButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(1078, 7);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(59, 44);
            this.ıconButton1.TabIndex = 15;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // MusteriTC
            // 
            this.MusteriTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MusteriTC.DataPropertyName = "MusteriTC";
            this.MusteriTC.FillWeight = 16.04278F;
            this.MusteriTC.HeaderText = "TC";
            this.MusteriTC.MinimumWidth = 6;
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MusteriTC.Width = 200;
            // 
            // Nereden
            // 
            this.Nereden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nereden.DataPropertyName = "SehirAdi";
            this.Nereden.FillWeight = 16.04278F;
            this.Nereden.HeaderText = "Nereden";
            this.Nereden.MinimumWidth = 6;
            this.Nereden.Name = "Nereden";
            this.Nereden.ReadOnly = true;
            this.Nereden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nereden.Width = 251;
            // 
            // Nereye
            // 
            this.Nereye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nereye.DataPropertyName = "SehirAdi1";
            this.Nereye.FillWeight = 16.04278F;
            this.Nereye.HeaderText = "Nereye";
            this.Nereye.MinimumWidth = 6;
            this.Nereye.Name = "Nereye";
            this.Nereye.ReadOnly = true;
            this.Nereye.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nereye.Width = 252;
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.FillWeight = 435.8289F;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tarih.Width = 300;
            // 
            // KoltukNo
            // 
            this.KoltukNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KoltukNo.DataPropertyName = "KoltukNo";
            this.KoltukNo.FillWeight = 16.04278F;
            this.KoltukNo.HeaderText = "KoltukNo";
            this.KoltukNo.MinimumWidth = 6;
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.ReadOnly = true;
            this.KoltukNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KoltukNo.Width = 120;
            // 
            // AlinanBiletler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1149, 603);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.gridmaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlinanBiletler";
            this.Text = "AlinanBiletler";
            this.Load += new System.EventHandler(this.AlinanBiletler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridmaster;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
    }
}