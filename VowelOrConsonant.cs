using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class VowelOrConsonants
    {
        char alphabet;

        public void CheckVorC()
        {
            Console.Write("Enter the alphabet between A-Z to check 'Vowel' or 'Consonants' : ");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;
                default:
                    Console.WriteLine("It is a consonant");
                    break;
            }


        }

    }
}