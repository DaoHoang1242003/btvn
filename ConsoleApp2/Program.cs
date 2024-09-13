using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            var loaisan = San.nhantao;
            Console.WriteLine("Ban muon thue san nao :");
            Console.WriteLine("\t San nhan tao (70k/h) => Bam phim 1");
            Console.WriteLine("\t San co (50k/h) => Bam phim 2");
            Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                loaisan = San.nhantao;
            }
            else if (a == 2)
            {
                loaisan = San.sanco;
            }
            Console.Write("Ban choi trong bao lau (gio) :"); b = int.Parse(Console.ReadLine());
            double tongTien = Class1.TinhTongTien(loaisan, b);
            Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
            Console.ReadLine();
        }
    }
}
