using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi07
{
   
    public partial class frmThanhVien : Form
    {
        string AddOrEdit = "";
        ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = thanhVienDAO.getList();
            txtTongSV.Text = thanhVienDAO.getCount().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string tendangnhap = txtUsername.Text.Trim();
                string matkhau = txtPassword.Text.Trim();
                string matv = txtMaTV.Text.Trim();
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            ThanhVien tv = new ThanhVien();
                            tv.MaTV = matv;
                            tv.UserName = tendangnhap;
                            tv.Password = matkhau;
                            thanhVienDAO.Insert(tv);
                            txtTongSV.Text = thanhVienDAO.getCount().ToString();
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            break;
                        }
                    case "Edit":
                        {
                            ThanhVien tv = thanhVienDAO.getRow(matv);
                            tv.MaTV = matv;
                            tv.UserName = tendangnhap;
                            tv.Password = matkhau;
                            thanhVienDAO.Update(tv);
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            btnLuu.Enabled = true;
            txtMaTV.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
            btnLuu.Enabled = true;
            txtMaTV.Enabled = false;
        }
    }
}
