using Nur.Store2025.Access.Inventory.Permissions;
using Nur.Store2025.Access.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nur.Store2025.Access.Inventory.Routes;

public class InventoryRoutes
{        
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/inventory/health", HttpMethod = "GET", AllowAnonymous = true },
        new() { RouteTemplate = "/api/inventory/transaction", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionCreate },
        new() { RouteTemplate = "/api/inventory/transaction/complete", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionApprove },
        new() { RouteTemplate = "/api/inventory/transaction/reject", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionReject },
        new() { RouteTemplate = "/api/inventory/transaction/{id}", HttpMethod = "GET" }

        ];
}
