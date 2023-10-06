using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek8
{
    class Employee
    {
        public string? name;
        public int age;
        public string? graduation;
        public int experience;
        public double salary;
        public int manage;

        public Employee(string name, int age, string graduation, int experience, double salary)
        {
            this.name = name;
            this.age = age;
            this.graduation = graduation;
            this.experience = experience;
            this.salary = salary;
        }

        public Employee(string name, int age, string graduation, int experience, double salary, int manage) : this(name, age, graduation, experience, salary)
        {
            this.manage = manage;
        }

        public string? Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public int Age   // property
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }

        public string? Graduation   // property
        {
            get { return graduation; }   // get method
            set { graduation = value; }  // set method
        }

        public int Experience   // property
        {
            get { return experience; }   // get method
            set { experience = value; }  // set method
        }
        public double Salary   // property
        {
            get { return salary; }   // get method
            set { salary = value; }  // set method
        }
    }
}
