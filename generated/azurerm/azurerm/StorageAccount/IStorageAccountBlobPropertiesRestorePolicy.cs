using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountBlobPropertiesRestorePolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy")]
    public interface IStorageAccountBlobPropertiesRestorePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#days StorageAccount#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        double Days
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountBlobPropertiesRestorePolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#days StorageAccount#days}.</summary>
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
            public double Days
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
