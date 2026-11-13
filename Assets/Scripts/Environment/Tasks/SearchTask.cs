using Assets.Scripts.Utils;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using Utils;
using System.Diagnostics;
using System.Collections.Generic;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTask", menuName = "SearchTask")] 
    public class SearchTask : Task
    {
        //search params
        //benchmark time the search takes - how?
        
        [SerializeField] List<Employee> Results = new List<Employee>();
        public override void Execute()
        {
            BinSearch();
        }

        public void BinSearch()
        {
            Employee[] employees = Computer.Instance.allEmployee;
            
            Stopwatch stopwatch = Stopwatch.StartNew(); 

            int lowerResult = BinarySearch.binarySearch(employees, new DateTime(2234,08,09,22,00,00));
            int upperResult = BinarySearch.binarySearch(employees, new DateTime (2234,08,09,23,00,00));

            for (int i = lowerResult; i <= upperResult; i++)
            {
                Results.Add(employees[i]);
            }

            stopwatch.Stop();
            Computer.Instance.allEmployee = employees;
            
            UnityEngine.Debug.Log($"Search took: {stopwatch.Elapsed.TotalSeconds} seconds. Or =~ {stopwatch.Elapsed.TotalMilliseconds} milliseconds.");
        }
    }
}