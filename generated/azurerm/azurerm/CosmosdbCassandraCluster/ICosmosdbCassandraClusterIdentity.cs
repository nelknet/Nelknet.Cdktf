using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraCluster
{
    [JsiiInterface(nativeType: typeof(ICosmosdbCassandraClusterIdentity), fullyQualifiedName: "azurerm.cosmosdbCassandraCluster.CosmosdbCassandraClusterIdentity")]
    public interface ICosmosdbCassandraClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#type CosmosdbCassandraCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbCassandraClusterIdentity), fullyQualifiedName: "azurerm.cosmosdbCassandraCluster.CosmosdbCassandraClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbCassandraCluster.ICosmosdbCassandraClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#type CosmosdbCassandraCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
