using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> Employees;
        public EmployeeRepository()
        {
            Employees = new List<Employee>()
            {
                new Employee(){EmployeeId=101,Name="Mounika", Department="IT", Email="Mounika@ibm.com"},
                new Employee(){EmployeeId=102,Name="Ramya", Department="IT", Email="Ramya@ibm.com"},
                new Employee(){EmployeeId=103,Name="Sasidhar", Department="HR", Email="Sasidhara@ibm.com"},
                new Employee(){EmployeeId=104,Name="Borole", Department="Admin", Email="Borole@ibm.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            Employee emp =Employees.FirstOrDefault(e => e.EmployeeId == id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public void  Save(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
