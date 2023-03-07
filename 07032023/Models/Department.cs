using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07032023.Models
{
    public class Department
    {
        public string depname;
        public short employeeLimit;
        public string[] employees;

        public Department(string depname, short employeelimit)
        {
            this.depname = depname;
            this.employeeLimit = employeelimit;
        }

        public void AddEmployee(string newemployee)
        {
            if (employeeLimit > employees.Length)
            { 
                string[] newemployees = new string[employees.Length + 1];
                for (int i = 0; i < employees.Length; i++)
                {
                    newemployees[i] = employees[i];
                }
                employees = newemployees;
                newemployee = newemployees[newemployees.Length - 1];

            }
            Console.WriteLine("Limiti kecir");
        }

        public string GetAllEmmployees(string[] Array)
        {
            this.employees = Array;
            string Allemployees = string.Empty;
            foreach (var item in Array)
            {
                Allemployees += item + "";
            }
            return Allemployees;
        }

        public string SearchByName(string employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == employee)
                {
                    return employees[i];
                }
                else
                {
                    return null;
                }

            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{depname} - {employees.Length} - {employeeLimit}");
        }

    }

    
}
