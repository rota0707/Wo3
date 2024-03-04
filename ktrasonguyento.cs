using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrasonguyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 2) 
            {
                Console.WriteLine(num + " khong phai la SNT.");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(num))
                {
                    if (num % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(num + " la SNT.");
                }
                else
                {
                    Console.WriteLine(num + " khong phai la SNT.");
                }
            }
            Console.ReadKey();
        }
    }
}
