using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssurance
{
    public class StringSorter
    {

        public static string[] Sort(string[] unsorted)
        {
            Sort(unsorted, 0, unsorted.Length - 1);
            return unsorted;
        } 

        private static void Sort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (String.Compare(elements[i], pivot, StringComparison.Ordinal) < 0)
                {
                    i++;
                }

                while (String.Compare(elements[j], pivot, StringComparison.Ordinal) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Sort(elements, left, j);
            }

            if (i < right)
            {
                Sort(elements, i, right);
            }
        }

    }
}
