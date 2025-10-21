using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicy")]
    public class CosmosdbSqlContainerConflictResolutionPolicy : azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerConflictResolutionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#mode CosmosdbSqlContainer#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_path CosmosdbSqlContainer#conflict_resolution_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictResolutionPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_procedure CosmosdbSqlContainer#conflict_resolution_procedure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictResolutionProcedure
        {
            get;
            set;
        }
    }
}
