using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ShiftAllZeroToEnd
    {
        public static void ShiftZeroArray()
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
            ShiftZero(arr);
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
        public static void ShiftZero(int[] arr)
        {
            int start = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    arr[start] = arr[i];
                    start++;
                }
            }
            for(int i = start; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
    }
}
