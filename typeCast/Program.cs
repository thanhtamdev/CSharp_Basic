using System;

namespace typeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ép kiểu có hai loại:
            // Ép kiểu tường minh (Explicit type conversion): do người dùng thực hiện
            //      + Xảy ra khi chuyển từ kiểu lớn qua kiểu nhỏ
            //      + Chuyển từ lớp cơ sở qua lớp dẫn xuất
            //  + cú pháp: (kiểu_nhỏ) tên_biến;
            //             (kiểu_dẫn_xuất) tên_biến;

            double a = 1.2356;
            int b = (int) a;

            object t = 9;
            int z = (int) t;


            // - Ép kiểu ngầm định (Implicit type conversion): do C# tự thực hiện
            //      + Xảy ra khi chuyển từ kiểu nhỏ sang kiểu lớn
            //      + Hoặc chuyển từ lớp dẫn xuất (lớp con) qua lớp cơ sở (lớp cha)

            // Ví dụ:
            int x = 12;
            float y = x;    // chuyển từ kiểu nhỏ sang kiểu lớn hơn

            string str = "Nguyen Van A";
            object obj = str;   // lớp dẫn xuất qua lớp cơ sở

            // Sử dụng lớp Convert: thường được sử dụng để chuyển từ kiểu chuỗi sang kiểu số
            string s = "10.0";
            int mark = Convert.ToInt32(s);

            // Ngoài ra có thể sử dụng hàm: kiểu_dữ_liệu.Parse(tên_biến);
            string count = "100";
            int counts = int.Parse(count);
        }
    }
}
