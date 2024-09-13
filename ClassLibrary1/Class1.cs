using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public enum San
    {
        nhantao,
        sanco
    }
    public class Class1
    {
        private const int GiaNhanTAo = 70000;
        private const int GiaSanCo = 50000;

        public static double TinhTongTien(San san, double Gio)
        {
            double giaTien = san == San.nhantao ? GiaNhanTAo : GiaSanCo;
            return giaTien * Gio;
        }
    }
}
