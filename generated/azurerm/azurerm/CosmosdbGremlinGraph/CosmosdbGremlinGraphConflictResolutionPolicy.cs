using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinGraph
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy")]
    public class CosmosdbGremlinGraphConflictResolutionPolicy : azurerm.CosmosdbGremlinGraph.ICosmosdbGremlinGraphConflictResolutionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#mode CosmosdbGremlinGraph#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_path CosmosdbGremlinGraph#conflict_resolution_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictResolutionPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_procedure CosmosdbGremlinGraph#conflict_resolution_procedure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictResolutionProcedure
        {
            get;
            set;
        }
    }
}
