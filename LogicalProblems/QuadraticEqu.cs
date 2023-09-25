using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class QuadraticEqu
    {
        public static void QuadraticEquation()
        {
            Console.WriteLine("Enter a : ");
            double a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            double b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c : ");
            double c= Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;

            if(d > 0)
            {
                double root1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two Distinct real roots.");
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if(d == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Real root:");
                Console.WriteLine("Root: " + root);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
            Console.WriteLine();
        }
    }
}
