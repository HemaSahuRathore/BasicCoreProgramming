using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LargestNumber
    {
        public void LargestAmongThree()
        {
            int[] arrOfNum = new int[3]; //creating an array to store 3 numbers
            Console.Write("Enter three Numbers using space in between them : "); //taking input from user
            string[] strings = Console.ReadLine().Split(" "); //storing it in string array

            for (int j = 0; j < strings.Length; j++)
            {
                arrOfNum[j] = Convert.ToInt32(strings[j]); //coverting values from string data type to interger to compare
            }

            //Checking the largest among 3 nums
            if (arrOfNum[0] > arrOfNum[1] && arrOfNum[0] > arrOfNum[2])
                Console.WriteLine("{0} is the Largest", arrOfNum[0]);
            else if (arrOfNum[1] > arrOfNum[0] && arrOfNum[1] > arrOfNum[2])
                Console.WriteLine("{0} is the Largest", arrOfNum[1]);
            else
                Console.WriteLine("{0} is the Largest", arrOfNum[2]);

        }

    }

}