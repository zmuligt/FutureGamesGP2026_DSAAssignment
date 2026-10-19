using UnityEngine;
using System;
using System.Data;

namespace Environment {
public class Employees
{
    [Serializable]
    public class Employee {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public DateTime lastEntranceInEngineRoom;
        public DateTime lastExitFromEngineRoom;
    }

    [Serializable]
    public class EmployeeArray{
        public Employee[] employees;
    }
   
  }
}
