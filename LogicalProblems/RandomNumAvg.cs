using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class RandomNumAvg
    {
        public void AvgNum()
        {
            Random random = new Random();
            int[] number = new int[5];
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(10,51);
                Console.Write(number[i]+" ");
                sum += number[i];
            }
            Console.WriteLine();
            Console.WriteLine("Random number average= "+sum/number.Length);
        }
    }
}
