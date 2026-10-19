using System;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Employee Information", menuName = "Employee Information")]
    public class JaysonReader : Task
    {
         [SerializeField]
        private TextAsset jsonFile = null;

        public override void Execute() 
        {
            if(jsonFile == null) {
                return;
            }

           Employees.Employee[] employees = JsonUtility.FromJson<Employees.EmployeeArray>(jsonFile.text)?.employees;

           if(employees != null && employees.Length <= 0) {
                return;
            }

           foreach(Employees.Employee employee in employees) {
                Debug.Log("Name: " + employee.name);
                Debug.Log("Employee ID: " + employee.employeeId);
                Debug.Log("Has engine room clearance: " + employee.hasEngineRoomClearance);
                Debug.Log("Last Entrance in engine room: " + employee.lastEntranceInEngineRoom);
                Debug.Log("Last exit from engine room: " + employee.lastExitFromEngineRoom);
            }
        }
    }
}