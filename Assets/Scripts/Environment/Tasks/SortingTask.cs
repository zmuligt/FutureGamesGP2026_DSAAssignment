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
        public override void Execute()
        {
            MergeSort();
        }

        public void MergeSort()
        {
            Employee[] employees = Computer.Instance.allEmployee;
            SortingUtils.mergeSort(employees, 0, employees.Length - 1);

            Computer.Instance.allEmployee = employees;

            foreach(Employee employee in Computer.Instance.allEmployee)
            {
                //Debug.Log("Sorted.");
            }
        }
    }
}