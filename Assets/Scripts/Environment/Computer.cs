using Assets.Scripts.Utils;
using Environment.Tasks;
using System;
using UnityEngine;
using Utils;

namespace Environment {

    public class Computer : MonoBehaviour, IInteractable {
        public static Computer Instance;
        [SerializeField]
        private GenericQueue<Task> taskQueue = new GenericQueue<Task>();
        public Employee[] allEmployee;

        private void Awake()
        {
            Instance = this;
        }

        public void OnInteract() {

            if(taskQueue.Count > 0) {
                Task activeTask = taskQueue.Dequeue();
                activeTask.Execute();
            }
        }
    }
}
