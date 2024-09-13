using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ban muon thue san nao :");
            Console.WriteLine("\t San nhan tao (70k/h) => Bam phim 1");
            Console.WriteLine("\t San co (50k/h) => Bam phim 2");
            Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                a = 70000;
            }
            else if (a == 2)
            {
                a = 50000;
            }
            Console.Write("Ban thue trong bao lau (gio) :"); b = int.Parse(Console.ReadLine());
            double tongTien = a  * b;
            Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
            Console.ReadLine();
        }
    }
}
