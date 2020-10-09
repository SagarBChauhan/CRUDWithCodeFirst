using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWithCodeFirst.Models
{
    [Table("tblEmp")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string PersonalWebsite { get; set; }
        public DateTime HireDate { get; set; }
    }
}