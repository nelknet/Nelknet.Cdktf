using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag")]
    public class StorageManagementPolicyRuleFiltersMatchBlobIndexTag : azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#name StorageManagementPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#value StorageManagementPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#operation StorageManagementPolicy#operation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operation
        {
            get;
            set;
        }
    }
}
