using System;
using System.Collections.Generic;

namespace _07._CompanyUsers
{
    class Employees
    {
        public Employees(string companyName)
        {
            CompanyName = companyName;
            EmployeeId = new List<string>();
        }
        public string CompanyName { get; set; }

        public List<string> EmployeeId { get; set; }

        public override string ToString()
        {
            string allIds = " ";
            for (int i = 0; i < EmployeeId.Count; i++)
            {
                allIds += $"-- {EmployeeId[i]}\n";
            }
            return $"{CompanyName}\n" +
                   $"{allIds}".Trim();
        }

        public void AddEmployee(string employeeId)
        {
            if(!EmployeeId.Contains(employeeId))
            {
                EmployeeId.Add(employeeId);
            
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employees> employee = new Dictionary<string, Employees>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" -> ");
                string companyName = input[0];
                string employeeId = input[1];
                Employees employees = new Employees(companyName);
                if(!employee.ContainsKey(companyName))
                {
                    employee.Add(companyName, employees);
                }
                
                employee[companyName].AddEmployee(employeeId);
            }

            foreach (KeyValuePair<string,Employees> kvp in employee)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
