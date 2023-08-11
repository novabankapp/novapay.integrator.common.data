namespace NovaPay.Integrator.Common.Services.Settings
{
    public interface IGeneralApiSettings
    {
        string ServiceName { get; }
        string TransactionUrl { get; }
        string ValidateUrl { get; }
    }
}