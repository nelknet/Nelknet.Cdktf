using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountTimeouts")]
    public interface IDataAzurermStorageAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#read DataAzurermStorageAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccount.IDataAzurermStorageAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#read DataAzurermStorageAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
