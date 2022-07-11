using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Method
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            int sum = x + y;

            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            if (isTrue && sum == 1)
            {
                return $"1 dollar";
            }
            return "boolean was false";
        }
    }
}
