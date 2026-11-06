using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;
using Environment;
using System;

namespace Assets.Scripts.Utils
{
    public class SortingUtils
    {
        public enum EmployeeType
        {
            Unassigned = 0,
            Mechanic = 1,
            Janitor = 2,
            Security = 3,
            Scientist = 4
        }

        public static void merge(Employee[] inArray, int left, int middle, int right) 
        {
            int sizeLeft = middle - left + 1;
            int sizeRight = right - middle;

            Employee[] tempLeft = new Employee[sizeLeft];
            Employee[] tempRight = new Employee[sizeRight];

            for(int i = 0; i < sizeLeft; i++)
            {
                tempLeft[i] = inArray[i + left];
            }
            for (int j = 0; j < sizeRight; j++)
            {
                tempRight[j] = inArray[j + middle + 1];
            }

            int iindex = 0;
            int jindex = 0;
            int kindex = left;
            while (iindex < sizeLeft && jindex < sizeRight)
            {
                DateTime leftTime = DateTime.Parse(tempLeft[iindex].lastEntranceInEngineRoom);
                DateTime rightTime = DateTime.Parse(tempRight[jindex].lastEntranceInEngineRoom);

                if (leftTime <= rightTime)
                {
                    inArray[kindex] = tempLeft[iindex];
                    iindex++;
                }
                else
                {
                    inArray[kindex] = tempRight[jindex];
                    jindex++;
                }
                kindex++;
            }

            while(iindex < sizeLeft)
            {
                inArray[kindex] = tempLeft[iindex];
                iindex++;
                kindex++;
            }
            while (jindex < sizeRight)
            {
                inArray[kindex] = tempRight[jindex];
                jindex++;
                kindex++;
            }

        }

       public static void mergeSort(Employee[] inArray, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                mergeSort(inArray, left, right:middle);
                mergeSort(inArray, left:middle + 1, right);
                merge(inArray, left, middle, right);
            }


        }

        //public static void quickSort(sortEmployee[] inArray, int left, int right)
       // {
         //   if(left < right)
         //   {
                
         //   }
          //  pivotIndex = Partitioner(inArray, left, right);
       // }


    }
}