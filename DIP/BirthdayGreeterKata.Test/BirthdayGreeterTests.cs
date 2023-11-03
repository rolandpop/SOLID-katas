using Moq;

namespace BirthdayGreeterKata.Test
{
    [TestFixture]
    public class BirthdayGreeterTests
    {
        private static readonly DateTime _today = new DateTime(DateTime.Now.Year, 7, 9);

        private Mock<IEmployeeRepository> employeeRepository;

        private BirthdayGreeter birthdayGreeter;

        private StringWriter consoleContent;

        [SetUp]
        public void SetUp()
        {
            employeeRepository = new Mock<IEmployeeRepository>();
            birthdayGreeter = new BirthdayGreeter(employeeRepository.Object, _today);

            consoleContent = new StringWriter();
            Console.SetOut(consoleContent);
        }

        [Test]
        public void ShouldSendGreetingEmailToEmployee()
        {
            Employee employee = EmployeeBuilder.AnEmployee().Build();
            employeeRepository.Setup(repo => repo.FindEmployeesBornOn(_today))
                .Returns(new List<Employee> { employee });

            birthdayGreeter.SendGreetings();

            string actual = consoleContent.ToString();
            string expected = $"To:{employee.Email}, Subject: Happy birthday!, Message: Happy birthday, dear {employee.FirstName}!";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
