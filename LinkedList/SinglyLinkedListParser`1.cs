using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SinglyLinkedListParser<T>
    {
        
        private T _Leeloo = default(T);
        private IEnumerator<T> _SinglyLinkedListHead;

        public SinglyLinkedListParser(string csv)
        {
            ParseEnumeratorHead(csv);
        }

        public string GetFifthElementResultText()
        {
            T element;
            string resultText;

            try
            {
                element = GetFifthElement();
                resultText = string.Format("The fifth element found was: {0}", element.ToString());
            }
            catch (Exception ex)
            {
                resultText = string.Format("{0}: {1}", ex.GetType().Name, ex.Message);
            }

            return resultText;
        }

        public T GetFifthElement()
        {
            if (_SinglyLinkedListHead != null)
            {
                FindFifthElement();
            }

            return _Leeloo;
        }

        private void ParseEnumeratorHead(string csv)
        {
            if (string.IsNullOrWhiteSpace(csv))
            {
                _SinglyLinkedListHead = (new List<T>()).GetEnumerator();
            }
            else
            {
                ParseEnumeratorNotNull(csv);
            }
        }

        private void ParseEnumeratorNotNull(string csv)
        {
            string trimmedCsv = csv.Trim().Trim(',');
            string[] inputStringArray = trimmedCsv.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            IEnumerable<T> list = inputStringArray.Select(s => (T)Convert.ChangeType(s, typeof(T)));

            _SinglyLinkedListHead = list.GetEnumerator();
        }

        private void FindFifthElement()
        {
            Queue<T> tempQueue = new Queue<T>(5);

            do
            {
                if (tempQueue.Count == 5)
                {
                    tempQueue.Dequeue();
                }

                tempQueue.Enqueue(_SinglyLinkedListHead.Current);

            } while (_SinglyLinkedListHead.MoveNext());

            if (tempQueue.Count == 5)
            {
                _Leeloo = tempQueue.Dequeue();
            }

            _SinglyLinkedListHead = null;
        }

    }
}