using System;

namespace InputOutputData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Xuất dữ liệu ra màn hình dùng Write và WriteLine
            // xuất dữ liệu không có định dạng
            // Console.Write(); hoặc Console.WriteLine();

            /*
            Console.Write();    // xuất dữ liệu ra, sau đó không xuống hàng
            Console.WriteLine();    // xuất dữ liệu ra sau đó xuống dòng mới
            */

            Console.Write("Hello world!");
            Console.WriteLine("Hello world!");

            string fullName = "Nguyen Van A";

            // In ra màn hình Hello, Nguyen Van A
            Console.WriteLine("Hello, " + fullName);    // sử dụng toán tử + khi xuất để nối các chuỗi

            int a = 3, b = 6;
            int sum = 9;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine(a + " + " + b + " = " + sum);

            // Xuất dữ liệu có định dạng
            int x = 5;
            int y = 9;
            int z = 45;

            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.WriteLine("{0} * {1} = {2}", x, y, z);

            double luong = 123432.21334654;

            Console.WriteLine("{0}", luong);
            Console.WriteLine("{0, 20 : 0.00}", luong); // 0.00 làm tròn 2 số sau phần thập phân
            Console.WriteLine("{0, -20}", luong);

            // Nhập dữ liệu từ bàn phím
            // variable = Console.ReadLine();
            Console.Write("Nhap ten cua ban: ");
            string name = Console.ReadLine();

            Console.WriteLine(" Xin chào, " + name);

            // Dữ liệu nhập trên màn hình console mặc đinh là string nên muốn nhập kiểu số
            // thì cần phải chuyển kiểu. sử dụng lớp
            Console.WriteLine("Nhập tuổi của bạn: ");
            int age = int.Parse(Console.ReadLine());

            // một số kí tự đặc biệt
            // \t = tab ngang
            // \n = xuống dòng
        }
    }
}
