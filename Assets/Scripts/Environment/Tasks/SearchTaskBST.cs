using Assets.Scripts.Utils;
using System;
using System.Linq;
using UnityEngine;
using Utils;
using System.Diagnostics;
using NUnit.Framework;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTaskBST", menuName = "SearchTaskBST")]
    public class SearchTaskBST : Task
    {
        [SerializeField] List<Employee> Results = new List<Employee>();
        public override void Execute()
        {
            Employee[] employee = Computer.Instance.allEmployee;
            

            BinarySearchTree bst = new BinarySearchTree(employee[0]);
            for (int i = 1; i < employee.Length; i++)
            {
                bst.Insert(employee[i]);

            }
            DateTime starttime = new DateTime(2234, 08, 09, 22, 00, 00);
            DateTime endtime = new DateTime(2234, 08, 09, 23, 00, 00);
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            Results = bst.BreadthFirstSearch(starttime, endtime);

            stopwatch.Stop();

            Debug.Log($"Search took: {stopwatch.Elapsed.TotalSeconds} seconds. Or =~ {stopwatch.Elapsed.TotalMilliseconds} milliseconds.");
            foreach (Employee emp in Results) 
            {
                Debug.Log($"Name: {emp.name} : Last entrance:  {emp.lastEntranceInEngineRoom} : Last exit: {emp.lastExitFromEngineRoom}");
            }

        }
    }
}