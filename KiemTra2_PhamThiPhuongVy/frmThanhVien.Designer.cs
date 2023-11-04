namespace BaiTapBuoi07
{
    partial class frmThanhVien
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaTV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.gbThongTin.SuspendLayout();
            this.gbxChucNang.SuspendLayout();
            this.gbxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(625, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(268, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = true;
            this.txtUsername.Location = new System.Drawing.Point(164, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(268, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(499, 28);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(61, 16);
            this.lblDiemTB.TabIndex = 3;
            this.lblDiemTB.Text = "Mật khẩu";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtPassword);
            this.gbThongTin.Controls.Add(this.txtUsername);
            this.gbThongTin.Controls.Add(this.lblDiemTB);
            this.gbThongTin.Controls.Add(this.txtMaTV);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(20, 76);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(917, 105);
            this.gbThongTin.TabIndex = 13;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // txtMaTV
            // 
            this.txtMaTV.Location = new System.Drawing.Point(164, 25);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.Size = new System.Drawing.Size(268, 22);
            this.txtMaTV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(16, 73);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(98, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Tên đăng nhập";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(16, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(89, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã thành viên";
            // 
            // txtTongSV
            // 
            this.txtTongSV.Location = new System.Drawing.Point(754, 288);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.Size = new System.Drawing.Size(118, 22);
            this.txtTongSV.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Location = new System.Drawing.Point(11, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số TV";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Silver;
            this.btnLoc.Location = new System.Drawing.Point(635, 25);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(113, 32);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Location = new System.Drawing.Point(479, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.Location = new System.Drawing.Point(791, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.Location = new System.Drawing.Point(323, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Location = new System.Drawing.Point(167, 25);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 32);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(338, 26);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(317, 29);
            this.lblThongTinSinhVien.TabIndex = 12;
            this.lblThongTinSinhVien.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnLoc);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Controls.Add(this.btnLuu);
            this.gbxChucNang.Controls.Add(this.btnCapNhat);
            this.gbxChucNang.Controls.Add(this.btnThem);
            this.gbxChucNang.Location = new System.Drawing.Point(20, 187);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(917, 78);
            this.gbxChucNang.TabIndex = 14;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức năng";
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.txtTongSV);
            this.gbxDanhSach.Controls.Add(this.label1);
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Location = new System.Drawing.Point(20, 289);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(917, 325);
            this.gbxDanhSach.TabIndex = 15;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 21);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(892, 257);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxDanhSach);
            this.Name = "frmThanhVien";
            this.Text = "frmThanhVien";
            this.Load += new System.EventHandler(this.frmThanhVien_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbxChucNang.ResumeLayout(false);
            this.gbxDanhSach.ResumeLayout(false);
            this.gbxDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblThongTinSinhVien;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMaTV;
        private System.Windows.Forms.Label lblMaSV;
    }
}