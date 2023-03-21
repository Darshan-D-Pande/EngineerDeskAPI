using Database_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Project.DatabaseContext;
using Database_Project.Models;

namespace Database_Project.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly SqlServerContext _SqlServerContext;

        public EmployeeRepo(SqlServerContext sqlServerContext)
        {
            _SqlServerContext = sqlServerContext;
        }

        public List<Employee> GetEmployees()
        {
            var listEmp = _SqlServerContext.Employee.ToList();
            return listEmp;
        }

        public Employee GetEmployee(int id)
        {
            var employee = _SqlServerContext.Employee.FirstOrDefault(x => x.EmpId == id);
            return employee;
        }

        public Employee AddEmployee(Employee employee)
        {
            _SqlServerContext.Employee.Add(employee);
            _SqlServerContext.SaveChanges();
            return employee;
        }

        public object GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
