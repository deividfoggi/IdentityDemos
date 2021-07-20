using System.Collections.Generic;

namespace Constants
{
  public static class ProductCatalogAPI
  {
    public const string CategoryUrl = "https://localhost:5050/api/Categories";
    public const string ProductUrl = "https://localhost:5050/api/Products";
    public const string ProductReadScope = "api://f2ecfa53-1fc8-4f10-84e5-a74f06a8b3d5/Product.Read";
    public const string ProductWriteScope = "api://f2ecfa53-1fc8-4f10-84e5-a74f06a8b3d5/Product.Write";
    public const string CategoryReadScope = "api://f2ecfa53-1fc8-4f10-84e5-a74f06a8b3d5/Category.Read";
    public const string CategoryWriteScope = "api://f2ecfa53-1fc8-4f10-84e5-a74f06a8b3d5/Category.Write";

    public static List<string> SCOPES = new List<string>()
    {
      ProductReadScope, ProductWriteScope, CategoryReadScope, CategoryWriteScope
    };
  }

  public static class ClaimIds
  {
    public const string UserObjectId = "http://schemas.microsoft.com/identity/claims/objectidentifier";
    public const string TenantId = "http://schemas.microsoft.com/identity/claims/tenantid";
  }
}