using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        //return us the list of all employee
        IEnumerable<Employee> GetAllEmployee();

    }
}
