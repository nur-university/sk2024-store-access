using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Identity.Permissions;
using Nur.Store2025.Access.Inventory.Permissions;

namespace Nur.Store2025.Access;

public class Permission
{

    public static readonly IEnumerable<string> PermissionsList = [
            .. CatalogPermission.PermissionsList,
            .. InventoryPermission.PermissionsList,
            .. IdentityPermission.PermissionsList
        ];

}
