using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.Models
{
    public class Department
    {
        public virtual int DepartmentID { get; set; }
        public virtual string DepartmentName { get; set; }
    }
}