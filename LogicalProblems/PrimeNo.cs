using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNo
    {
        public static void Prime()
        {
            Console.WriteLine("Enter the number of element in the array.");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Elements " + (i + 1) + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            List<int> primeno = new List<int>();
            for(int i = 0;i < arr.Length;i++)
            {
                int j = 2, count = 0;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                    }
                    j++;
                }
                if(count == 0)
                    primeno.Add(arr[i]);
            }
            Console.WriteLine("Prime numbers : ");
            foreach (int prime in primeno)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();

        }
    }
}
