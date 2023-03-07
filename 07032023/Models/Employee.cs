using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07032023.Models
{
    public class Employee
    {
        public string name;
        public int salary;
       

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        
        public void ShowInfo()
        {
            Console.WriteLine($"{name} {salary}");
        }
    }
    
}
