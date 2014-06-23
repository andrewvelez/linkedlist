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
            Console.WriteLine("Return the 5th node from the end of a singly linked list [all unexpected input will exit].");
            Console.WriteLine("Choose [1] integers or [2] strings: ");

            string menuInput = Console.ReadLine();

            IFifthElement fifthElement = null;
            if (menuInput != null)
            {
                if (menuInput == "1")
                {
                    fifthElement = new FifthElement<int>();
                }
                else if (menuInput == "2")
                {
                    fifth
                }
            }
        }

        private bool TryParseMenuItem(string menuItemInput, out int selectedItem)
        {
            int menuItem;
            if (menuItem != null && int.TryParse(menuItemInput, out menuItem) && (menuItem == 1 || menuItem == 2))
            {
                selectedItem = menuItem;
                return true;
            }

            selectedItem = 0;
            return false;
        }

        private bool TryParseStringCSV(string csvInput, out List<string> parsedList)
        {
            if (!string.IsNullOrWhiteSpace(csvInput))
            {
                string trimmedInput = csvInput.Trim().Trim(',');
                parsedList = trimmedInput.Split(',').ToList<string>();
                return true;
            }

            parsedList = null;
            return false;
        }

        private bool TryParseIntegerCSV(string csvInput, out List<int> parsedList)
        {
            List<int> integerInputList = new List<int>();
            List<string> stringInputList = null;

            if (TryParseStringCSV(csvInput, out stringInputList))
            {
                int parsedInt;
                foreach (string item in stringInputList)
                {
                    if (int.TryParse(item, out parsedInt))
                    {
                        integerInputList.Add(parsedInt);
                    }
                    else
                    {
                        parsedList = null;
                        return false;
                    }
                }

                parsedList = integerInputList;
                return true;
            }

            parsedList = null;
            return false;
        }

    }
}