using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Utils;
using Unity.VisualScripting;
using UnityEngine;
using Environment.Tasks;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SortingTask", menuName = "SortingTask")]
    public class SortingTask : Task
    {      
        [SerializeField]JaysonReader JsonData;

        Employees.Employee[] employees;
        
        public override void Execute()
        {
            MergeSort();
        }

        public void MergeSort()
        {
            employees = JsonData.employees;
            
            //SORTING FROM SORTINGUTILS WEEK 3
            //int[] arrayToSort = new[] { 5, 2, 3, 1, 4 };
            //SortingUtils.SelectionSort(arrayToSort);
            //Debug.Log(arrayToSort);

            int left = 0;
            //int[] arrayToSort = {12, 6, 3, 1, 4};
            int right = employees.Length; 
            int middle = right / 2;
            
            SortingUtils.mergeSort(employees, left, right -1);
            //Debug.Log(arrayToSort);

            for(int i = 0; i < employees.Length; i++)
            Debug.Log(employees[i] + " ");

        }
    }
}