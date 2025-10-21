using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyTimeouts")]
    public class DataAzurermStorageManagementPolicyTimeouts : azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#read DataAzurermStorageManagementPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
