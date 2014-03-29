using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.Models
{
    public class Employee
    {
        public virtual int EmployeeID { get; set; }
        public virtual string EmpName { get; set; }
        public virtual string EmpLastName { get; set; }
        public virtual string EmpAddress { get; set; }
        public virtual int StateID { get; set; }
        public virtual int CityID { get; set; }
        public virtual int DepartmentID { get; set; }
        public virtual City cityobj { get; set; }
        public virtual State stateobj { get; set; }
        public virtual Department departmentobj { get; set; }
    }
}