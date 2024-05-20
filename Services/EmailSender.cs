using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        Console.WriteLine($"Sending email to: {email}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {htmlMessage}");
        
        return Task.CompletedTask;
    }
}
