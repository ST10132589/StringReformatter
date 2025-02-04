//Blake Marais
//=========================[Start of file]=========================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReformatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Please enter a string to reformat: ");
                string input = Console.ReadLine();
                string lowerCaseString = ReformatString(input);
                Console.WriteLine("The reformatted string is: " + lowerCaseString);
                Console.Write("Would you like to do another? [Y] or [N]... ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    loop = false;
                    Console.WriteLine("Goodbye! Press any key to exit");
                    Console.ReadKey();
                }
                if (answer.ToLower() == "y")
                {
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
            
        }

        public static string ReformatString(string input)
        {
            string output = "";
            foreach(char c in input)
            {
                if (char.IsLetter(c))
                {
                    output += char.ToLower(c);
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}
//=========================[End of file]=========================