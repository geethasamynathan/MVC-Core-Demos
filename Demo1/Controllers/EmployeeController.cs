using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Model;

namespace Demo1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _repository.GetEmployees();
            return View(employees);
        }
        public IActionResult GetEmployee(int id)
        {
          Employee employee = _repository.GetEmployee(id);
            return View(employee);
        }

    }
}
