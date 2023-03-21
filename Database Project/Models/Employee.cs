using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string ?EmpName { get; set; }
        public string ?City { get; set; }
        public DateTime DOJ { get; set; }
        public decimal Salary { get; set; }

    }
}
