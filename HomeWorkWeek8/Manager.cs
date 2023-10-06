using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek8
{
    internal class Manager : Employee
    {
        public Employee it;
        public Employee ik;
        public Employee accounting;
        public  Employee salesman;
        
       

        public Manager(string name, int age, string graduation, int experience, double salary, int manage) : base(name, age, graduation, experience, salary)
        {

            

        }
    }
}
