using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey
{
    [JsiiByValue(fqn: "azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts")]
    public class DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts : azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.IDatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#create DatabricksWorkspaceRootDbfsCustomerManagedKey#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#delete DatabricksWorkspaceRootDbfsCustomerManagedKey#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#read DatabricksWorkspaceRootDbfsCustomerManagedKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#update DatabricksWorkspaceRootDbfsCustomerManagedKey#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
