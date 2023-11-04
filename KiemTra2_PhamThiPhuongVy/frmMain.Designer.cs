namespace BaiTapBuoi07
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuTripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTenDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuTripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(-2, 48);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(803, 405);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStripMain);
            this.tabPage1.Controls.Add(this.toolStripMain);
            this.tabPage1.Controls.Add(this.menuTripMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuTripMain
            // 
            this.menuTripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem});
            this.menuTripMain.Location = new System.Drawing.Point(3, 3);
            this.menuTripMain.Name = "menuTripMain";
            this.menuTripMain.Size = new System.Drawing.Size(789, 28);
            this.menuTripMain.TabIndex = 0;
            this.menuTripMain.Text = "menuStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripMain.Location = new System.Drawing.Point(3, 31);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(789, 27);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTenDangNhap});
            this.statusStripMain.Location = new System.Drawing.Point(3, 347);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(789, 26);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTenDangNhap
            // 
            this.toolStripStatusLabelTenDangNhap.Enabled = false;
            this.toolStripStatusLabelTenDangNhap.Name = "toolStripStatusLabelTenDangNhap";
            this.toolStripStatusLabelTenDangNhap.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelTenDangNhap.Text = "toolStripStatusLabel1";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.sinhVienToolStripMenuItem.Text = "SinhVien";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuTripMain.ResumeLayout(false);
            this.menuTripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuTripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTenDangNhap;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
    }
}