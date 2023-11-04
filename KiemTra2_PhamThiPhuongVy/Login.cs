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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhVienDAO.getRow(username);
            if(tv==null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
            }
            else
            {
                if(tv.Password==password)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo");
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
