using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homeework_m
{
    class Program
    {
        static void Main(string[] args)
        {
            double xm=3.0, xl, xh, u, x;

            Console.WriteLine("퍼지집합 A={3에 가까운 실수}");
            Console.WriteLine("퍼지집합 A에 대한 입력값 x에 대한 소속도를 출력합니다.");
            Console.WriteLine("x를 입력하세요.");

            string sx = Console.ReadLine();
            x = int.Parse(sx);

            xl = xm - 3;
            xh = xm + 3;

            if (x <= xl || x >= xh)
            {
                u = 0;
            }
            else if (x > xm)
            {
                u = (xh - x) / (xh - xm);
            }
            else if (x < xm)
            {
                u = (x - xl) / (xm - xl);
            }
            else
            {
                u = 1;
            }

            Console.WriteLine("소속도는 {0:f5}입니다.", u);
        }
    }
}
