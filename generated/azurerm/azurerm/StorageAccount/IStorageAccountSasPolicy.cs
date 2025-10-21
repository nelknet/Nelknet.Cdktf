using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountSasPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountSasPolicy")]
    public interface IStorageAccountSasPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_period StorageAccount#expiration_period}.</summary>
        [JsiiProperty(name: "expirationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        string ExpirationPeriod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_action StorageAccount#expiration_action}.</summary>
        [JsiiProperty(name: "expirationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirationAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountSasPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountSasPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountSasPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_period StorageAccount#expiration_period}.</summary>
            [JsiiProperty(name: "expirationPeriod", typeJson: "{\"primitive\":\"string\"}")]
            public string ExpirationPeriod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_action StorageAccount#expiration_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expirationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirationAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
