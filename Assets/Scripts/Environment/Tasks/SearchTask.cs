using Assets.Scripts.Utils;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using Utils;
using System.Diagnostics;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTask", menuName = "SearchTask")]

    
    public class SearchTask : Task
    {
        //search params
        //benchmark time the search takes - how?
        
       
        string time = "2234-08-08T13:17:24"; //what's the range supposed to be?
        

        public override void Execute()
        {
            
            BinSearch();            //call binary search on sorted employee array
            
        }

        public void BinSearch()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Employee[] employees = Computer.Instance.allEmployee;
            DateTime lastEntranceInEngineRoomParameters = DateTime.Parse(time);

            BinarySearch.binarySearch(employees, lastEntranceInEngineRoomParameters);
            Computer.Instance.allEmployee = employees;
            stopwatch.Stop();
            UnityEngine.Debug.Log($"Search took: {stopwatch.Elapsed.TotalSeconds} seconds. Or =~ {stopwatch.Elapsed.TotalMilliseconds} milliseconds.");
        }

        

    }
}