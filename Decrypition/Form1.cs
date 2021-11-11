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

namespace Decrypition
{
    public partial class Form1 : Form
    {
        team6_MaHoaDes DES = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DES = new team6_MaHoaDes(Directory.GetCurrentDirectory() + "\\DLL\\KhoiTao_DES", Directory.GetCurrentDirectory() + "\\DLL\\ASCtoNhiPhan");

        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {
                    txtBanMaHoa.Text = DES.DES(txtBanRo.Text, txtKhoa.Text);
                    txtKetQua.Text = team6_MaHoaDes.thaoTac;
                }
                else
                    MessageBox.Show("Hãy nhập từ cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfl = new SaveFileDialog();
            sfl.Filter = "TEXT|*.txt";
            if (sfl.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfl.FileName, txtBanMaHoa.Text);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã Hóa Khối DES\n Thực hiện: Team 6\n Thành viên:\nNguyễn Trà Thanh Trí\n Trần Thị Thanh Trang\n Trần Thanh Linh\nNguyễn Minh Trung\n Đỗ Thanh Nhàn\n Liên hệ: CNPM Team 6", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGiaMa_Click(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {

                    
                    txtBanGiaiMa.Text = txtBanRo.Text;


                }
                else
                    MessageBox.Show("Hãy nhập từ cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
