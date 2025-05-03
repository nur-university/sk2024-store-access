using Nur.Store2025.Access.Contracts;
using Nur.Store2025.Access.Identity.Permissions;

namespace Nur.Store2025.Access.Identity.Routes;

public class IdentityRoutes
{
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/identity/health", HttpMethod = "GET", AllowAnonymous = true },
        new() { RouteTemplate = "/api/identity/security/login", HttpMethod = "POST", AllowAnonymous = true },
        new() { RouteTemplate = "/api/identity/security/register-user", HttpMethod = "POST",  RequiredScope = IdentityPermission.UserAdmin },

        ];
}
