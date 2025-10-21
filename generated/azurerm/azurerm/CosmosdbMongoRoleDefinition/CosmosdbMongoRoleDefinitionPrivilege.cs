using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoRoleDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege")]
    public class CosmosdbMongoRoleDefinitionPrivilege : azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilege
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#actions CosmosdbMongoRoleDefinition#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Actions
        {
            get;
            set;
        }

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#resource CosmosdbMongoRoleDefinition#resource}
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResource\"}")]
        public azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource Resource
        {
            get;
            set;
        }
    }
}
