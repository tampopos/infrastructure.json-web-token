using System.Security.Claims;

namespace Tmpps.Infrastructure.JsonWebToken.Interfaces
{
    public interface IJwtFactory
    {
        string Create(IJwtClaimInfo claimInfo);
        IJwtClaimInfo Create(ClaimsPrincipal claimsPrincipal);
    }
}