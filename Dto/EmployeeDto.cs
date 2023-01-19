namespace EmployeeAPi.Dto
{
    public record EmployeeDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Occupation { get; init; }
        public DateTime DateOfEmployment { get; init; }
        public string City { get; init; }
    }
}
