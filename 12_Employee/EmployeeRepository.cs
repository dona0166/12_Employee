using System;
using System.Collections.Generic;


namespace _12_Employee
{
    internal class EmployeeRepository 
    {
        Dictionary<string, Employee> adictionary = new Dictionary<string, Employee>();
        
        public EmployeeRepository()
        {
            
        }
        

        public void Clear()
        {
            adictionary.Clear();
            
        }

        public int CountEmployees()
        {
            return adictionary.Count;
        }
        Employee anemployee;
        public Employee CreateEmployee(string name, string job)
        {
            anemployee = new Employee(name, job);
            adictionary.Add(name, anemployee);
            return anemployee;
        }
    }
}