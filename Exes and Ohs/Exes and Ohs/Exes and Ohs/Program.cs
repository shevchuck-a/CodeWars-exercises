using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exes_and_Ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            ParsingAndCount();
            Console.ReadLine();
        }
        static void ParsingAndCount()
        {
            Console.WriteLine("Please, write some count of 'x's and 'o's.");
            string userInput = Console.ReadLine();
            string.TryParse(string, out string userInput);
            Console.WriteLine(userInput);
        }
    }
}
