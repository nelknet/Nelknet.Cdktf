using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IStorageManagementPolicyRuleActions), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions")]
    public interface IStorageManagementPolicyRuleActions
    {
        /// <summary>base_blob block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#base_blob StorageManagementPolicy#base_blob}
        /// </remarks>
        [JsiiProperty(name: "baseBlob", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob? BaseBlob
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#snapshot StorageManagementPolicy#snapshot}
        /// </remarks>
        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot? Snapshot
        {
            get
            {
                return null;
            }
        }

        /// <summary>version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#version StorageManagementPolicy#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageManagementPolicyRuleActions), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>base_blob block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#base_blob StorageManagementPolicy#base_blob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseBlob", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob\"}", isOptional: true)]
            public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob? BaseBlob
            {
                get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob?>();
            }

            /// <summary>snapshot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#snapshot StorageManagementPolicy#snapshot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot\"}", isOptional: true)]
            public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot? Snapshot
            {
                get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot?>();
            }

            /// <summary>version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#version StorageManagementPolicy#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion\"}", isOptional: true)]
            public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion? Version
            {
                get => GetInstanceProperty<azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion?>();
            }
        }
    }
}
