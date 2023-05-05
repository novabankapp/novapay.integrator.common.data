namespace NovaPay.Integrator.Common.Services.Settings
{
    public interface IWebhookSettings
    {
        string BasicPassword { get; }
        string BasicUserName { get; }
        string WebhookCreationTopic { get; }
        string WebhookServiceUrl { get; }
    }
}