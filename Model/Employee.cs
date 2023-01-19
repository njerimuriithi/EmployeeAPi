namespace EmployeeAPi.Model
{
    public record Employee
    {
        //an init property accessor is used to assign a new value only during object construction
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Occupation { get; init; }
        public DateTime DateOfEmployment { get; init; }
        public string City { get; init; }

    }
}
