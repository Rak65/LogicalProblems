using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class VisitPlace
    {
        public void ShowPlace()
        {
            Console.WriteLine("Enter the place name you would like to visit: ");
            string placeName=Console.ReadLine();

            string placeNameUpperCase=placeName.ToUpper();
            string placeNameLowerCase=placeName.ToLower();

            Console.WriteLine(placeNameUpperCase+" "+placeNameLowerCase);
        }
    }
}
