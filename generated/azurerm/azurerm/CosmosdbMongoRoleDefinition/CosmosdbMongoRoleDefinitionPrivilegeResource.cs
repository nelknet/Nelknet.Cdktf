using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoRoleDefinition
{
    [JsiiByValue(fqn: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResource")]
    public class CosmosdbMongoRoleDefinitionPrivilegeResource : azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#collection_name CosmosdbMongoRoleDefinition#collection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#db_name CosmosdbMongoRoleDefinition#db_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbName
        {
            get;
            set;
        }
    }
}
