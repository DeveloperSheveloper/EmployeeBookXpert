using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeBookXpert.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public DateTime DOJ { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public int StateID { get; set; }
        public string  State { get; set; }
        public string  Type { get; set; }
    }
}