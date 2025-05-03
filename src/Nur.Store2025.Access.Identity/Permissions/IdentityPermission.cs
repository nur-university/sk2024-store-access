namespace Nur.Store2025.Access.Identity.Permissions;

public class IdentityPermission
{
    public const string UserAdmin = "identity.user:admin";

    public static readonly IEnumerable<string> PermissionsList = 
        [
            UserAdmin
        ];
}
