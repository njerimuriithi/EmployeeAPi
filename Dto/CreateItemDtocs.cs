using System.ComponentModel.DataAnnotations;

namespace EmployeeAPi.Dto
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Occupation { get; init; }
        [Required]
        public string City { get; init; }
    }
}
