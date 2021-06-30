
namespace WindowsFormsApp1.ChildForms
{
    partial class FormMaster
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
            this.btnAddFlight = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnListOfFlight = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnAddMaster = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBildirim = new FontAwesome.Sharp.IconButton();
            this.pnlMasterChildForm = new System.Windows.Forms.Panel();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.guna2ShadowPanel1.SuspendLayout();
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
            this.btnAddFlight.Location = new System.Drawing.Point(63, 32);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAddFlight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddFlight.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddFlight.OnHoverImage = null;
            this.btnAddFlight.OnHoverLineColor = System.Drawing.Color.White;
            this.btnAddFlight.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddFlight.Size = new System.Drawing.Size(159, 39);
            this.btnAddFlight.TabIndex = 0;
            this.btnAddFlight.Text = "Uçuş Ekle";
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnListOfFlight
            // 
            this.btnListOfFlight.AnimationHoverSpeed = 0.07F;
            this.btnListOfFlight.AnimationSpeed = 0.03F;
            this.btnListOfFlight.BaseColor = System.Drawing.Color.Transparent;
            this.btnListOfFlight.BorderColor = System.Drawing.Color.Black;
            this.btnListOfFlight.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnListOfFlight.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnListOfFlight.CheckedForeColor = System.Drawing.Color.White;
            this.btnListOfFlight.CheckedImage = null;
            this.btnListOfFlight.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnListOfFlight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListOfFlight.FocusedColor = System.Drawing.Color.Empty;
            this.btnListOfFlight.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnListOfFlight.ForeColor = System.Drawing.Color.White;
            this.btnListOfFlight.Image = null;
            this.btnListOfFlight.ImageSize = new System.Drawing.Size(52, 52);
            this.btnListOfFlight.LineBottom = 2;
            this.btnListOfFlight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnListOfFlight.Location = new System.Drawing.Point(338, 32);
            this.btnListOfFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListOfFlight.Name = "btnListOfFlight";
            this.btnListOfFlight.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnListOfFlight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnListOfFlight.OnHoverForeColor = System.Drawing.Color.White;
            this.btnListOfFlight.OnHoverImage = null;
            this.btnListOfFlight.OnHoverLineColor = System.Drawing.Color.White;
            this.btnListOfFlight.OnPressedColor = System.Drawing.Color.Black;
            this.btnListOfFlight.Size = new System.Drawing.Size(163, 46);
            this.btnListOfFlight.TabIndex = 1;
            this.btnListOfFlight.Text = "Uçuşları Listele";
            this.btnListOfFlight.Click += new System.EventHandler(this.btnListOfFlight_Click);
            // 
            // btnAddMaster
            // 
            this.btnAddMaster.AnimationHoverSpeed = 0.07F;
            this.btnAddMaster.AnimationSpeed = 0.03F;
            this.btnAddMaster.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddMaster.BorderColor = System.Drawing.Color.Black;
            this.btnAddMaster.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddMaster.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddMaster.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddMaster.CheckedImage = null;
            this.btnAddMaster.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddMaster.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMaster.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMaster.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddMaster.ForeColor = System.Drawing.Color.White;
            this.btnAddMaster.Image = null;
            this.btnAddMaster.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAddMaster.LineBottom = 2;
            this.btnAddMaster.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddMaster.Location = new System.Drawing.Point(610, 32);
            this.btnAddMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMaster.Name = "btnAddMaster";
            this.btnAddMaster.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAddMaster.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMaster.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddMaster.OnHoverImage = null;
            this.btnAddMaster.OnHoverLineColor = System.Drawing.Color.White;
            this.btnAddMaster.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMaster.Size = new System.Drawing.Size(163, 46);
            this.btnAddMaster.TabIndex = 2;
            this.btnAddMaster.Text = "Yönetici Ekle";
            this.btnAddMaster.Click += new System.EventHandler(this.btnAddMaster_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.ıconButton1);
            this.guna2ShadowPanel1.Controls.Add(this.btnBildirim);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddFlight);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddMaster);
            this.guna2ShadowPanel1.Controls.Add(this.btnListOfFlight);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowDepth = 180;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1111, 137);
            this.guna2ShadowPanel1.TabIndex = 3;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // btnBildirim
            // 
            this.btnBildirim.FlatAppearance.BorderSize = 0;
            this.btnBildirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBildirim.ForeColor = System.Drawing.Color.Transparent;
            this.btnBildirim.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.btnBildirim.IconColor = System.Drawing.Color.White;
            this.btnBildirim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBildirim.Location = new System.Drawing.Point(939, 32);
            this.btnBildirim.Name = "btnBildirim";
            this.btnBildirim.Size = new System.Drawing.Size(46, 52);
            this.btnBildirim.TabIndex = 5;
            this.btnBildirim.UseVisualStyleBackColor = true;
            this.btnBildirim.Click += new System.EventHandler(this.btnBildirim_Click);
            // 
            // pnlMasterChildForm
            // 
            this.pnlMasterChildForm.Location = new System.Drawing.Point(0, 143);
            this.pnlMasterChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMasterChildForm.Name = "pnlMasterChildForm";
            this.pnlMasterChildForm.Size = new System.Drawing.Size(1097, 534);
            this.pnlMasterChildForm.TabIndex = 4;
            this.pnlMasterChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMasterChildForm_Paint);
            // 
            // ıconButton1
            // 
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Fax;
            this.ıconButton1.IconColor = System.Drawing.Color.White;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(835, 32);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(46, 52);
            this.ıconButton1.TabIndex = 6;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1111, 690);
            this.Controls.Add(this.pnlMasterChildForm);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMaster";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton btnAddFlight;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnListOfFlight;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnAddMaster;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel pnlMasterChildForm;
        private FontAwesome.Sharp.IconButton btnBildirim;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}