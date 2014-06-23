using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StringLinkedListProgramStep : IProgramStep
    {

        public string InputTextPrompt
        {
            get
            {
                return Environment.NewLine + "Enter the second list as a CSV of strings: ";
            }
        }

        public bool IsUserInputInvalid
        {
            get { throw new NotImplementedException(); }
        }

        public string ResultText
        {
            get { throw new NotImplementedException(); }
        }

        public void ExecuteUserInput(string userInput)
        {
            throw new NotImplementedException();
        }

    }
}