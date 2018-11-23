using System.Security.Claims;
namespace Tmpps.Infrastructure.JsonWebToken.Interfaces
{
    public interface IClaimContext<TClaim>
    {
        TClaim Claim { get; }
        void Impersonate(TClaim claim);
        void SetClaims(ClaimsPrincipal claimsPrincipal);
    }
}