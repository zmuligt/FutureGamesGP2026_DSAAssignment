using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class BinarySearch
    {

        public int binarySearch(int[] inArray, int elementToSearch)
        {
            int bottomIndexOfSubArray = 0;
            int topIndexOfSubArray = inArray.Length - 1;

            while (bottomIndexOfSubArray <= topIndexOfSubArray)
            {
                int median = bottomIndexOfSubArray + (topIndexOfSubArray - bottomIndexOfSubArray) / 2;
                if (inArray[median] == elementToSearch)
                {
                    return median;
                }


                if (inArray[median] < elementToSearch)
                {
                    bottomIndexOfSubArray = median + 1;
                }
                else
                {
                    topIndexOfSubArray = median + 1;
                }
            }
            return -1;

        }
    }
}