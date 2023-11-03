namespace BirthdayGreeterKata
{
    public class BirthdayGreeter
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly DateTime _date;

        public BirthdayGreeter(
            IEmployeeRepository employeeRepository,
            DateTime date)
        {
            this.employeeRepository = employeeRepository;
            _date = date;
        }

        public void SendGreetings()
        {
            var employees = employeeRepository.FindEmployeesBornOn(_date);

            foreach (var employee in employees)
            {
                Email email = EmailFor(employee);
                new EmailSender().Send(email);
            }
        }

        private Email EmailFor(Employee employee)
        {
            string message = string.Format("Happy birthday, dear {0}!", employee.FirstName);
            return new Email(employee.Email, "Happy birthday!", message);
        }
    }

}
