using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FifthElement<T> where T : struct
    {

        private T _Leeloo = default(T);
        private IEnumerator<T> _Enumerator;

        public FifthElement(IEnumerator<T> enumerator)
        {
            if (enumerator == null)
            {
                throw new ArgumentNullException("The fifth element cannot be found with a null");
            }
            else
            {
                _Enumerator = enumerator;
            }
        }

        public T GetFifthFromEndOfList()
        {
            if (_Enumerator != null)
            {
                FindFifthElement();
            }

            return _Leeloo;
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

                tempQueue.Enqueue(_Enumerator.Current);

            } while (_Enumerator.MoveNext());

            if (tempQueue.Count == 5)
            {
                _Leeloo = tempQueue.Dequeue();
            }

            _Enumerator = null;
        }

        //public int GetFifthElement(IEnumerator<int> enumeratorListHead)
        //{
        //    return 0;
        //}

        //public bool IsValidCsv(string inputCsv)
        //{
        //    var list = SplitCsv(inputCsv);
        //    return (list != null && list.Count > 0);
        //}

        //public bool IsValidIntegerCsv(string inputCsv)
        //{
        //    if (!IsValidCsv(inputCsv))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return IsAllIntegers(SplitCsv(inputCsv));
        //    }
        //}

        //private List<string> SplitCsv(string inputCsv)
        //{
        //    if (string.IsNullOrWhiteSpace(inputCsv))
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return inputCsv.Trim().Trim(',').Split(',').ToList<string>();
        //    }
        //}

        //private bool IsAllIntegers(List<string> list)
        //{
        //    int intItem;
        //    foreach (string item in list)
        //    {
        //        if (!int.TryParse(item, out intItem))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

    }
}