using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionPostSharp
{
    [NotifyPropertyChanged]
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string firstName, int basicSalary, int hra)
        {
            this.FirstName = firstName;
            this.BasicSalary = basicSalary;
            this.HRA = hra;
        }

        public string FirstName { get; set; }

        public int BasicSalary { get; set; }

        public int HRA { get; set; }

        public int TotalSalary { get { return BasicSalary + HRA; } }

    }
}
