using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReadNumPrintTenTimes
    {
        public void PrintTenTimes() 
        {
            Console.WriteLine("Enter any number : ");
            string number=Console.ReadLine();
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(number);
            }
        }
    }
}
