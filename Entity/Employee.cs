using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammerTask.Entity
{
    //class entity Employee
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
