using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    [JsiiInterface(nativeType: typeof(ICosmosdbGremlinGraphConflictResolutionPolicy), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy")]
    public interface ICosmosdbGremlinGraphConflictResolutionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#mode CosmosdbGremlinGraph#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_path CosmosdbGremlinGraph#conflict_resolution_path}.</summary>
        [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictResolutionPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_procedure CosmosdbGremlinGraph#conflict_resolution_procedure}.</summary>
        [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictResolutionProcedure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbGremlinGraphConflictResolutionPolicy), fullyQualifiedName: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#mode CosmosdbGremlinGraph#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_path CosmosdbGremlinGraph#conflict_resolution_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictResolutionPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_procedure CosmosdbGremlinGraph#conflict_resolution_procedure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictResolutionProcedure
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
