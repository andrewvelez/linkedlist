using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class IntegerLinkedListProgramStep : IProgramStep
    {

        public IntegerLinkedListProgramStep()
        {
            IsUserInputValid = true;
        }

        public string InputTextPrompt
        {
            get
            {
                return Environment.NewLine + "Returns the 5th node from the end of a singly linked list [unexpected input will exit]." +
                    Environment.NewLine + "Enter the first list as a CSV of integers: ";
            }
        }

        public bool IsUserInputValid { get; private set; }

        public string ResultText { get; private set; }

        public void ExecuteUserInput(string input)
        {
            ValidateEmpty(input);
            List<int> inputIntegerList = GetIntegerList(input);
            ValidateIntegerList(inputIntegerList);
            ValidateHasFiveElements(inputIntegerList);

            int fifthElement = GetFifthElement(inputIntegerList);
            ResultText = "The Fifth Element from the end is: " + fifthElement.ToString() + Environment.NewLine;
        }

        private void ValidateEmpty(string input)
        {
            if (IsUserInputValid && string.IsNullOrWhiteSpace(input))
            {
                ResultText = "input was empty, exiting...";
                IsUserInputValid = false;
            }
        }

        private void ValidateIntegerList(List<int> inputIntegerList)
        {
            if (IsUserInputValid && inputIntegerList == null)
            {
                ResultText = "input was not a CSV of integers, exiting...";
                IsUserInputValid = false;
            }
        }

        private void ValidateHasFiveElements(List<int> inputIntegerList)
        {
            if (IsUserInputValid && inputIntegerList.Count < 5)
            {
                ResultText = "input CSV does not have at least 5 elements, exiting...";
                IsUserInputValid = false;
            }
        }

        private int GetFifthElement(List<int> inputIntegerList)
        {
            FifthElement<int> fifth = new FifthElement<int>(inputIntegerList.GetEnumerator());
            return fifth.GetFifthFromEndOfList();
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