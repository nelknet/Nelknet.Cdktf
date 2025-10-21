using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MapsAccount
{
    [JsiiInterface(nativeType: typeof(IMapsAccountDataStore), fullyQualifiedName: "azurerm.mapsAccount.MapsAccountDataStore")]
    public interface IMapsAccountDataStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#unique_name MapsAccount#unique_name}.</summary>
        [JsiiProperty(name: "uniqueName", typeJson: "{\"primitive\":\"string\"}")]
        string UniqueName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#storage_account_id MapsAccount#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMapsAccountDataStore), fullyQualifiedName: "azurerm.mapsAccount.MapsAccountDataStore")]
        internal sealed class _Proxy : DeputyBase, azurerm.MapsAccount.IMapsAccountDataStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#unique_name MapsAccount#unique_name}.</summary>
            [JsiiProperty(name: "uniqueName", typeJson: "{\"primitive\":\"string\"}")]
            public string UniqueName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#storage_account_id MapsAccount#storage_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
