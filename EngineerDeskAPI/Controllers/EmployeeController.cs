using Database_Project.Interfaces;
using Database_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EngineerDeskAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _EmployeeRepo;

        public EmployeeController (IEmployeeRepo employeeRepo)
        {
            _EmployeeRepo = employeeRepo;
        }

        [HttpGet]

        public ActionResult GetEmployees()
        {
            try
            {
                var employees = _EmployeeRepo.GetEmployees();
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpGet]

        public ActionResult GetEmployeeById(int Id)
        {
            try
            {
                var employee = _EmployeeRepo.GetEmployeeById(Id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            try
            {
                var addedEmployee = _EmployeeRepo.AddEmployee(employee);
                return Ok(addedEmployee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }

        }

    }
}
