using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CheckPresence
    {
        public static void AEP()
        {
            Console.WriteLine("Enter the string.");
            string input=Console.ReadLine();

            bool a=input.Contains("a");
            bool e=input.Contains("e");
            bool p=input.Contains("p");

            if (a && e && p)
                Console.WriteLine("All Present.");
            else if (a || e || p)
                Console.WriteLine("One or more present.");
            else 
                Console.WriteLine("None Present");
            Console.WriteLine();
        }
    }
}
