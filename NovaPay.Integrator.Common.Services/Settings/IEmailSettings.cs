namespace NovaPay.Integrator.Common.Services.Settings
{
    public interface IEmailSettings
    {
        string MailPassword { get; }
        string MailPort { get; }
        string MailSender { get; }
        string MailSenderName { get; }
        string MailServer { get; }
    }
}