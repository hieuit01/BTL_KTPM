using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Import namespace chứa class TinhDienTich_52_Hao_54_Hieu
using DoAn_KTPM_52_Hao_54_Hieu;

namespace HinhChuNhatTester_52_Hao_54_Hieu
{
    [TestClass]
    public class UnitTestHCN_52_Hao_54_Hieu
    {
        private HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu, hcn2_52_Hao_54_Hieu;
        private Diem_52_Hao_54_Hieu DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu, DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu;

        //[TestInitialize]
        ////Thiết lập dữ liệu dùng cho kiểm thử
        //public void SetUp_52_Hao_54_Hieu()
        //{
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 6);

        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);
        //}
        ////TEST CASE VỚI DỮ LIỆU HỢP LỆ
        //[TestMethod]
        ////TC1: Tính diện tích hcn1 với tọa độ điểm trên trái là (0, 0) và tọa độ điểm dưới phải là (4, 3), kết quả mong đợi là 12 và
        ////hcn2 với tọa độ điểm trên trái là (2, 3) và tọa độ điểm dưới phải là (6, 5), kết quả mong đợi là 9
        //public void TC1_DienTich_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo điểm trên trái (0, 0) và điểm dưới phải (4, 3) của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
        //    //Khởi tạo điểm trên trái (2, 3) và điểm dưới phải (6, 6) của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 3);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 5);

        //    //Tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    //Giá trị kỳ vọng của hcn1 = 12, hcn2 = 9
        //    int expected_HCN1_52_Hao_54_Hieu = 12;
        //    int expected_HCN2_52_Hao_54_Hieu = 9;
        //    //Giá trị thực tế
        //    int actual_HCN1_52_Hao_54_Hieu = (int)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
        //    int actual_HCN2_52_Hao_54_Hieu = (int)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DienTich");
        //    //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
        //    Assert.AreEqual(expected_HCN1_52_Hao_54_Hieu, actual_HCN1_52_Hao_54_Hieu);
        //    Assert.AreEqual(expected_HCN2_52_Hao_54_Hieu, actual_HCN2_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC2: Tính chu vi hcn1 với tọa độ điểm trên trái là (1, 2) và tọa độ điểm dưới phải là (3, 4), kết quả mong đợi là 8 và
        ////hcn2 với tọa độ điểm trên trái là (3, 2) và tọa độ điểm dưới phải là (6, 4), kết quả mong đợi là 10
        //public void TC2_ChuVi_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo điểm trên trái (1, 2) và điểm dưới phải (3, 4) của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 2);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 4);
        //    //Khởi tạo điểm trên trái (3, 2) và điểm dưới phải (6, 4) của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 2);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 4);

        //    //Tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    //Giá trị kỳ vọng của hcn1 = 8, hcn2 = 10
        //    int expected_HCN1_52_Hao_54_Hieu = 8;
        //    int expected_HCN2_52_Hao_54_Hieu = 10;
        //    //Giá trị thực tế
        //    int actual_HCN1_52_Hao_54_Hieu = (int)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
        //    int actual_HCN2_52_Hao_54_Hieu = (int)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("ChuVi");
        //    //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
        //    Assert.AreEqual(expected_HCN1_52_Hao_54_Hieu, actual_HCN1_52_Hao_54_Hieu);
        //    Assert.AreEqual(expected_HCN2_52_Hao_54_Hieu, actual_HCN2_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC3: Tính diện tích hcn1 với tọa độ điểm trên trái là (4, 2) và tọa độ điểm dưới phải là (8, 5), kết quả mong đợi là 5 và
        ////hcn2 với tọa độ điểm trên trái là (2, 5) và tọa độ điểm dưới phải là (7, 9), kết quả mong đợi là 6.4031
        //public void TC3_DuongCheo_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo điểm trên trái (4, 2) và điểm dưới phải (8, 5) của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 2);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(8, 5);
        //    //Khởi tạo điểm trên trái (2, 5) và điểm dưới phải (7, 9) của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 5);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(7, 9);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    //Giá trị kỳ vọng của hcn1 = 5, hcn2 = 6.4031
        //    double expected_HCN1_52_Hao_54_Hieu = 5;
        //    double expected_HCN2_52_Hao_54_Hieu = 6.4031;
        //    //Giá trị thực tế
        //    double actual_HCN1_52_Hao_54_Hieu = (double)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
        //    double actual_HCN2_52_Hao_54_Hieu = (double)hcn2_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("DuongCheo");
        //    //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
        //    Assert.AreEqual(expected_HCN1_52_Hao_54_Hieu, actual_HCN1_52_Hao_54_Hieu, 0.0001);
        //    Assert.AreEqual(expected_HCN2_52_Hao_54_Hieu, actual_HCN2_52_Hao_54_Hieu, 0.0001);
        //}

        //[TestMethod]
        //// TC4: Kiểm tra hai hình chữ nhật có giao nhau (Giao nhau 1 phần)
        //public void TC4_GiaoNhau_MotPhan_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 5);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(7, 6);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    // Kiểm tra xem hai hình chữ nhật có giao nhau hay không
        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    // Kiểm tra kết quả, xác minh rằng hai hình chữ nhật thực sự giao nhau
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC5: Giao nhau ở góc
        //public void TC5_GiaoNhau_Goc_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 5);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC6: Giao nhau ở cạnh bên
        //public void TC6_GiaoNhau_CanhBen_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 0);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 3);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC7: Một hình chữ nhật nằm trong hình chữ nhật kia
        //public void TC7_NamTrong_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 1);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 2);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC8: Hai hình chữ nhật trùng nhau
        //public void TC8_TrungNhau_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    // Hình chữ nhật thứ hai có tọa độ giống hệt hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    // Kỳ vọng kết quả là true vì chúng trùng nhau
        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC9: Hai hình chữ nhật không giao nhau
        //public void TC9_KhongGiaoNhau_52_Hao_54_Hieu()
        //{
        //    //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 1);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 3);

        //    // Hình chữ nhật thứ hai có tọa độ giống hệt hình chữ nhật thứ nhất
        //    DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 4);
        //    DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(7, 7);

        //    //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
        //    hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

        //    // Kỳ vọng kết quả là true
        //    bool actual_52_Hao_54_Hieu = (bool)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("GiaoNhau", hcn2_52_Hao_54_Hieu);
        //    Assert.IsTrue(actual_52_Hao_54_Hieu);
        //}

        //[TestMethod]
        //// TC9: Trường hợp nhập sai chức năng
        //public void TC9_ChucNangKhongHopLe_52_Hao_54_Hieu()
        //{
        //    string expected_52_Hao_54_Hieu = "Chức năng không hợp lệ";
        //    string actual_52_Hao_54_Hieu = (string)hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("SaiChucNang");
        //    Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        //}

        //TEST CASE VỚI DỮ LIỆU KHÔNG HỢP LỆ
        [TestMethod]
        // TC9: Kiểm tra khi điểm trên trái và điểm dưới phải trùng nhau (hình chữ nhật không hợp lệ)
        public void TC9_HaiDiemTrungNhau_Hao_54_Hieu()
        {
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 2);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 2);

            //Kiểm tra xem ngoại lệ có được ném ra hay không
            Assert.ThrowsException<ArgumentException>(() => hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu));
        }

        [TestMethod]
        // TC10: Kiểm tra khi điểm dưới phải có tọa độ nhỏ hơn điểm trên trái (tọa độ không hợp lệ)
        public void TC10_KiemTraToaDoHopLe_52_Hao_54_Hieu()
        {
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 5);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 2);

            //Kiểm tra xem ngoại lệ có được ném ra hay không
            Assert.ThrowsException<ArgumentException>(() => hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu));
        }

        [TestMethod]
        // TC11: Kiểm tra khi tọa độ có giá trị âm
        public void TC11_KiemTraGiaTriAm_52_Hao_54_Hieu()
        {
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(-1, -1);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(-3, -4);

            //Kiểm tra xem ngoại lệ có được ném ra hay không
            Assert.ThrowsException<ArgumentException>(() => hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu));
        }

        [TestMethod]
        // TC12: Kiểm tra hai tọa độ nhập vào có là đường thẳng hai không
        public void TC12_KiemTraDuongThang_52_Hao_54_Hieu()
        {
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 1);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 1);

            //Kiểm tra xem ngoại lệ có được ném ra hay không
            Assert.ThrowsException<ArgumentException>(() => hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu));
        }

        //[TestMethod]
        //// TC5: Kiểm tra gọi phương thức không tồn tại
        //public void TC5_Invalid_MethodCall_52_Hao_54_Hieu()
        //{
        //    DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 0);
        //    DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
        //    hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);

        //    hcn1_52_Hao_54_Hieu.ThucThi_52_Hao_54_Hieu("KhongTonTai");
        //}

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"..\..\Data\TestData4Col_54_Hieu.csv", "TestData4Col_54_Hieu#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC7_54_Hieu_3Pass_1Fail_TestWithDataSuorce_4Col()
        {
            //Lấy dữ liệu của các cột a, b, operation, expected
            int a_54_Hieu = int.Parse(TestContext.DataRow[0].ToString());
            int b_54_Hieu = int.Parse(TestContext.DataRow[1].ToString());
            string operation_54_Hieu = TestContext.DataRow[2].ToString();
            operation_54_Hieu = operation_54_Hieu.Replace("'", ""); // Loại bỏ dấu ' nếu có
            Console.WriteLine(operation_54_Hieu);
            int expected_54_Hieu = int.Parse(TestContext.DataRow[3].ToString());

            Caculation_54_hieu c_54_Hieu = new Caculation_54_hieu(a_54_Hieu, b_54_Hieu);
            int actual_54_Hieu = c_54_Hieu.Excute_54_hieu(operation_54_Hieu);//Thực hiện phép tính
            Assert.AreEqual(expected_54_Hieu, actual_54_Hieu);//So sánh kết quả thực tế với kết quả kỳ vọng
        }
    }
}
