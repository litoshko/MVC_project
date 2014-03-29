using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.Models
{
    public class City
    {
        public virtual int CityID { get; set; }
        public virtual string CityName { get; set; }
    }
}