using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Model
{
 public  interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void Save(Employee employee);

    }
}
