namespace BirthdayGreeterKata.Test
{
    public class EmployeeBuilder
    {
        private string firstName = "John";
        private string lastName = "Doe";
        private DateTime dateOfBirth = new DateTime(1980, 9, 10);
        private string email = "john.doe@foobar.com";

        public static EmployeeBuilder AnEmployee()
        {
            return new EmployeeBuilder();
        }

        public EmployeeBuilder WithEmail(string email)
        {
            this.email = email;
            return this;
        }

        public EmployeeBuilder WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public EmployeeBuilder WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public EmployeeBuilder WithDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
            return this;
        }

        public Employee Build()
        {
            return new Employee(firstName, lastName, dateOfBirth, email);
        }
    }
}
