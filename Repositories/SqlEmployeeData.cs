using EmployeeAPi.Data;
using EmployeeAPi.Model;

namespace EmployeeAPi.Repositories
{
    public class SqlEmployeeData : IEmployeeRepo
    {
        private EmployeeDbContext  _empContext;
        public SqlEmployeeData(EmployeeDbContext employeeDbContext)
        {
          _empContext = employeeDbContext;      
        }
   
        
        public void DeleteItem(Employee employee)
        {
           _empContext.Employees.Remove(employee);
            _empContext.SaveChanges();  
        }

        public Employee EditEmployee(Employee employee)
        {
            var ExistingEmployee = _empContext.Employees.Find(employee.Id);
            if (ExistingEmployee != null)
            {      ExistingEmployee.Id = employee.Id;
                _empContext.Employees.Update(ExistingEmployee);
                _empContext.SaveChanges();  
            }
            return employee;    
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _empContext.Employees.Find(id);
            return employee;
            //return _empContext.Employees.SingleOrDefault(emp => emp.Id == id);   
        }

        public List<Employee> GetEmployees()
        {
           return  _empContext.Employees.ToList();
        }

   
       public Employee CreateItem(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _empContext.Employees.Add(employee);
            _empContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
