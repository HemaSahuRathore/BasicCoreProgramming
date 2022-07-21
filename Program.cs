namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programming");
            Console.WriteLine("Enter select an option to procced :");
            Console.WriteLine("\n1. Flip Coin \n2. Check Leap year \n3. Nth Harmonic value \n4. Table of Power of 2 "); 
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoinProgram();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.CheckLeapYear();
                    break;
                case 3:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.NthHarmonicValue();
                    break;
                case 4:
                    PowerOf2 powerOf2 = new PowerOf2();
                    powerOf2.TableOfTwo();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
    }
}