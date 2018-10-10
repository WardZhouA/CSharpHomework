using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    class Program
    {
        static void Main(string[] args)
        {
            HannoiCalculate c = new HannoiCalculate();
            double result = c.calculation(64);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
    class HannoiCalculate
    {
        public double calculation(double a)
        {
            if (a==1)
            {
                return 1;
            }
            else
            {
                double sum = 1;
                sum += calculation(a - 1) * 2;
                return sum;
            }
        }
    }
}
// 1 1
// 2 2+1
// 3