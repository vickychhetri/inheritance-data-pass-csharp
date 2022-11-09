using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase1.Day1
{
    public class PermanentEmployee : Employee, IEmployee
    {
        private string PNumber;

        public PermanentEmployee(RequestEmployeeData data) : base(data)
        {
            this.PNumber = data.PNumber;
        }


       public string GetCardNumber()
        {
            return this.PNumber;
        }
    }
}
