using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface IProgramStep
    {

        string InputTextPrompt { get; }

        bool IsUserInputValid { get; }

        string ResultText { get; }

        void ExecuteUserInput(string userInput);

    }
}