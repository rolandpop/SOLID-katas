namespace BirthdayGreeterKata
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }
    }
}
