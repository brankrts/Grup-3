
namespace WindowsFormsApp1.ChildForms
{
    partial class FrmMonth
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSearchFlight = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cmbNereye = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNereden = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNereden = new System.Windows.Forms.Label();
            this.lblNereye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 61);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.Name = "PGS";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "AJET";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "THY";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(935, 406);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.BorderRadius = 20;
            this.btnSearchFlight.CheckedState.Parent = this.btnSearchFlight;
            this.btnSearchFlight.CustomImages.Parent = this.btnSearchFlight;
            this.btnSearchFlight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.btnSearchFlight.HoverState.Parent = this.btnSearchFlight;
            this.btnSearchFlight.Location = new System.Drawing.Point(707, 511);
            this.btnSearchFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.ShadowDecoration.Parent = this.btnSearchFlight;
            this.btnSearchFlight.Size = new System.Drawing.Size(269, 43);
            this.btnSearchFlight.TabIndex = 12;
            this.btnSearchFlight.Text = "Fiyatlara Bak";
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
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
            this.cmbNereye.Location = new System.Drawing.Point(394, 501);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.ShadowDecoration.Parent = this.cmbNereye;
            this.cmbNereye.Size = new System.Drawing.Size(223, 36);
            this.cmbNereye.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbNereye.TabIndex = 20;
            this.cmbNereye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbNereye.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            this.cmbNereden.Location = new System.Drawing.Point(108, 501);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.ShadowDecoration.Parent = this.cmbNereden;
            this.cmbNereden.Size = new System.Drawing.Size(223, 36);
            this.cmbNereden.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbNereden.TabIndex = 19;
            this.cmbNereden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbNereden.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // lblNereden
            // 
            this.lblNereden.AutoSize = true;
            this.lblNereden.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNereden.ForeColor = System.Drawing.Color.White;
            this.lblNereden.Location = new System.Drawing.Point(257, 25);
            this.lblNereden.Name = "lblNereden";
            this.lblNereden.Size = new System.Drawing.Size(69, 24);
            this.lblNereden.TabIndex = 21;
            this.lblNereden.Text = "Ankara ";
            // 
            // lblNereye
            // 
            this.lblNereye.AutoSize = true;
            this.lblNereye.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNereye.ForeColor = System.Drawing.Color.White;
            this.lblNereye.Location = new System.Drawing.Point(456, 25);
            this.lblNereye.Name = "lblNereye";
            this.lblNereye.Size = new System.Drawing.Size(69, 24);
            this.lblNereye.TabIndex = 22;
            this.lblNereye.Text = "Ankara ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "------->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(557, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seferleri..";
            // 
            // FrmMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1012, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNereye);
            this.Controls.Add(this.lblNereden);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMonth";
            this.Text = "frmMonth";
            this.Load += new System.EventHandler(this.FrmMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSearchFlight;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNereye;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNereden;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}