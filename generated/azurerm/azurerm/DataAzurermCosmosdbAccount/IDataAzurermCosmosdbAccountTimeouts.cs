using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCosmosdbAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts")]
    public interface IDataAzurermCosmosdbAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#read DataAzurermCosmosdbAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCosmosdbAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#read DataAzurermCosmosdbAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
