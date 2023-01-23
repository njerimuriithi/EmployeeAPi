using EmployeeAPi.Data;
using EmployeeAPi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Linq;

namespace EmployeeAPi.Repositories
{
    public class EmployeeRepo 
    {
        //private readonly EmployeeDbContext _dbContext;
        //public EmployeeRepo(EmployeeDbContext dbContext)
        //{
        //    _dbContext  = dbContext;
        //}
        //Create an employee list manually
        private readonly List<Employee> Employees = new()
        {
          new Employee {Id = Guid.NewGuid(),Name ="jOHN",DateOfEmployment=new DateTime(),City="Nanyuki",Occupation="Designer"},
          new Employee {Id = Guid.NewGuid(),Name ="Carol",DateOfEmployment=new DateTime(),City="Nanyuki",Occupation="SoftwareDev"},
        };

        public void CreateItem(Employee employee)
        {
            //Employee.Id = Guid.NewGuid();
            //Employees.Add(employee);
            //return employee;
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();                       
        }

        public Employee GetEmployee(Guid id)
        {
            return Employees.SingleOrDefault(emp => emp.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
         
        }

        public Employee GetEmployees(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        //Ienumerable helps to get a collection of items
        //public IEnumerable<Employee> GetEmployees()
        //{
        //    var emp = _dbContext.Employees.ToList();

        //   return emp;
        //}

        //public Employee GetEmployees(Guid id, string Name)
        //{
        //    //return Employees.Where(Employee => Employee.Id == id && Employee.Name == Name).SingleOrDefault();
        //}
        ////public Employee GetEmployees(Guid id)
        ////{
        ////    //return Employees.Where(Employee => Employee.Id == id).SingleOrDefault();
        ////}

        //public void CreateItem(Employee employee)
        //{

        //    _dbContext.Employees.Add(employee);
        //    //Employees.Add(employee);
        //}

        //public void UpdateEmployee(Employee employee)
        //{

        //    //var index = Employees.FindIndex(existingEmployee =>existingEmployee.Id == employee.Id);
        //    //Employees[index] = employee;
        //}

        //public void DeleteItem(Guid id)
        //{
        //    //var index = Employees.FindIndex(existingEmployee => existingEmployee.Id ==id);
        //    //Employees.RemoveAt(index);
        //}


    }
}
