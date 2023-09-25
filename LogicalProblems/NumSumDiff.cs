using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class NumSumDiff
    {
        public void SqNumSumDiff()
        {
            Console.WriteLine("Enter two numbers : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            double diff = a- b;
            Console.WriteLine("Square of sum of 2 num : "+(sum*sum));
            Console.WriteLine("Square of diff of 2 num:"+(diff*diff));
        }
    }
}
