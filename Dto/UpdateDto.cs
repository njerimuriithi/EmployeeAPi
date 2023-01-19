using System.ComponentModel.DataAnnotations;

namespace EmployeeAPi.Dto
{
    public record UpdateDto
    {
        
        public string Name { get; init; }
      
        public string Occupation { get; init; }
        
        public string City { get; init; }
    }
}
