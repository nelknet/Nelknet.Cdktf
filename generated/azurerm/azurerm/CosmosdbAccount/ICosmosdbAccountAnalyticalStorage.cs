using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(ICosmosdbAccountAnalyticalStorage), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountAnalyticalStorage")]
    public interface ICosmosdbAccountAnalyticalStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#schema_type CosmosdbAccount#schema_type}.</summary>
        [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbAccountAnalyticalStorage), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountAnalyticalStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbAccount.ICosmosdbAccountAnalyticalStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#schema_type CosmosdbAccount#schema_type}.</summary>
            [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
