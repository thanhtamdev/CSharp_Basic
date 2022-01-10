using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* Biến là một ô nhớ trong bộ nhớ chứa dữ liệu
             - Khai báo biến: kiểu_dữ_liệu tên_biến = giá_trị;
             
             */

            // ví dụ khai báo biến: 
            int x = 2;
            float y = 1.25f; // hoặc F
            char c = 't';
            int age = 25;
            string fullName = "Nguyen Thanh Tam";

            Console.WriteLine(" Min int32 " + Int32.MinValue);
            Console.WriteLine(" Max int32 " + Int32.MaxValue);
        }
    }
}
