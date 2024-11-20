using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
namespace DemoBlazorWebAppWasmSignalRChat.Authentication
{
    internal static class IdentityComponentsEnpointsRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapAdditionalIdentityEnpoints(this IEndpointRouteBuilder endpoints)
        {
            var accountGroup = endpoints.MapGroup("/Account");
            accountGroup.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<AppUser> signInManager) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.LocalRedirect("/");
            });
            return accountGroup;
        }
    }
}
