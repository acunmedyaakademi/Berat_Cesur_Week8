using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek8
{
    internal class Manager : Employee
    {
        public Employee[] employees;
        
        public Manager(string name, int age, string graduation, int experience, double salary, Employee[] employees) : base(name, age, graduation, experience, salary)
        {
            this.employees = employees;
        }
    }
}
