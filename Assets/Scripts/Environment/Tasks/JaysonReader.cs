using System;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Employee Information", menuName = "Employee Information")]
    public class JaysonReader : Task
    {
        [SerializeField]
        private TextAsset jsonFile;

        public static Employee[] printEmployee(TextAsset jsonFile)
        {
            Employee[] employees = JsonUtility.FromJson<Employee.EmployeeArray>(jsonFile.text)?.employees;

            foreach (Employee employee in employees)
            {
                Debug.Log("Name: " + employee.name);
                Debug.Log("Employee ID: " + employee.employeeId);
                Debug.Log("Has engine room clearance: " + employee.hasEngineRoomClearance);
                Debug.Log("Last Entrance in engine room: " + employee.lastEntranceInEngineRoom);
                Debug.Log("Last exit from engine room: " + employee.lastExitFromEngineRoom);
            }
            return employees;
        }
        public override void Execute() 
        {
           Computer.Instance.allEmployee = printEmployee(jsonFile);
        }


    }
}