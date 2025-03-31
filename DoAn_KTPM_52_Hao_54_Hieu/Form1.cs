using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public partial class HinhChuNhatApp : Form
    {
        public HinhChuNhatApp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Xử lý sự kiện khi nhấn nút tính diện tích
        private void btn_TinhDT_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ của hình chữ nhật thứ nhất từ các ô nhập liệu
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            // Lấy tọa độ của hình chữ nhật thứ hai
            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            // Tạo đối tượng hình chữ nhật từ tọa độ
            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            // Tính diện tích của hình chữ nhật 1
            double KqDT1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqDT1_52_Hao_54_Hieu.ToString();

            // Tính diện tích của hình chữ nhật 2
            double KqDT2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqDT2_52_Hao_54_Hieu.ToString();
        }

        // Xử lý sự kiện khi nhấn nút tính chu vi
        private void btn_TinhChuVi_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ hình chữ nhật thứ nhất
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            // Lấy tọa độ hình chữ nhật thứ hai
            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            // Tạo hai đối tượng hình chữ nhật
            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            // Tính chu vi hình chữ nhật 1
            double KqCV1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqCV1_52_Hao_54_Hieu.ToString();

            // Tính chu vi hình chữ nhật 2
            double KqCV2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqCV2_52_Hao_54_Hieu.ToString();
        }

        // Xử lý sự kiện khi nhấn nút tính đường chéo
        private void btn_DuongCheo_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ hình chữ nhật thứ nhất
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            // Lấy tọa độ hình chữ nhật thứ hai
            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            // Tạo hai đối tượng hình chữ nhật
            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            // Tính đường chéo hình chữ nhật 1
            double KqDC1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqDC1_52_Hao_54_Hieu.ToString();

            // Tính đường chéo hình chữ nhật 2
            double KqDC2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqDC2_52_Hao_54_Hieu.ToString();
        }

        // Xử lý sự kiện khi nhấn nút kiểm tra giao nhau
        private void btn_GiaoNhau_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ hai hình chữ nhật từ ô nhập liệu
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            // Tạo hai hình chữ nhật
            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            // Kiểm tra xem hai hình chữ nhật có giao nhau không
            bool KqKtGiaoNhau_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
            if (KqKtGiaoNhau_52_Hao_54_Hieu)
                txt_KqKT_52_Hao_54_Hieu.Text = "Hai hình chữ nhật giao nhau";
            else
                txt_KqKT_52_Hao_54_Hieu.Text = "Hai hình chữ nhật không giao nhau";
        }
    }
}
