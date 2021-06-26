
namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboServer = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaster = new FontAwesome.Sharp.IconButton();
            this.btnWhoAreWe = new FontAwesome.Sharp.IconButton();
            this.btnMonthChart = new FontAwesome.Sharp.IconButton();
            this.btnSearchFlight = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTitle = new FontAwesome.Sharp.IconButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.ıconButton2);
            this.pnlMenu.Controls.Add(this.comboServer);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnMaster);
            this.pnlMenu.Controls.Add(this.btnWhoAreWe);
            this.pnlMenu.Controls.Add(this.btnMonthChart);
            this.pnlMenu.Controls.Add(this.btnSearchFlight);
            this.pnlMenu.Controls.Add(this.btnRegister);
            this.pnlMenu.Controls.Add(this.btnLogin);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 680);
            this.pnlMenu.TabIndex = 0;
            // 
            // ıconButton2
            // 
            this.ıconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.White;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ıconButton2.IconColor = System.Drawing.Color.White;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(0, 486);
            this.ıconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton2.Size = new System.Drawing.Size(182, 58);
            this.ıconButton2.TabIndex = 9;
            this.ıconButton2.Text = "Hesap Yönetimi";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click_1);
            // 
            // comboServer
            // 
            this.comboServer.BackColor = System.Drawing.Color.Transparent;
            this.comboServer.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboServer.FormattingEnabled = true;
            this.comboServer.ItemHeight = 21;
            this.comboServer.Items.AddRange(new object[] {
            "Seyahat Acentesi 1",
            "Seyahat Acentesi 2",
            "Seyahat Acentesi 3"});
            this.comboServer.Location = new System.Drawing.Point(61, 578);
            this.comboServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboServer.Name = "comboServer";
            this.comboServer.Size = new System.Drawing.Size(118, 27);
            this.comboServer.TabIndex = 8;
            this.comboServer.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(2, 585);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server : ";
            // 
            // btnMaster
            // 
            this.btnMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaster.ForeColor = System.Drawing.Color.White;
            this.btnMaster.IconChar = FontAwesome.Sharp.IconChar.Medium;
            this.btnMaster.IconColor = System.Drawing.Color.White;
            this.btnMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.Location = new System.Drawing.Point(0, 429);
            this.btnMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnMaster.Size = new System.Drawing.Size(182, 57);
            this.btnMaster.TabIndex = 6;
            this.btnMaster.Text = "Yönetici Paneli";
            this.btnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnWhoAreWe
            // 
            this.btnWhoAreWe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhoAreWe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWhoAreWe.FlatAppearance.BorderSize = 0;
            this.btnWhoAreWe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhoAreWe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhoAreWe.ForeColor = System.Drawing.Color.White;
            this.btnWhoAreWe.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnWhoAreWe.IconColor = System.Drawing.Color.White;
            this.btnWhoAreWe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhoAreWe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWhoAreWe.Location = new System.Drawing.Point(0, 376);
            this.btnWhoAreWe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWhoAreWe.Name = "btnWhoAreWe";
            this.btnWhoAreWe.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnWhoAreWe.Size = new System.Drawing.Size(182, 53);
            this.btnWhoAreWe.TabIndex = 5;
            this.btnWhoAreWe.Text = "Biz Kimiz";
            this.btnWhoAreWe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWhoAreWe.UseVisualStyleBackColor = true;
            this.btnWhoAreWe.Click += new System.EventHandler(this.btnWhoAreWe_Click);
            // 
            // btnMonthChart
            // 
            this.btnMonthChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthChart.FlatAppearance.BorderSize = 0;
            this.btnMonthChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMonthChart.ForeColor = System.Drawing.Color.White;
            this.btnMonthChart.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnMonthChart.IconColor = System.Drawing.Color.White;
            this.btnMonthChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonthChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthChart.Location = new System.Drawing.Point(0, 323);
            this.btnMonthChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMonthChart.Name = "btnMonthChart";
            this.btnMonthChart.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnMonthChart.Size = new System.Drawing.Size(182, 53);
            this.btnMonthChart.TabIndex = 4;
            this.btnMonthChart.Text = "Aylık Fiyat Grafiği";
            this.btnMonthChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonthChart.UseVisualStyleBackColor = true;
            this.btnMonthChart.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFlight.FlatAppearance.BorderSize = 0;
            this.btnSearchFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.btnSearchFlight.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.btnSearchFlight.IconColor = System.Drawing.Color.White;
            this.btnSearchFlight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFlight.Location = new System.Drawing.Point(0, 270);
            this.btnSearchFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnSearchFlight.Size = new System.Drawing.Size(182, 53);
            this.btnSearchFlight.TabIndex = 3;
            this.btnSearchFlight.Text = "Uçuş Ara";
            this.btnSearchFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFlight.UseVisualStyleBackColor = true;
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.btnRegister.IconColor = System.Drawing.Color.White;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 217);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRegister.Size = new System.Drawing.Size(182, 53);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 164);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnLogin.Size = new System.Drawing.Size(182, 53);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 164);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 164);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitle.Controls.Add(this.ıconButton1);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(182, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(777, 73);
            this.pnlTitle.TabIndex = 1;
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ıconButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(685, 9);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(83, 48);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(50, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Anasayfa";
            // 
            // btnTitle
            // 
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTitle.IconColor = System.Drawing.Color.MediumPurple;
            this.btnTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTitle.Location = new System.Drawing.Point(2, 21);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(50, 37);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.btnHome;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.pnlMenu;
            this.bunifuDragControl4.Vertical = true;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(182, 73);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(777, 607);
            this.pnlChildForm.TabIndex = 2;
            this.pnlChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildForm_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 680);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnWhoAreWe;
        private FontAwesome.Sharp.IconButton btnMonthChart;
        private FontAwesome.Sharp.IconButton btnSearchFlight;
        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMaster;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private MetroFramework.Controls.MetroComboBox comboServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton ıconButton2;
    }
}

