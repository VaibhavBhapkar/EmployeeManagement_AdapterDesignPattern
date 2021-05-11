using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_AdapterDesignPattern
{
    public class EmployeeManager
    {
        List<Employee> employeeList = new List<Employee>();
        
        public EmployeeManager()
        {
            employeeList.Add(new Employee { 
                EmployeeId=1, 
                EmployeeName="Vaibhav Bhapkar",
                EmployeeDepartment="Test" 
            });
            employeeList.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Test Name",
                EmployeeDepartment = "Test"
            });
        }

        public string GetEmployeeData()
        {
            return JsonConvert.SerializeObject(employeeList);
        }
    }
}
