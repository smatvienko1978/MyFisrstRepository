using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1WeekPreparationKit
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            foreach (var item in arr)
            {
                if (item > 0) positive++;
                if (item < 0) negative++;
                if (item == 0) zero++;
            }
            Console.WriteLine("{0:F6}", positive/arr.Count);
            Console.WriteLine("{0:F6}", negative / arr.Count);
            Console.WriteLine("{0:F6}", zero / arr.Count);
        }
        static void Main(string[] args)
        {
            plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1 });
                //expect
                //0.500000
                //0.333333
                //0.166667
            Console.ReadKey();
        }
    }
}
