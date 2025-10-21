using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountShareProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountShareProperties")]
    public interface IStorageAccountShareProperties
    {
        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CorsRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#retention_policy StorageAccount#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy? RetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>smb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#smb StorageAccount#smb}
        /// </remarks>
        [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountSharePropertiesSmb? Smb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountShareProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountShareProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountShareProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cors_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CorsRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#retention_policy StorageAccount#retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy? RetentionPolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy?>();
            }

            /// <summary>smb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#smb StorageAccount#smb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmb\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountSharePropertiesSmb? Smb
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSharePropertiesSmb?>();
            }
        }
    }
}
