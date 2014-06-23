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

            Console.Write(Environment.NewLine);
            Console.WriteLine("Enter the second list as a CSV of strings: ");

            foreach (IProgramStep step in Program.GetOrderedProgramSteps())
            {
                Console.Write(step.InputTextPrompt);
                step.ExecuteUserInput(Console.ReadLine());
                step.GetResultText();
                if (step.IsUserInputInvalid)
                {
                    return;
                }
            }
        }

        private static List<IProgramStep> GetOrderedProgramSteps()
        {
            List<IProgramStep> steps = new List<IProgramStep>();
            steps.Add(new IntegerLinkedListProgramStep());
            steps.Add(new StringLinkedListProgramStep());
            return steps;
        }

    }
}