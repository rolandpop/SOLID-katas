namespace BirthdayGreeterKata
{
    public class Email
    {
        public string To { get; }
        public string Subject { get; }
        public string Message { get; }

        public Email(string to, string subject, string message)
        {
            To = to;
            Subject = subject;
            Message = message;
        }
    }
}
