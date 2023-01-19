using EmployeeAPi.Model;

namespace EmployeeAPi.Repositories
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployees(Guid id);
         //This is for post 
        void CreateItem(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteItem(Guid id);
    }
}