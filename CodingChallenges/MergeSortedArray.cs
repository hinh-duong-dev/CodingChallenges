using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public static class MergeSortedArray
    {
        public static int[] Merge(int[] array1, int[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;
            int n3 = n1 + n2;
            int i = 0, j = 0, k = 0;

            int[] array3 = new int[n3];

            // Traverse both array
            while (i < n1 && j < n2)
            {
                // Check if current element of first array is smaller than current element of second array.
                // If yes, store first array element and increment first array index. Otherwise do same with second array
                if (array1[i] < array2[j])
                {
                    array3[k] = array1[i];
                    i++;
                    k++;
                }
                else {
                    array3[k] = array2[j];
                    j++;
                    k++;
                }
            }

            // Store remaining elements of first array
            while (i < n1)
            {
                array3[k] = array1[i];
                i++;
                k++;
            }

            // Store remaining elements of second array
            while (j < n2)
            {
                array3[k] = array2[j];
                j++;
                k++;
            }

            return array3;
        }
    }
}
