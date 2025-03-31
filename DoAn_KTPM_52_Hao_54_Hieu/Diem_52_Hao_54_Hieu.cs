using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public class Diem_52_Hao_54_Hieu
    {
        // Hai thuộc tính X và Y đại diện cho tọa độ của điểm
        public int X_52_Hao_54_Hieu, Y_52_Hao_54_Hieu;

        // Constructor: Dùng để khởi tạo đối tượng với giá trị X và Y được truyền vào
        public Diem_52_Hao_54_Hieu(int X_52_Hao_54_Hieu, int Y_52_Hao_54_Hieu)
        {
            this.X_52_Hao_54_Hieu = X_52_Hao_54_Hieu;
            this.Y_52_Hao_54_Hieu = Y_52_Hao_54_Hieu;
        }

        //Phương thức kiểm tra xem hai điểm có trùng nhau không
        public bool IsTrung_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu d_52_Hao_54_Hieu)
        {
            // Nếu cả X và Y của hai điểm bằng nhau thì trả về true (hai điểm trùng nhau)
            return this.X_52_Hao_54_Hieu == d_52_Hao_54_Hieu.X_52_Hao_54_Hieu
                && this.Y_52_Hao_54_Hieu == d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;
        }

        // Phương thức kiểm tra xem hai điểm có nằm trên cùng một đường thẳng dọc hoặc ngang không
        public bool IsDuongThang_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu d_52_Hao_54_Hieu)
        {
            // Kiểm tra xem hai điểm có cùng hoành độ (X) nhưng khác tung độ (Y) không
            // => Nếu đúng, chúng nằm trên cùng một đường thẳng đứng
            if ((d_52_Hao_54_Hieu.X_52_Hao_54_Hieu == this.X_52_Hao_54_Hieu)
                && (d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu != this.Y_52_Hao_54_Hieu))
                return true;

            // Kiểm tra xem hai điểm có cùng tung độ (Y) nhưng khác hoành độ (X) không
            // => Nếu đúng, chúng nằm trên cùng một đường thẳng ngang
            if ((d_52_Hao_54_Hieu.X_52_Hao_54_Hieu != this.X_52_Hao_54_Hieu)
                && (d_52_Hao_54_Hieu.Y_52_Hao_54_Hieu == this.Y_52_Hao_54_Hieu))
                return true;

            // Nếu không thỏa mãn cả hai điều kiện trên, trả về false (hai điểm không thẳng hàng theo trục X hoặc Y)
            return false;
        }
    }
}
