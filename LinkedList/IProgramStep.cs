using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface IProgramStep
    {

        public string InputTextPrompt { get; }

        public bool IsUserInputInvalid { get; private set; }

        public string ResultText { get; private set; }

        public void ExecuteUserInput(string userInput);

    }
}