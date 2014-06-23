using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class IntegerLinkedListProgramStep : IProgramStep
    {

        public string InputTextPrompt
        {
            get
            {
                return "Returns the 5th node from the end of a singly linked list [unexpected input will exit]." +
                    Environment.NewLine + "Enter the first list as a CSV of integers: ";
            }
        }

        public bool IsUserInputInvalid { get; private set; }

        public string ResultText { get; private set; }

        public void ExecuteUserInput(string input)
        {
            ValidateEmpty(input);
            ValidateIntegers(input);
        }

        private void ValidateEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ResultText
                IsUserInputInvalid = true;
            }
        }

        private void ValidateIntegers(string input)
        {

        }

        private List<int> GetIntegerList(string inputCsv)
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