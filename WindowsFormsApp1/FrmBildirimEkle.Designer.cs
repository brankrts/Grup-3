
namespace WindowsFormsApp1
{
    partial class FrmBildirimEkle
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
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtBildirim = new System.Windows.Forms.RichTextBox();
            this.btnTryLogin = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ıconButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(351, 11);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(59, 44);
            this.ıconButton1.TabIndex = 3;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // txtBildirim
            // 
            this.txtBildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBildirim.Location = new System.Drawing.Point(12, 71);
            this.txtBildirim.Name = "txtBildirim";
            this.txtBildirim.Size = new System.Drawing.Size(398, 180);
            this.txtBildirim.TabIndex = 4;
            this.txtBildirim.Text = "";
            this.txtBildirim.Click += new System.EventHandler(this.txtBildirim_Click);
            // 
            // btnTryLogin
            // 
            this.btnTryLogin.BorderRadius = 20;
            this.btnTryLogin.CheckedState.Parent = this.btnTryLogin;
            this.btnTryLogin.CustomImages.Parent = this.btnTryLogin;
            this.btnTryLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTryLogin.ForeColor = System.Drawing.Color.White;
            this.btnTryLogin.HoverState.Parent = this.btnTryLogin;
            this.btnTryLogin.Location = new System.Drawing.Point(70, 408);
            this.btnTryLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTryLogin.Name = "btnTryLogin";
            this.btnTryLogin.ShadowDecoration.Parent = this.btnTryLogin;
            this.btnTryLogin.Size = new System.Drawing.Size(271, 36);
            this.btnTryLogin.TabIndex = 71;
            this.btnTryLogin.Text = "Bildirim Ekle";
            this.btnTryLogin.Click += new System.EventHandler(this.btnTryLogin_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Lime;
            this.lblBilgi.Location = new System.Drawing.Point(156, 312);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(0, 29);
            this.lblBilgi.TabIndex = 72;
            // 
            // FrmBildirimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(422, 473);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnTryLogin);
            this.Controls.Add(this.txtBildirim);
            this.Controls.Add(this.ıconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBildirimEkle";
            this.Text = "Bildirim Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.RichTextBox txtBildirim;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTryLogin;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblBilgi;
    }
}