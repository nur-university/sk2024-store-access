using Nur.Store2025.Access.Catalog;
using Nur.Store2025.Access.Identity;
using Nur.Store2025.Access.Inventory;

namespace Nur.Store2025.Access;

public class Services
{
    public static readonly IEnumerable<string> ServicesList = [
        CatalogService.ServiceName,
        IdentityService.ServiceName, 
        InventoryService.ServiceName,
    ];
}
