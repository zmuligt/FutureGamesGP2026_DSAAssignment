using Assets.Scripts.Utils;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTask", menuName = "SearchTask")]

    public class SearchTask : Task
    {   
        //search params
        //benchmark time the search takes - how?

        [SerializeField]
        string lastEntranceInEngineRoomParameters = "2234-08-08T13:17:24"; //what's the range supposed to be?

        public override void Execute()
        {
            BinSearch();
            //call binary search on sorted employee array
        }

        public void BinSearch()
        {
            Employee[] employees = Computer.Instance.allEmployee;
            BinarySearch.binarySearch(employees, lastEntranceInEngineRoomParameters);
            Computer.Instance.allEmployee = employees;
        }
    }
}