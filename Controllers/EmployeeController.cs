using EmployeeAPi.Dto;
using EmployeeAPi.Model;
using EmployeeAPi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace EmployeeAPi.Controllers
{
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //Declare the repo
          private readonly IEmployeeRepo emp_Repo;
        public EmployeeController(IEmployeeRepo emp_Repo)
        {
            this.emp_Repo =emp_Repo; 
        }

        [HttpGet]
        public IActionResult GetEmployees() 
        {
            return Ok(emp_Repo.GetEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(Guid id)
        {
          var employee = emp_Repo.GetEmployee(id);
           if(employee !=null)
                { 
                return Ok(employee);

                }
           return NotFound("Employee not found");
        }

        [HttpPost]
        public IActionResult GetEmployee(Employee employee)
        {
            emp_Repo.CreateItem(employee);
    
            return CreatedAtAction("Index", employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
           var emlp = emp_Repo.GetEmployee(id);
            if(emlp != null)
            {
                  emp_Repo.DeleteItem(emlp);
                return Ok();
            }
            return NotFound("Not Found");
        }
        [HttpPatch("{id}")]
        public IActionResult EditEmployee(Guid id ,Employee employee)
        {
            var existingEmployee = emp_Repo.GetEmployee(id);
            if (existingEmployee != null)
            {
                employee.Id = existingEmployee.Id;
                emp_Repo.EditEmployee(employee);
                
            }
            return Ok(employee);
        }


        // public IEnumerable<EmployeeDto> GetEmployees()
        //{
        //    var Employees = emp_Repo.GetEmployees().Select(employee =>employee.AsDto()); 
        //    return Employees;
        //}
        //[HttpGet("{id}")]
        //public ActionResult<EmployeeDto> GetEmployee(Guid id)
        //{

        //    var employee = emp_Repo.GetEmployees(id);
        //    if(employee is null)
        //    {
        //        return NotFound();
        //    }
        //    return employee.AsDto();
        //}

        //[HttpPost]
        //public ActionResult<EmployeeDto> CreateItem(CreateItemDto EmployeeDto) 
        //    {
        //    Employee employee = new()
        //    {
        //       Id=Guid.NewGuid(),
        //       Name=EmployeeDto.Name,
        //       Occupation=EmployeeDto.Occupation,
        //       DateOfEmployment=DateTime.Now,
        //       City=EmployeeDto.City,   
        //    };
        //    emp_Repo.CreateItem(employee);

        //    return CreatedAtAction(nameof(GetEmployee),new{employee = employee.Id},employee.AsDto());
        //    }

        //[HttpPut("{id}")]

        //public ActionResult UpdateEmployee(Guid id,UpdateDto EmployeeDto)
        //{
        //    var existingEmployee = emp_Repo.GetEmployees(id);
        //    if(existingEmployee is null)
        //    {
        //        return NotFound();
        //    }

        //    Employee UpdatedEmployee = existingEmployee with
        //    {
        //        Name= EmployeeDto.Name,
        //        Occupation=EmployeeDto.Occupation,
        //        City =EmployeeDto.City,
        //    };
        //    emp_Repo.UpdateEmployee(UpdatedEmployee);

        //    return NoContent();

        //}

        //[HttpDelete("{id}")]
        //public ActionResult DeleteEmployee(Guid id)
        //{
        //    var existingEmployee = emp_Repo.GetEmployees(id);
        //    if (existingEmployee is null)
        //    {
        //        return NotFound();

        //    }

        //    emp_Repo.DeleteItem(id);
        //    return NoContent(); 


        //}

    }
}
