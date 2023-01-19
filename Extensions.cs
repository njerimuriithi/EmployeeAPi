using EmployeeAPi.Dto;
using EmployeeAPi.Model;

namespace EmployeeAPi
{
    public static class Extensions
    {
        public static EmployeeDto AsDto(this Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Occupation = employee.Occupation,
                DateOfEmployment = employee.DateOfEmployment,
                City = employee.City,
            };

        }

    }
}
