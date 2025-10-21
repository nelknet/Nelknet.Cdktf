using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiInterface(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicySpatialIndex), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex")]
    public interface ICosmosdbSqlContainerIndexingPolicySpatialIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#path CosmosdbSqlContainer#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicySpatialIndex), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex
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
