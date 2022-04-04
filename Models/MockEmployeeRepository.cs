using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary",Department="HR" ,Email="mary@"},
                new Employee(){ Id = 2, Name ="John",Department="HR",Email="@John"},
                new Employee(){ Id = 3, Name ="Nick",Department="HR",Email="@Nick"},

            };

          

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
           return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }




    }
}
