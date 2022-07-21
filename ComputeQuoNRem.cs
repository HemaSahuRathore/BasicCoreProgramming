using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class ComputeQuoNRem
    {
        public void CompQnR()
        {
            int quotient, remainder; //declaring local variables

            Console.Write("Please Enter the value for Dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Calculation
            quotient = dividend / divisor;
            remainder = dividend % divisor;

            //Display results
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);

        }
    }
}

