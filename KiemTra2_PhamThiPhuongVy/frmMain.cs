using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi07
{
    public partial class frmMain : Form
    {
        public static ThanhVien thanhvien = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(thanhvien==null)
            {
                Form frm = new Login();
                frm.ShowDialog();
            }
            toolStripStatusLabelTenDangNhap.Text = thanhvien.UserName;
            tabControlMain.ImageList = LoadImageList();
        }
        private ImageList LoadImageList()
        {
            ImageList iconsList = new ImageList();
            iconsList.TransparentColor = Color.Blue;
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(25, 25);
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\policy1.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\policy1.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\policy1.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\policy1.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\policy1.png"));
            return iconsList;
        }


        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Sinh Vien";
            tab.Name = "tbSinhVien";
            tab.ImageIndex = 1;
            Form frm = new frmSinhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if(!ExistTabPage(tabControlMain,"tbSinhVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbSinhVien"];
        }
        private bool ExistTabPage(TabControl control,string tabPageName)
        {
            bool check = false;
            for(int i=0;i<control.TabPages.Count;i++)
            {
                if (control.TabPages[i].Name==tabPageName)
                {
                    check = true;
                    break;
                }    
            }
            return check;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
