namespace BirthdayGreeterKata
{
    public interface IEmployeeRepository
    {
        List<Employee> FindEmployeesBornOn(DateTime date);
    }
}
