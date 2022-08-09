using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0;
            int consonants = 0;
            int space = 0;
            int digit = 0;

            Console.WriteLine("Enter a Sentence or a Character");
            string v = Console.ReadLine();

            for (int i = 0; i < v.Length;i++)
            {
                if(v[i] == 'a' || v[i] == 'e' || v[i]== 'i' || v[i] == 'o' || v[i] == 'u')
                {
                    vowels++;
                }
                else if (char.IsWhiteSpace(v[i]))
                {
                    space++;
                }
                else if (v[i] == '0' || v[i] == '1' || v[i] == '2' || v[i] == '3' || v [i] == '4' || v[i] == '5' || v[i] == '6' || v[i]== '7' || v[i] == '8' || v[i] == '9')
                {
                    digit++;
                }
                else
                {
                    consonants++;
                }



            }
            Console.WriteLine("Your total number of vowels is : {0}",vowels);
             Console.WriteLine("Your total number of consonants is : {0}",consonants);
             Console.WriteLine("Your total number of space is : {0}",space);
             Console.WriteLine("Your total number of digits is : {0}", digit);
            Console.ReadLine();
        }
    }
}
