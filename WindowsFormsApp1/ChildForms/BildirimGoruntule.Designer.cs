
namespace WindowsFormsApp1.ChildForms
{
    partial class BildirimGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gridLisBildirimler = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.BildirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bildirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLisBildirimler)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gridLisBildirimler
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridLisBildirimler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridLisBildirimler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLisBildirimler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridLisBildirimler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLisBildirimler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLisBildirimler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLisBildirimler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridLisBildirimler.ColumnHeadersHeight = 40;
            this.gridLisBildirimler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLisBildirimler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BildirimID,
            this.Bildirim});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "D";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLisBildirimler.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridLisBildirimler.DoubleBuffered = true;
            this.gridLisBildirimler.EnableHeadersVisualStyles = false;
            this.gridLisBildirimler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridLisBildirimler.HeaderBgColor = System.Drawing.Color.SlateGray;
            this.gridLisBildirimler.HeaderForeColor = System.Drawing.Color.Snow;
            this.gridLisBildirimler.Location = new System.Drawing.Point(12, 63);
            this.gridLisBildirimler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLisBildirimler.Name = "gridLisBildirimler";
            this.gridLisBildirimler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridLisBildirimler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLisBildirimler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridLisBildirimler.RowHeadersVisible = false;
            this.gridLisBildirimler.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLisBildirimler.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridLisBildirimler.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridLisBildirimler.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridLisBildirimler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.gridLisBildirimler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridLisBildirimler.RowTemplate.DividerHeight = 3;
            this.gridLisBildirimler.RowTemplate.Height = 40;
            this.gridLisBildirimler.RowTemplate.ReadOnly = true;
            this.gridLisBildirimler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLisBildirimler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLisBildirimler.Size = new System.Drawing.Size(1111, 549);
            this.gridLisBildirimler.TabIndex = 15;
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ıconButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(1076, 1);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(59, 44);
            this.ıconButton1.TabIndex = 16;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // BildirimID
            // 
            this.BildirimID.DataPropertyName = "BildirimID";
            this.BildirimID.HeaderText = "BildirimID";
            this.BildirimID.MinimumWidth = 6;
            this.BildirimID.Name = "BildirimID";
            this.BildirimID.Visible = false;
            // 
            // Bildirim
            // 
            this.Bildirim.DataPropertyName = "Bildirim";
            this.Bildirim.HeaderText = "Bildirimler";
            this.Bildirim.MinimumWidth = 6;
            this.Bildirim.Name = "Bildirim";
            this.Bildirim.ReadOnly = true;
            // 
            // BildirimGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1147, 634);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.gridLisBildirimler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BildirimGoruntule";
            this.Text = "BildirimGoruntule";
            this.Load += new System.EventHandler(this.BildirimGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLisBildirimler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridLisBildirimler;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BildirimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bildirim;
    }
}