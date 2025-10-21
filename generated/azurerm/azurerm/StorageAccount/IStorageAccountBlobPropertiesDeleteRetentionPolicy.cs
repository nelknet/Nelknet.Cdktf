using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountBlobPropertiesDeleteRetentionPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy")]
    public interface IStorageAccountBlobPropertiesDeleteRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#days StorageAccount#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#permanent_delete_enabled StorageAccount#permanent_delete_enabled}.</summary>
        [JsiiProperty(name: "permanentDeleteEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PermanentDeleteEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountBlobPropertiesDeleteRetentionPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#days StorageAccount#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#permanent_delete_enabled StorageAccount#permanent_delete_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permanentDeleteEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PermanentDeleteEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
