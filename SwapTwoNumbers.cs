using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class SwapTwoNumbers
    {
        public void Swap2Nums()
        {
            int temp;
            Console.Write("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //logic to swap numbers
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping Number 1: {0}", num1);
            Console.WriteLine("After Swapping Number 2: {0}", num2);
        }
    }
}