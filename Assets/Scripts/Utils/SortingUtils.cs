using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;

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

        public class sortEmployee
        {
            public uint employeeId;
            public EmployeeType type = EmployeeType.Unassigned;

            public bool IsEmployeeOfType(EmployeeType InEmployeeType)
            {
                return InEmployeeType == type;
            }
        }

        public static void SelectionSort(int[] arrayToSort)
        {
            sortEmployee employee = new sortEmployee();
            employee.IsEmployeeOfType(EmployeeType.Scientist);

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

        public static void merge(sortEmployee[] inArray, int left, int middle, int right) 
        {
            int sizeLeft = middle - left + 1;
            int sizeRight = right - (middle + 1) + 1;

            sortEmployee[] tempLeft = new sortEmployee[sizeLeft];
            sortEmployee[]  tempRight = new sortEmployee[sizeRight];
            int i = 0;
            int j = 0;
            for(i = 0; i < sizeLeft; i++)
            {
                tempLeft[i] = inArray[i + left];
            }
            for (j = 0; j < sizeRight; j++)
            {
                tempRight[j] = inArray[j + middle + 1];
            }

            i = 0;
            j = 0;
            int k = left;
            while (i < sizeLeft && j < sizeRight)
            {
                if (tempLeft[i].employeeId <= tempRight[j].employeeId)
                {
                    inArray[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    inArray[k] = tempRight[j];
                    j++;
                }
                k++;
            }

            while(i < sizeLeft)
            {
                inArray[k] = tempLeft[i];
                i++;
                k++;
            }
            while (j < sizeRight)
            {
                inArray[k] = tempRight[j];
                j++;
                k++;
            }

        }

       public static void mergeSort(sortEmployee[] inArray, int left, int right)
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