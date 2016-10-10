using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace _12_Employee
{
    internal class EmployeeRepository 
    {
        Dictionary<long, Employee> adictionary = new Dictionary<long, Employee>();
        TextWriter mywriter;
        TextReader myreader;
        
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

        int id = 0;
        public Employee CreateEmployee(string name, string job)
        {
            anemployee = new Employee(name, job);
            id++;
            adictionary.Add(id, anemployee);
            anemployee.Name = name;
            anemployee.Type = job;
            anemployee.Id = id;
            return anemployee;
        }

        public void SaveEmployee(Employee simon)
        {
            mywriter = File.CreateText("Employee List\\"+"Employee"+simon.Id+".txt");
            mywriter.WriteLine(simon.Name);
            mywriter.WriteLine(simon.Type);
            mywriter.Close();
        }
        Employee newobject;
        Dictionary<long, Employee> anewdictionary = new Dictionary<long, Employee>();
        public Employee LoadEmployee(int id)
        {
            myreader = new StreamReader("Employee List\\" + "Employee" + id + ".txt");
            string name = myreader.ReadLine();
            string type = myreader.ReadLine();
            myreader.Close();
            newobject = new Employee(name, type);
            anewdictionary.Add(id, newobject);
            return newobject;
        }
        List<Employee> e = new List<Employee>();
        public List<Employee> FindAllEmployees()
        {
            foreach(var item in adictionary)
            {
                e.Add(item.Value);
            }
            return e;
        }

        
    }
}