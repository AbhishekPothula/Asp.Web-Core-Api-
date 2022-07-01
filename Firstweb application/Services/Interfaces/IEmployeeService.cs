using System.Collections.Generic;
using Firstweb_application.Models;

namespace Firstweb_application.Services.Interfaces
{
    public interface IEmployeeService
    {
        //Create
        void CreateEmployee(Employee employee);

        //Read
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        //Update
        void UpdateEmployee(Employee employee);

        // Delete
        bool DeleteEmployee(int id);

    }
}
