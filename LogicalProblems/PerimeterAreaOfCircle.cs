using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerimeterAreaOfCircle
    {
        public void PerimeterArea()
        {
            Console.WriteLine("Enter diameter of the circle : ");
            int diameter=Convert.ToInt32(Console.ReadLine());
            double perimeter=Math.PI*diameter;
            double area = (Math.PI / 4) * Math.Pow(diameter, 2);
            Console.WriteLine("Perimeter of circle = " + perimeter);
            Console.WriteLine("Area of circle= " + area);
        }
    }
}
