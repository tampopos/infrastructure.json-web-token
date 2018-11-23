namespace Tmpps.Infrastructure.JsonWebToken.Interfaces
{
    public interface IJwtConfig
    {
        string JwtSecret { get; }
        int JwtExpiresDate { get; }
        string JwtAudience { get; }
        string JwtIssuer { get; }
    }
}