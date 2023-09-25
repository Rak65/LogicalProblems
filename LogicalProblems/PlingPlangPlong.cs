using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PlingPlangPlong
    {
        public static void PlingPlangP()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = "";

            if (number % 3 == 0)
                result +="Pling";
            if (number % 5 == 0)
                result +="Plang";
            if (number % 7 == 0)
                result +="Plong";

            if(string.IsNullOrEmpty(result))
                result=number.ToString();

            Console.WriteLine(result);
        }
    }
}
