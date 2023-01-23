using EmployeeAPi.Model;

namespace EmployeeAPi.Repositories
{
    public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(Guid id);
         //This is for post 
        Employee CreateItem(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteItem(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}