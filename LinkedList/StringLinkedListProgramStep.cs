using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StringLinkedListProgramStep : IProgramStep
    {

        public StringLinkedListProgramStep()
        {
            IsUserInputValid = true;
        }

        public string InputTextPrompt
        {
            get
            {
                return Environment.NewLine + "Enter the second list as a CSV of strings: ";
            }
        }

        public bool IsUserInputValid { get; private set; }

        public string ResultText { get; private set; }

        public void ExecuteUserInput(string userInput)
        {
            throw new NotImplementedException();
        }

    }
}