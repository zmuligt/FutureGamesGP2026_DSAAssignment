using Environment.Tasks;
using System;
using UnityEngine;
using Utils;

namespace Environment {

    public class Computer : MonoBehaviour, IInteractable {
        [SerializeField]
        private GenericQueue<Task> taskQueue = new GenericQueue<Task>();
        private void Start() {
            
        }

        public void OnInteract() {
            //testTask.Execute();

            if(taskQueue.Count > 0) {
                Task activeTask = taskQueue.Dequeue();
                activeTask.Execute();
            }

        }
    }
}
