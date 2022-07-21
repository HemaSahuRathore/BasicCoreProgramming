using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicNumber
    {
        double value = 0.0; //declare and initialization

        public void NthHarmonicValue()
        {
            Console.Write("Enter the Value for N for Nth Harmonic Series ( 'N' should not be equal to Zero): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n == 0)
                Console.WriteLine("Please enter a valid number");
            else 
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("1/" + i + "+", i); //to print Harmonic Series
                    value += 1 / (float)i; //sum - (float) to explicit type cast
                }

                Console.WriteLine("\nNth Harmonic value is : " + value); //displaying value
            }
            

            

        }

    }
}
