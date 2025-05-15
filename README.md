# SharedKernel - Access
Esta solución incluye una serie de proyectos de tipo Bibliotecas de Clases donde se define los permisos por cada microservicio y las rutas de cada uno junto con su permiso necesario (scope) con el objetivo de centralizarlos y poder utilizarlos en otros proyectos.

## Nur.Store2025.Access.Contracts
Este proyecto define los objetos que se utilizarán en los siguientes proyectos. Actualmente, el único objeto definido es `ScopeAccessRule`. Este objeto representa una ruta de un endpoint donde podemos definir las siguientes propiedades:

```
var rule = new ScopeAccessRule() {
        RouteTemplate = "/api/catalog/product/{id}", 
        HttpMethod = "GET", 
        RequiredScope = "catalog:read",
        AllowAnonymous = false
};
```

## Nur.Store2025.Access.Identity
Este proyecto define los Permisos y Rutas utilizados en el Microservicio de Identity. Para acceder a la lista de Permisos se debe usar la lista de strings declada en `IdentityPermission.PermissionsList` y para acceder a las Rutas se puede usar la lista declarada en `IdentityRoutes.Routes`

Este proyecto puede ser incluido como dependencia incluyendo el Nuget Package `Nur.Store2025.Access.Identity` de la siguiente forma: 

```
Install-Package Nur.Store2025.Access.Identity -Version 1.0.0
```

## Nur.Store2025.Access.Catalog
Este proyecto define los Permisos y Rutas utilizados en el Microservicio de Catalogo (Catalog). Para acceder a la lista de Permisos se debe usar la lista  de strings declada en `CatalogPermission.PermissionsList` y para acceder a las Rutas se puede usar la lista declarada en `CatalogRoutes.Routes`

Este proyecto puede ser incluido como dependencia incluyendo el Nuget Package `Nur.Store2025.Access.Catalog` de la siguiente forma: 

```
Install-Package Nur.Store2025.Access.Catalog -Version 1.0.0
```

## Nur.Store2025.Access.Inventory
Este proyecto define los Permisos y Rutas utilizados en el Microservicio de Inventario (Inventory). Para acceder a la lista de Permisos se debe usar la lista  de strings declada en `InventoryPermission.PermissionsList` y para acceder a las Rutas se puede usar la lista declarada en `InventoryRoutes.Routes`

Este proyecto puede ser incluido como dependencia incluyendo el Nuget Package Nur.Store2025.Access.Inventory` de la siguiente forma: 

```
Install-Package Nur.Store2025.Access.Inventory -Version 1.0.0
```

## Nur.Store2025.Access
Este proyecto incluye todos los permisos y rutas declarados en los proyectos anteriores con el objetivo de centralizar todo. Para acceder a todos los permisos se debe usar la lista  de strings declada en `Permission.PermissionsList` y para acceder a las Rutas se puede usar la lista declarada en `Routes.RouteList`. 

Este proyecto puede ser incluido como dependencia incluyendo el Nuget Package Nur.Store2025.Access` de la siguiente forma: 

```
Install-Package Nur.Store2025.Access -Version 1.0.0
```