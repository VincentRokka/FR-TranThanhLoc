using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _salaryOneHour;
        public double SalaryOneHour
        {
            get { return _salaryOneHour; }
            set { _salaryOneHour = value; }
        }
        private int _workingHour;
        public int WorkingHour
        {
            get { return _workingHour; }
            set { _workingHour = value; }
        }

        public Employee() { }

        public Employee(string id, string name, double salary, int workingHour)
        {
            this.ID = id;
            this.Name = name;
            this.SalaryOneHour = salary;
            this.WorkingHour = workingHour;
        }

        public double SumSalary()
        {
            return this.SalaryOneHour * this.WorkingHour;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-15} {1,-20} {2, -10} {3, -15} {4 , -20}", this.ID, this.Name, this.SalaryOneHour, this.WorkingHour, this.SumSalary());
        }
    }
}
