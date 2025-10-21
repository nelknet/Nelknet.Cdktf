using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiInterface(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicyExcludedPath), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPath")]
    public interface ICosmosdbSqlContainerIndexingPolicyExcludedPath
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#path CosmosdbSqlContainer#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicyExcludedPath), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPath")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#path CosmosdbSqlContainer#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
