using Environment;
using System.Collections;
using UnityEngine;
using System;

namespace Assets.Scripts.Utils
{
    public class BinarySearch
    {
        public static int binarySearch(Employee[] inArray, string elementToSearch)
        {
            int bottomIndexOfSubArray = 0;
            int topIndexOfSubArray = inArray.Length - 1;
            int median = 0;

            while (bottomIndexOfSubArray <= topIndexOfSubArray)
            {
                median = bottomIndexOfSubArray + (topIndexOfSubArray - bottomIndexOfSubArray) / 2;

                DateTime entrance = DateTime.Parse(inArray[median].lastEntranceInEngineRoom);
                DateTime search = DateTime.Parse(elementToSearch);

               if (entrance == search)
                {
                    return median;
                }
                
                if (entrance < search)
                {
                    bottomIndexOfSubArray = median + 1;
                }
                else
                {
                    topIndexOfSubArray = median + 1;
                }
            }
            return median;
        }
    }
}