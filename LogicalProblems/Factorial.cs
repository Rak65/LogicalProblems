using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Factorial
    {
        public static int FactorialNum()
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            while (num > 0)
            {
                f *= num;
                num--;
            }
            return f;
        }
    }
}
