using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase1.Day1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long Mobile { get; set; }
        public string Address { get; set; }

        public Employee(RequestEmployeeData data)
        {
            Name = data.Name;
            Age = data.Age;
            Mobile = data.Mobile;
            Address = data.Address;
        }
        

    }
}
