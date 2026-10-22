using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class SortingUtils
    {
        public static void SelectionSort(int[] arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                int currentSmallestIndex = i;
                for (int j = i; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[j] < arrayToSort[currentSmallestIndex])
                    {
                        currentSmallestIndex = j;
                    }
                }
                int temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[currentSmallestIndex];
                arrayToSort[currentSmallestIndex] = temp;
            }
        }


    }
}