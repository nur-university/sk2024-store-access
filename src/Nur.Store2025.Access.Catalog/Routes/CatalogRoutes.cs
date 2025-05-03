
using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Contracts;

namespace Nur.Store2025.Access.Catalog.Routes;

public class CatalogRoutes
{       
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/catalog/health", HttpMethod = "GET", AllowAnonymous = true },

        new() { RouteTemplate = "/api/catalog/product", HttpMethod = "POST", RequiredScope = CatalogPermission.ProductCreate },
        new() { RouteTemplate = "/api/catalog/product/{id}", HttpMethod = "GET" },
        new() { RouteTemplate = "/api/catalog/product/", HttpMethod = "PUT", RequiredScope = CatalogPermission.ProductEdit },

        new() { RouteTemplate = "/api/catalog/category", HttpMethod = "POST", RequiredScope = CatalogPermission.CategoryManagement},
        new() { RouteTemplate = "/api/catalog/category", HttpMethod = "GET", RequiredScope = CatalogPermission.CategoryManagement},
    ];
}
