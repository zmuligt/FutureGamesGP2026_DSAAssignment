using Assets.Scripts.Utils;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using Utils;
using System.Diagnostics;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTaskBST", menuName = "SearchTaskBST")]


    public class SearchTaskBST : Task
    {
        public override void Execute()
        {
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            stopwatch.Stop();
            UnityEngine.Debug.Log($"Search took: {stopwatch.Elapsed.TotalSeconds} seconds. Or =~ {stopwatch.Elapsed.TotalMilliseconds} milliseconds.");

        }
    }
}