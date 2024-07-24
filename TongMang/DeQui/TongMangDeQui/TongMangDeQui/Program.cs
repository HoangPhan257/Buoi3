using System;
using System.Text;

namespace TongMangDeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập số lượng phần tử trong mảng
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo mảng a
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử trong mảng bằng phương pháp chia để trị
            int sum = TongDeQuy(a, 0, n - 1);

            // Hiển thị kết quả
            Console.WriteLine("Tổng các phần tử trong mảng là: {0}", sum);


            Console.ReadLine();
        }

        static int TongDeQuy(int[] a, int left, int right)
        {
            
            if (left > right)
            {
                return 0;
            }         
            int mid = (left + right) / 2;           
            int sumLeft = TongDeQuy(a, left, mid);
            int sumRight = TongDeQuy(a, mid + 1, right);
            return sumLeft + sumRight;
        }
    }
}
