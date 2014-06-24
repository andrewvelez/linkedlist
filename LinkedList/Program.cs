using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter the first list as a CSV of integers: ");
            string input = Console.ReadLine();
            var parserInt = new SinglyLinkedListParser<int>(input);
            Console.WriteLine(parserInt.GetFifthElementResultText());

            Console.Write(Environment.NewLine + "Enter the second list as a CSV of strings: ");
            input = Console.ReadLine();
            var parserString = new SinglyLinkedListParser<string>(input);
            Console.WriteLine(parserString.GetFifthElementResultText());
        }

    }
}