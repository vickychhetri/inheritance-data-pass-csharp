using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase1.Day1
{
    public class VisitingEmployee : Employee, IEmployee
    {
        private string VNumber;


        public VisitingEmployee(RequestEmployeeData data): base (data)
        {
            this.VNumber = data.VNumber;
        }

          public string GetCardNumber()
            {
                return this.VNumber;
            }

    }
}
