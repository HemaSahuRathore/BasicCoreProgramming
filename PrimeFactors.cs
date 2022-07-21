using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PrimeFactorization
    {
        public void FindPrimeFactorization()
        {
            int num;

            Console.Write("Enter number to find the prime factors : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num % 2 == 0) //loop to check how many time 2 divides a num
            {
                Console.Write("2" + " ");
                num = num / 2;
            }

            for (int i = 3; i < num; i++) //we checked 2 so we will the start loop with 3
            {
                while (num % i == 0)
                {
                    if (num % i == 0)
                        Console.WriteLine(i + " ");
                    num /= i;
                }
            }

            if (num > 2) //if num is not divisible other than 2 then print the number
                Console.Write(num);
        }

    }
}
