using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class EvenOrOdd
    {
        public void CheckEven0rOdd()
        {
            Console.Write("Please enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("It is an even number");
            else
                Console.WriteLine("It is an odd number");

        }
    }
}

