using Assets.Scripts.Utils;
using System.Collections;
using UnityEngine;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTask", menuName = "SearchTask")]

    public class SearchTask : Task
    {
        //search params
        //benchmark time the search takes

        public override void Execute()
        {
            Employee[] employees = Computer.Instance.allEmployee;
            //BinarySearch.binarySearch(employees, employees.Length -1);

            Computer.Instance.allEmployee = employees;
            //call binary search on sorted employee array

        }
    }
}