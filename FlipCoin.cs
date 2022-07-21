using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class FlipCoin
    {
        public void FlipCoinProgram()
        {   //Local Variables
            int head = 1;
            int tail = 1;
            float totalTail = 0;
            float totalHead = 0;

            //taking input from user
            Console.Write("Please enter number of times to flip the coin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();  //creating object of random class

            //loop to iterate the code as per user input
            for (int i = 0; i < number; i++)
            {
                double coin = random.NextDouble(); //Generate random double type values 
                if (coin < 0.5)
                    totalTail += tail;
                else
                    totalHead += head;
            }
            float percentage = (totalHead / number) * 100; //Calculation of percentage
            Console.WriteLine("Percentage of Head vs Tails : {0}%", percentage);
        }
    }
}
