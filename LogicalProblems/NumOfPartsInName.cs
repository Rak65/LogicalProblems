using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class NumOfPartsInName
    {
        public void FullName() 
        {
            Console.WriteLine("Enter your FullName: ");
            string fullName=Console.ReadLine();
            string[] nameSplit = fullName.Split(' ');
            Console.WriteLine(nameSplit.Length);
            Console.WriteLine(fullName);
        }
    }
}
