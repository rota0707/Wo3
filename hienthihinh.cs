using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice > 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print the rectangle.");
                Console.WriteLine("2. Print the square triangle (top-left) ");
                Console.WriteLine("3. Print the square triangle (top-right) ");
                Console.WriteLine("4. Print the square triangle (botton-left) ");
                Console.WriteLine("5. Print the square triangle (botton-right) ");
                Console.WriteLine("6. Print isosceles triangle ");
                Console.WriteLine("0. Exit");
                Console.Write("Chon: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    int witdh_hcn, height_hcn;
                    Console.Write("Nhap chieu dai: ");
                    witdh_hcn = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    height_hcn = int.Parse(Console.ReadLine());

                    // Vòng lặp hiển thị số dòng
                    for (int j = 1; j <= height_hcn; j++)
                    {
                        //Vòng lặp hiển thị số cột
                        for (int i = 1; i <= witdh_hcn; i++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (num == 2)
                {
                    Console.Write("Nhap chieu dai canh: ");
                    int width_tamgiac2 = int.Parse(Console.ReadLine());
                    for (int j = width_tamgiac2; j >= 1; j--)
                    {
                        for (int i = 1; i <= j; i++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }

                }
                else if (num == 3)
                {
                    Console.Write("Nhap chieu dai canh: ");
                    int width_tamgiac3 = int.Parse(Console.ReadLine());
                    for (int i = 1;i <= width_tamgiac3; i++)
                    { 
                       
                        for ( int j = 1; j < i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = i;k < width_tamgiac3; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();   
                    }
                }else if (num == 4)
                {
                    Console.Write("Nhap chieu dai canh: ");
                    int width_tamgiac4 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= width_tamgiac4; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }else if(num == 5)
                {
                    Console.Write("Nhap chieu dai canh: ");
                    int width_tamgiac5 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= width_tamgiac5; i++)
                    {

                        for (int j = i; j < width_tamgiac5; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k < i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }else if (num == 6)
                {
                    Console.Write("Nhap chieu dai canh: ");
                    int width_tamgiac6 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= width_tamgiac6; i++)
                    {

                        for (int j = i; j < width_tamgiac6; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k < i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }else
                {
                    Console.WriteLine("Thank You!!!");
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
    
}
