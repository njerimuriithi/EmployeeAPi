namespace EmployeeAPi.Model
{
    public class Employee
    {
        //an init property accessor is used to assign a new value only during object construction
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string City { get; set; }

    }
}
