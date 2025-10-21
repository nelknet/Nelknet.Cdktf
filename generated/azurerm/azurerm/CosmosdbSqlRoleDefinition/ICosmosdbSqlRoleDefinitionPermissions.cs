using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlRoleDefinition
{
    [JsiiInterface(nativeType: typeof(ICosmosdbSqlRoleDefinitionPermissions), fullyQualifiedName: "azurerm.cosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionPermissions")]
    public interface ICosmosdbSqlRoleDefinitionPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#data_actions CosmosdbSqlRoleDefinition#data_actions}.</summary>
        [JsiiProperty(name: "dataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DataActions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbSqlRoleDefinitionPermissions), fullyQualifiedName: "azurerm.cosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionPermissions")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbSqlRoleDefinition.ICosmosdbSqlRoleDefinitionPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#data_actions CosmosdbSqlRoleDefinition#data_actions}.</summary>
            [JsiiProperty(name: "dataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DataActions
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
