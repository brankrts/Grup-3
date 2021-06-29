
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
            this.btnAcountInfo = new FontAwesome.Sharp.IconButton();
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTC = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnTryLogin = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
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
            this.pnlMenu.Controls.Add(this.btnAcountInfo);
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(243, 837);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnAcountInfo
            // 
            this.btnAcountInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcountInfo.FlatAppearance.BorderSize = 0;
            this.btnAcountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAcountInfo.ForeColor = System.Drawing.Color.White;
            this.btnAcountInfo.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnAcountInfo.IconColor = System.Drawing.Color.White;
            this.btnAcountInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcountInfo.Location = new System.Drawing.Point(0, 597);
            this.btnAcountInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcountInfo.Name = "btnAcountInfo";
            this.btnAcountInfo.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnAcountInfo.Size = new System.Drawing.Size(243, 71);
            this.btnAcountInfo.TabIndex = 9;
            this.btnAcountInfo.Text = "Hesap Yönetimi";
            this.btnAcountInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcountInfo.UseVisualStyleBackColor = true;
            this.btnAcountInfo.Click += new System.EventHandler(this.ıconButton2_Click_1);
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
            this.comboServer.Location = new System.Drawing.Point(81, 711);
            this.comboServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboServer.Name = "comboServer";
            this.comboServer.Size = new System.Drawing.Size(156, 27);
            this.comboServer.TabIndex = 8;
            this.comboServer.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
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
            this.btnMaster.Location = new System.Drawing.Point(0, 527);
            this.btnMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnMaster.Size = new System.Drawing.Size(243, 70);
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
            this.btnWhoAreWe.Location = new System.Drawing.Point(0, 462);
            this.btnWhoAreWe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWhoAreWe.Name = "btnWhoAreWe";
            this.btnWhoAreWe.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnWhoAreWe.Size = new System.Drawing.Size(243, 65);
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
            this.btnMonthChart.Location = new System.Drawing.Point(0, 397);
            this.btnMonthChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonthChart.Name = "btnMonthChart";
            this.btnMonthChart.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnMonthChart.Size = new System.Drawing.Size(243, 65);
            this.btnMonthChart.TabIndex = 4;
            this.btnMonthChart.Text = "Fiyat Grafiği";
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
            this.btnSearchFlight.Location = new System.Drawing.Point(0, 332);
            this.btnSearchFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSearchFlight.Size = new System.Drawing.Size(243, 65);
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
            this.btnRegister.Location = new System.Drawing.Point(0, 267);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnRegister.Size = new System.Drawing.Size(243, 65);
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
            this.btnLogin.Location = new System.Drawing.Point(0, 202);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnLogin.Size = new System.Drawing.Size(243, 65);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 202);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(243, 202);
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
            this.pnlTitle.Location = new System.Drawing.Point(243, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1036, 90);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ıconButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(913, 11);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(111, 59);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(67, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 25);
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
            this.btnTitle.Location = new System.Drawing.Point(3, 26);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(67, 46);
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
            this.pnlChildForm.Controls.Add(this.guna2ShadowPanel1);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(243, 90);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1036, 747);
            this.pnlChildForm.TabIndex = 2;
            this.pnlChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildForm_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblUyari);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassword);
            this.guna2ShadowPanel1.Controls.Add(this.txtTC);
            this.guna2ShadowPanel1.Controls.Add(this.btnTryLogin);
            this.guna2ShadowPanel1.Controls.Add(this.bunifuCheckbox1);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.EdgeWidth = 1;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(119, 112);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.ShadowDepth = 250;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(775, 473);
            this.guna2ShadowPanel1.TabIndex = 62;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.White;
            this.lblUyari.Location = new System.Drawing.Point(355, 421);
            this.lblUyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 20);
            this.lblUyari.TabIndex = 73;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(308, 217);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(216, 43);
            this.txtPassword.TabIndex = 72;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTC.FocusedLineColor = System.Drawing.Color.Cyan;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTC.Location = new System.Drawing.Point(308, 130);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.PasswordChar = '\0';
            this.txtTC.SelectedText = "";
            this.txtTC.Size = new System.Drawing.Size(216, 43);
            this.txtTC.TabIndex = 71;
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTryLogin
            // 
            this.btnTryLogin.BorderRadius = 20;
            this.btnTryLogin.CheckedState.Parent = this.btnTryLogin;
            this.btnTryLogin.CustomImages.Parent = this.btnTryLogin;
            this.btnTryLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTryLogin.ForeColor = System.Drawing.Color.White;
            this.btnTryLogin.HoverState.Parent = this.btnTryLogin;
            this.btnTryLogin.Location = new System.Drawing.Point(253, 362);
            this.btnTryLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTryLogin.Name = "btnTryLogin";
            this.btnTryLogin.ShadowDecoration.Parent = this.btnTryLogin;
            this.btnTryLogin.Size = new System.Drawing.Size(271, 36);
            this.btnTryLogin.TabIndex = 70;
            this.btnTryLogin.Text = "Giriş Yap";
            this.btnTryLogin.Click += new System.EventHandler(this.btnTryLogin_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.LightBlue;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Silver;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.LightBlue;
            this.bunifuCheckbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(306, 300);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(340, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Beni Hatırla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 66;
            this.label2.Text = "Size sunulan tüm özelliklerden \r\nfaydalanmak için giriş yapın !\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "TC :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(256, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Şifre :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 837);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlChildForm.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnAcountInfo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblUyari;
        private Guna.UI.WinForms.GunaLineTextBox txtPassword;
        private Guna.UI.WinForms.GunaLineTextBox txtTC;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTryLogin;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

