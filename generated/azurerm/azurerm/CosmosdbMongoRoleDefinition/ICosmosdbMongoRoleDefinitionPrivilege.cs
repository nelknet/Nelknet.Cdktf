using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoRoleDefinition
{
    [JsiiInterface(nativeType: typeof(ICosmosdbMongoRoleDefinitionPrivilege), fullyQualifiedName: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege")]
    public interface ICosmosdbMongoRoleDefinitionPrivilege
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#actions CosmosdbMongoRoleDefinition#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Actions
        {
            get;
        }

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#resource CosmosdbMongoRoleDefinition#resource}
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResource\"}")]
        azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource Resource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbMongoRoleDefinitionPrivilege), fullyQualifiedName: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilege
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#actions CosmosdbMongoRoleDefinition#actions}.</summary>
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Actions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#resource CosmosdbMongoRoleDefinition#resource}
            /// </remarks>
            [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResource\"}")]
            public azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource Resource
            {
                get => GetInstanceProperty<azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource>()!;
            }
        }
    }
}
