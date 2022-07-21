﻿namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programming");
            Console.WriteLine("Enter select an option to procced :");
            Console.WriteLine("\n1. Flip Coin \n2. Check Leap year \n3. Nth Harmonic value \n4. Table of Power of 2 \n5. Find Prime Factors \n6. Compute Quotient and Remainder \n7. Swap two numbers \n8. Check Even or Odd number\n9. Check alphabet is Vowel or Consonant \n10. Largest Number among 3 number"); 
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
                case 5:
                    PrimeFactorization primeFactorization = new PrimeFactorization();
                    primeFactorization.FindPrimeFactorization();
                    break;
                case 6:
                    ComputeQuoNRem computeQuoNRem = new ComputeQuoNRem();
                    computeQuoNRem.CompQnR();
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.Swap2Nums();
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckEven0rOdd();
                    break;
                case 9:
                    VowelOrConsonants vowelOrConsonants = new VowelOrConsonants();
                    vowelOrConsonants.CheckVorC();
                    break;
                case 10:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.LargestAmongThree();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
    }
}