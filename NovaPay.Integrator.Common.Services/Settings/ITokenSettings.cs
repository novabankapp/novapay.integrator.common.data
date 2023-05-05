namespace NovaPay.Integrator.Common.Services.Settings
{
    public interface ITokenSettings
    {
        string JwtIssuer { get; }
        string JwtKey { get; }
        int JwtLifespanDays { get; }
        string UserIdSlug { get; }
    }
}