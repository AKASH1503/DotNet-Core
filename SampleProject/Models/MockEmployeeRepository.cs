using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee(){ Id=1,Name="Akash",Email="abc@gamil.com",Department=Dept.HR},
                new Employee(){ Id=2,Name="Akash2",Email="abc2@gamil.com",Department=Dept.IT},
                new Employee(){ Id=3,Name="Akash3",Email="abc3@gamil.com",Department=Dept.Payroll}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id==Id);
        }
    }
}
