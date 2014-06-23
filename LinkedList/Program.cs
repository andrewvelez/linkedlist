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
            Console.WriteLine("Returns the 5th node from the end of a singly linked list [unexpected input will exit].");
            Console.WriteLine("Enter the first list as a CSV of integers: ");

            string inputCsv = Console.ReadLine();
            Console.Write(Environment.NewLine);

            if (string.IsNullOrWhiteSpace(inputCsv))
            {
                Console.WriteLine("exiting...");
                return;
            }
            else
            {
                List<int> inputIntegerList = Program.GetIntegerList(inputCsv);
                if (inputIntegerList == null)
                {
                    Console.WriteLine("Not an integer CSV, exiting...");
                    return;
                }
                else if (inputIntegerList.Count < 5)
                {
                    Console.WriteLine("Not 5 elements in the list, exiting...");
                    return;
                }
                else
                {
                    FifthElement<int> theFifthElement = new FifthElement<int>(inputIntegerList.GetEnumerator());
                    Console.Write("5th element in the list: ");
                    Console.WriteLine(theFifthElement.GetFifthFromEndOfList().ToString());
                }
            }

            Console.WriteLine("");
        }

        private static List<int> GetIntegerList(string inputCsv)
        {
            List<int> inputIntegerList = new List<int>();

            var list = inputCsv.Trim().Trim(',').Split(',').ToList<string>();

            int inputItem;
            foreach (string item in list)
            {
                if (int.TryParse(item, out inputItem))
                {
                    inputIntegerList.Add(inputItem);
                }
                else
                {
                    inputIntegerList = null;
                    break;
                }
            }

            return inputIntegerList;
        }

    }
}