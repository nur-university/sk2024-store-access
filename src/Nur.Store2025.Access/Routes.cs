using Nur.Store2025.Access.Catalog.Routes;
using Nur.Store2025.Access.Contracts;
using Nur.Store2025.Access.Identity.Routes;
using Nur.Store2025.Access.Inventory.Routes;

namespace Nur.Store2025.Access;

public class Routes
{
    public static readonly IEnumerable<ScopeAccessRule> RouteList = [
            .. CatalogRoutes.Routes,
            .. InventoryRoutes.Routes,
            .. IdentityRoutes.Routes
        ];

}
