using Database_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project.Interfaces
{
    public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        Employee AddEmployee(Employee employee);
        object GetEmployeeById(int id);
    }
}
