using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.Write("Enter the year(should be 4 digit) : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }
    }
}
