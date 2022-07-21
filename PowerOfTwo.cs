using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOf2
    {
        public void TableOfTwo()
        {   //Local Variables
            int N;
            int i = 1; //initialized to run the loop from 1 to N
            int table = 1;

            Console.Write("Enter the Value of N : "); //taking input from user
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTable of Power of 2");

            while (i <= N)
            {
                table *= 2; //table = 2 * table
                Console.WriteLine("2 to the Power {0} is {1}", i, table); //displays table of power of 2
                i++;
            }

        }

    }
}
