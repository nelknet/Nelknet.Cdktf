using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions")]
    public class StorageManagementPolicyRuleActions : azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions
    {
        /// <summary>base_blob block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#base_blob StorageManagementPolicy#base_blob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseBlob", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
        public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob? BaseBlob
        {
            get;
            set;
        }

        /// <summary>snapshot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#snapshot StorageManagementPolicy#snapshot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot\"}", isOptional: true)]
        public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot? Snapshot
        {
            get;
            set;
        }

        /// <summary>version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#version StorageManagementPolicy#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}", isOptional: true)]
        public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion? Version
        {
            get;
            set;
        }
    }
}
