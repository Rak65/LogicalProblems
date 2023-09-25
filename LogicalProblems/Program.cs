using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning) { 
            Console.WriteLine("Which Program you want to run: ");
            Console.WriteLine("1. Display your 5 friends name.");
            Console.WriteLine("2. Display square of sum of 2 num and square of difference of 2 num");
            Console.WriteLine("3. Display Most Visit Place.");
            Console.WriteLine("4. Read a number from user as string and print 10 times of that number as string only");
            Console.WriteLine("5. Number of Parts and Print Full Name.");
            Console.WriteLine("6. Random number average.");
            Console.WriteLine("7. Perimeter and Area of Circle.");
            Console.WriteLine("9. Execution Time.");
            Console.WriteLine("10. Display number divisible by 7 but not multiple of 5 (2000-3200)");
            Console.WriteLine("11. Factorial.");
            Console.WriteLine("12. Print number 1 to 100 (not use loop)");
            Console.WriteLine("13. Quadratic Equation.");
            Console.WriteLine("14. Convert number to string (PlingPlangPlong)");
            Console.WriteLine("15. Check presence of a, e and p");
            Console.WriteLine("16. Prime number in array.");
            Console.WriteLine("17. Shift all zero to end");
            Console.WriteLine("20. Exit");
            Console.WriteLine();

            int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DisplayFriends displayFriends = new DisplayFriends();
                        displayFriends.FriendsName();
                        break;
                    case 2:
                        NumSumDiff diff = new NumSumDiff();
                        diff.SqNumSumDiff();
                        break;
                    case 3:
                        VisitPlace place = new VisitPlace();
                        place.ShowPlace();
                        break;
                    case 4:
                        ReadNumPrintTenTimes readNumPrintTenTimes = new ReadNumPrintTenTimes();
                        readNumPrintTenTimes.PrintTenTimes();
                        break;
                    case 5:
                        NumOfPartsInName    numOfPartsInName = new NumOfPartsInName();
                        numOfPartsInName.FullName();
                        break;
                    case 6:
                        RandomNumAvg randomNumAvg = new RandomNumAvg();
                        randomNumAvg.AvgNum();
                        break;
                    case 7:
                        PerimeterAreaOfCircle perimeterAreaOfCircle = new PerimeterAreaOfCircle();
                        perimeterAreaOfCircle.PerimeterArea();
                        break;
                    case 9:
                        ExecutionTime executionTime = new ExecutionTime();
                        executionTime.ExecuTime();
                        break;
                    case 10:
                        DiviBy7ButNot5 diviBy7ButNot5= new DiviBy7ButNot5();
                        diviBy7ButNot5.DivisibleBy7Not5();
                        break;
                    case 11:
                        Console.WriteLine(Factorial.FactorialNum());
                        break;
                    case 12:
                        PrintNumNotUseLoop.Print1To100(1);
                        break;
                    case 13:
                        QuadraticEqu.QuadraticEquation();
                        break;
                    case 14:
                        PlingPlangPlong.PlingPlangP();
                        break;
                    case 15:
                        CheckPresence.AEP();
                        break;
                    case 16:
                        PrimeNo.Prime();
                        break;
                    case 17:
                        ShiftAllZeroToEnd.ShiftZeroArray(); 
                        break;
                    case 20:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Your choice is out of range. Try again---");
                        break;
                }
            }
        }
    }
}
