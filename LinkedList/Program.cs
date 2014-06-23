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
            foreach (IProgramStep step in Program.GetOrderedProgramSteps())
            {
                Console.Write(step.InputTextPrompt);
                step.ExecuteUserInput(Console.ReadLine());
                Console.WriteLine(step.ResultText);
                if (!step.IsUserInputValid)
                {
                    return;
                }
            }
        }

        //public static IEnumerator<object> ParseSinglyLink

        private static List<IProgramStep> GetOrderedProgramSteps()
        {
            List<IProgramStep> steps = new List<IProgramStep>();
            steps.Add(new IntegerLinkedListProgramStep());
            steps.Add(new StringLinkedListProgramStep());
            return steps;
        }

    }
}