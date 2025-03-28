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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void btn_TinhDT_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            double KqDT1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqDT1_52_Hao_54_Hieu.ToString();

            double KqDT2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqDT2_52_Hao_54_Hieu.ToString();
        }

        private void btn_TinhChuVi_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            double KqCV1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqCV1_52_Hao_54_Hieu.ToString();

            double KqCV2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqCV2_52_Hao_54_Hieu.ToString();
        }

        private void btn_DuongCheo_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            double KqDC1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
            txt_KqDT1_52_Hao_54_Hieu.Text = KqDC1_52_Hao_54_Hieu.ToString();

            double KqDC2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
            txt_KqDT2_52_Hao_54_Hieu.Text = KqDC2_52_Hao_54_Hieu.ToString();
        }

        private void btn_GiaoNhau_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu));
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu), new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu));

            bool KqKtGiaoNhau_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
            if (KqKtGiaoNhau_52_Hao_54_Hieu)
                txt_KqKT_52_Hao_54_Hieu.Text = "Hai hình chữ nhật giao nhau";
            else
                txt_KqKT_52_Hao_54_Hieu.Text = "Hai hình chữ nhật không giao nhau";
        }
    }
}
