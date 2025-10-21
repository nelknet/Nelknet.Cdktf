using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiInterface(nativeType: typeof(ICosmosdbSqlContainerConflictResolutionPolicy), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicy")]
    public interface ICosmosdbSqlContainerConflictResolutionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#mode CosmosdbSqlContainer#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_path CosmosdbSqlContainer#conflict_resolution_path}.</summary>
        [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictResolutionPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_procedure CosmosdbSqlContainer#conflict_resolution_procedure}.</summary>
        [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictResolutionProcedure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbSqlContainerConflictResolutionPolicy), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerConflictResolutionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#mode CosmosdbSqlContainer#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_path CosmosdbSqlContainer#conflict_resolution_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictResolutionPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_procedure CosmosdbSqlContainer#conflict_resolution_procedure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictResolutionProcedure
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
