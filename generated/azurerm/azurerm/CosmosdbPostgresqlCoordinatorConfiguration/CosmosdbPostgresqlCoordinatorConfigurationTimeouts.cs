using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbPostgresqlCoordinatorConfiguration
{
    [JsiiByValue(fqn: "azurerm.cosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfigurationTimeouts")]
    public class CosmosdbPostgresqlCoordinatorConfigurationTimeouts : azurerm.CosmosdbPostgresqlCoordinatorConfiguration.ICosmosdbPostgresqlCoordinatorConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#create CosmosdbPostgresqlCoordinatorConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#delete CosmosdbPostgresqlCoordinatorConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#read CosmosdbPostgresqlCoordinatorConfiguration#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#update CosmosdbPostgresqlCoordinatorConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
