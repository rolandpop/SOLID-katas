namespace BirthdayGreeterKata
{
    public class EmailSender
    {
        public void Send(Email email)
        {
            Console.Write($"To:{email.To}, Subject: {email.Subject}, Message: {email.Message}");
        }
    }
}
