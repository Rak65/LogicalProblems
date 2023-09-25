using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrintNumNotUseLoop
    {
        public static void Print1To100(int num)
        {
            if(num <= 100)
            {
                Console.Write(num + " ");
                Print1To100(num + 1);
            }            
        }
    }
}
