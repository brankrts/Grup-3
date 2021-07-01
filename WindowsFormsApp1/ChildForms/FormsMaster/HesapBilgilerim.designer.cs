
namespace Proje1
{
    partial class HesapBilgilerim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFlight = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.pnlHesab = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.AnimationHoverSpeed = 0.07F;
            this.btnAddFlight.AnimationSpeed = 0.03F;
            this.btnAddFlight.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddFlight.BorderColor = System.Drawing.Color.Black;
            this.btnAddFlight.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddFlight.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddFlight.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddFlight.CheckedImage = null;
            this.btnAddFlight.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddFlight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddFlight.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddFlight.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Image = null;
            this.btnAddFlight.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAddFlight.LineBottom = 2;
            this.btnAddFlight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddFlight.Location = new System.Drawing.Point(48, 30);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAddFlight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddFlight.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddFlight.OnHoverImage = null;
            this.btnAddFlight.OnHoverLineColor = System.Drawing.Color.White;
            this.btnAddFlight.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddFlight.Size = new System.Drawing.Size(119, 32);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "Hesap Bilgilerim";
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = null;
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = null;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineBottom = 2;
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(295, 30);
            this.gunaAdvenceTileButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(119, 32);
            this.gunaAdvenceTileButton1.TabIndex = 2;
            this.gunaAdvenceTileButton1.Text = "Mevcut Uçuşlarım";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = null;
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Image = null;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton2.LineBottom = 2;
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(552, 30);
            this.gunaAdvenceTileButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(119, 32);
            this.gunaAdvenceTileButton2.TabIndex = 3;
            this.gunaAdvenceTileButton2.Text = "Uçuş Geçmişim";
            this.gunaAdvenceTileButton2.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click);
            // 
            // pnlHesab
            // 
            this.pnlHesab.Location = new System.Drawing.Point(9, 85);
            this.pnlHesab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHesab.Name = "pnlHesab";
            this.pnlHesab.Size = new System.Drawing.Size(759, 508);
            this.pnlHesab.TabIndex = 4;
            // 
            // HesapBilgilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(775, 603);
            this.Controls.Add(this.pnlHesab);
            this.Controls.Add(this.gunaAdvenceTileButton2);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.btnAddFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HesapBilgilerim";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton btnAddFlight;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private System.Windows.Forms.Panel pnlHesab;
    }
}

