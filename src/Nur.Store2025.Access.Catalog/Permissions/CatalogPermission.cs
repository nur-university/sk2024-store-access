namespace Nur.Store2025.Access.Catalog.Permissions;

public class CatalogPermission
{
    public const string ProductCreate = "catalog.product:create";
    public const string ProductEdit = "catalog.product:edit";

    public const string CategoryManagement = "catalog.category:manage";

    public static readonly IEnumerable<string> PermissionsList =
        [
            ProductCreate,
            ProductEdit,

            CategoryManagement
        ];
}
