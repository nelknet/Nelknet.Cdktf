using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex")]
    public class CosmosdbSqlContainerIndexingPolicySpatialIndex : azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#path CosmosdbSqlContainer#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
