using EmployeeAPi.Data;
using EmployeeAPi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeAPi.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDbContext dbContext;
        //Create an employee list manually
        private readonly List<Employee> Employees = new()
        {
          new Employee {Id = Guid.NewGuid(),Name ="jOHN",DateOfEmployment=new DateTime(),City="Nanyuki",Occupation="Designer"},
          new Employee {Id = Guid.NewGuid(),Name ="Carol",DateOfEmployment=new DateTime(),City="Nanyuki",Occupation="SoftwareDev"},
        };

        //Ienumerable helps to get a collection of items
        public IEnumerable<Employee> GetEmployees()
        {
            _ = dbContext.Employees.ToList<Employee>();
            //return Employees;
        }

        //public Employee GetEmployees(Guid id,string Name)
        //{
        //    return Employees.Where(Employee => Employee.Id == id && Employee.Name ==Name).SingleOrDefault();
        //}
        public Employee GetEmployees(Guid id)
        {
            return Employees.Where(Employee => Employee.Id == id).SingleOrDefault();
        }

        public void CreateItem(Employee employee)
        {  
            dbContext.Employees.Add(employee);
            //Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var index = Employees.FindIndex(existingEmployee =>existingEmployee.Id == employee.Id);
            Employees[index] = employee;
        }

        public void DeleteItem(Guid id)
        {
            var index = Employees.FindIndex(existingEmployee => existingEmployee.Id ==id);
            Employees.RemoveAt(index);
        }

      
    }
}
