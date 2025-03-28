using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public class Diem_52_Hao_54_Hieu
    {
        public int X_52_Hao_54_Hieu, Y_52_Hao_54_Hieu;

        public Diem_52_Hao_54_Hieu(int X_52_Hao_54_Hieu, int Y_52_Hao_54_Hieu)
        {
            this.X_52_Hao_54_Hieu = X_52_Hao_54_Hieu;
            this.Y_52_Hao_54_Hieu = Y_52_Hao_54_Hieu;
        }
        public bool IsTrung_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu d_52_Hao_54_Hieu)
        {
            return this.X_52_Hao_54_Hieu == d_52_Hao_54_Hieu.X_52_Hao_54_Hieu && this.Y_52_Hao_54_Hieu == d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;
        }
        public bool IsDuongThang_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu d_52_Hao_54_Hieu)
        {
            if ((d_52_Hao_54_Hieu.X_52_Hao_54_Hieu == this.X_52_Hao_54_Hieu) && (d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu != this.Y_52_Hao_54_Hieu))
                return true;
            if ((d_52_Hao_54_Hieu.X_52_Hao_54_Hieu != this.X_52_Hao_54_Hieu) && (d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu == this.Y_52_Hao_54_Hieu))
                return true;
            return false;
        }
    }

    public class HinhChuNhat_52_Hao_54_Hieu
    {
        public Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu;
        public Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu;

        public HinhChuNhat_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {
            if (DiemDuoiPhai_52_Hao_54_Hieu.IsTrung_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu))
                throw new ArgumentException("Hai điểm trùng nhau");
            if (DiemDuoiPhai_52_Hao_54_Hieu.IsDuongThang_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu))
                throw new ArgumentException("Hai điểm tạo đường thẳng");
            if (!KiemTraToaDoHopLe(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu))
                throw new ArgumentException("Tọa độ không hợp lệ! Điểm trên trái phải nhỏ hơn điểm dưới phải");

            this.DiemTrenTrai_52_Hao_54_Hieu = DiemTrenTrai_52_Hao_54_Hieu;
            this.DiemDuoiPhai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu;
        }
        // X của điểm trên trái phải nhỏ hơn X của điểm dưới phải.
        // Y của điểm trên trái phải nhỏ hơn Y của điểm dưới phải.
        private static bool KiemTraToaDoHopLe(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {
            return DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu &&
                   DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;
        }

        public object ThucThi_52_Hao_54_Hieu(string chucNang_52_Hao_54_Hieu, HinhChuNhat_52_Hao_54_Hieu hcnKhac_52_Hao_54_Hieu = null)
        {
            double ketQua_52_Hao_54_Hieu = 0;
            int ChieuDai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu - DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu;
            int ChieuRong_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu - DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;
            switch (chucNang_52_Hao_54_Hieu)
            {
                case "DienTich":
                    ketQua_52_Hao_54_Hieu = ChieuDai_52_Hao_54_Hieu * ChieuRong_52_Hao_54_Hieu;
                    return ketQua_52_Hao_54_Hieu;
                    break;
                case "ChuVi":
                    ketQua_52_Hao_54_Hieu = 2 * (ChieuDai_52_Hao_54_Hieu + ChieuRong_52_Hao_54_Hieu);
                    return ketQua_52_Hao_54_Hieu;
                    break;
                case "DuongCheo":
                    ketQua_52_Hao_54_Hieu = Math.Sqrt(ChieuDai_52_Hao_54_Hieu * ChieuDai_52_Hao_54_Hieu + ChieuRong_52_Hao_54_Hieu * ChieuRong_52_Hao_54_Hieu);
                    return ketQua_52_Hao_54_Hieu;
                    break;
                case "GiaoNhau":
                    if (hcnKhac_52_Hao_54_Hieu == null)
                        return false; // Trả về false nếu không có hình chữ nhật thứ hai để kiểm tra

                    bool giaoNhau = !(DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                                      DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu > hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                                      DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu ||
                                      DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu > hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu);

                    return giaoNhau; // Trả về kiểu boolean, true nếu giao nhau, false nếu không
                default:
                    return "Chức năng không hợp lệ."; // Trả về chuỗi nếu sai chức năng
            }
        }
    }
}