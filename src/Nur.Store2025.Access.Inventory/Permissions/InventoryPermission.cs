namespace Nur.Store2025.Access.Inventory.Permissions;

public class InventoryPermission
{
    public const string TransactionCreate = "inventory.transaction:create";
    public const string TransactionApprove = "inventory.transaction:approve";
    public const string TransactionReject = "inventory.transaction:reject";

    public static readonly IEnumerable<string> PermissionsList =
        [
            TransactionCreate,
            TransactionApprove,
            TransactionReject
        ];
}
