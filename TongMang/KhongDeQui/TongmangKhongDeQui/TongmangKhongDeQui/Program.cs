using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TongPhanTuTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

           
            int n = 5;
            int[] a = { 10, 20, 30, 40, 50 };
            Console.Write("Mảng a gồm :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine(  );
            // chia ra 2 mảng con
            int[] b = new int[n / 2]; 
            int[] c = new int[n - (n / 2)]; 
          
            for (int i = 0; i < n / 2; i++)
            {
                b[i] = a[i];
            }
            for (int i = n / 2; i < n; i++)
            {
                c[i - (n / 2)] = a[i];
            }

            // tính sum 
            int sumA = 0, sumB = 0, sumC = 0;
            
            for (int i = 0; i < n / 2; i++)
            {
                sumB += b[i];
            }
            for (int i = 0; i < n - (n / 2); i++)
            {
                sumC += c[i];
            }

            sumA = sumC + sumB;
            //xuất kết quả 
            Console.WriteLine("Tổng mảng b: {0}", sumB);
            Console.WriteLine("Tổng mảng c: {0}", sumC);
            Console.WriteLine("Tổng mảng a sẽ bằng tổng 2 mảng con b và c ");
            Console.WriteLine("Tổng mảng a: {0}", sumA);

            Console.ReadLine(); 
        }
    }
}
