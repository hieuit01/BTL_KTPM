using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    // Lớp HinhChuNhat_52_Hao_54_Hieu đại diện cho hình chữ nhật trong hệ tọa độ 2D
    public class HinhChuNhat_52_Hao_54_Hieu
    {
        // Hai điểm định nghĩa hình chữ nhật: điểm trên trái và điểm dưới phải
        public Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu;
        public Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu;

        // Constructor: Khởi tạo đối tượng Hình chữ nhật với hai điểm được truyền vào
        public HinhChuNhat_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {
            // Kiểm tra nếu hai điểm nằm trên cùng một đường thẳng dọc/ngang thì ném ra lỗi
            if (DiemDuoiPhai_52_Hao_54_Hieu.IsDuongThang_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu))
                throw new ArgumentException("Hai điểm tạo đường thẳng");

            // Kiểm tra nếu hai điểm trùng nhau thì ném ra lỗi
            if (DiemDuoiPhai_52_Hao_54_Hieu.IsTrung_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu))
                throw new ArgumentException("Hai điểm trùng nhau");

            //Kiểm tra tọa độ có âm không
            if (IsAm(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu))
                throw new ArgumentException("Tọa độ không nhận giá trị âm");

            // Kiểm tra tọa độ có hợp lệ không (điểm trên trái phải nằm trên và trái điểm dưới phải)
            if (!KiemTraToaDoHopLe(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu))
                throw new ArgumentException("Tọa độ không hợp lệ! Điểm trên trái phải nhỏ hơn điểm dưới phải");
            

            // Gán giá trị cho các thuộc tính
            this.DiemTrenTrai_52_Hao_54_Hieu = DiemTrenTrai_52_Hao_54_Hieu;
            this.DiemDuoiPhai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu;
        }

        ////Hàm kiểm tra tọa độ hợp lệ(điểm trên trái phải nhỏ hơn điểm dưới phải)
        private static bool KiemTraToaDoHopLe(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {
            return DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu &&
                   DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;
        }

        private static bool IsAm(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {
            return DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < 0 || DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < 0 ||
                   DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < 0 || DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < 0;
        } 

        // Hàm thực thi các chức năng (Diện tích, Chu vi, Đường chéo, Giao nhau)
        public object ThucThi_52_Hao_54_Hieu(string chucNang_52_Hao_54_Hieu, HinhChuNhat_52_Hao_54_Hieu hcnKhac_52_Hao_54_Hieu = null)
        {
            // Tính chiều dài và chiều rộng của hình chữ nhật
            int ChieuDai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu - DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu;
            int ChieuRong_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu - DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;

            // Dùng switch-case để thực hiện các chức năng
            switch (chucNang_52_Hao_54_Hieu)
            {
                // Tính diện tích (chiều dài * chiều rộng)
                case "DienTich":
                    return ChieuDai_52_Hao_54_Hieu * ChieuRong_52_Hao_54_Hieu;

                // Tính chu vi (2 * (chiều dài + chiều rộng))
                case "ChuVi":
                    return 2 * (ChieuDai_52_Hao_54_Hieu + ChieuRong_52_Hao_54_Hieu);

                // Tính độ dài đường chéo (căn bậc 2 của (chiều dài^2 + chiều rộng^2))
                case "DuongCheo":
                    return Math.Sqrt(ChieuDai_52_Hao_54_Hieu * ChieuDai_52_Hao_54_Hieu +
                                                      ChieuRong_52_Hao_54_Hieu * ChieuRong_52_Hao_54_Hieu);

                // Kiểm tra hai hình chữ nhật có giao nhau hay không
                case "GiaoNhau":
                    // Nếu không có hình chữ nhật thứ hai thì trả về false
                    if (hcnKhac_52_Hao_54_Hieu == null)
                        return false;

                    // Kiểm tra điều kiện không giao nhau:
                    // 1. Một hình ở bên trái hoàn toàn của hình kia
                    // 2. Một hình ở bên phải hoàn toàn của hình kia
                    // 3. Một hình ở trên hoàn toàn của hình kia
                    // 4. Một hình ở dưới hoàn toàn của hình kia
                    bool giaoNhau = !(DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                                      DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu > hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                                      DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu ||
                                      DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu > hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu);

                    // Trả về true nếu giao nhau, false nếu không
                    return giaoNhau;

                default:
                    return "Chức năng không hợp lệ";
            }
        }
    }
}
