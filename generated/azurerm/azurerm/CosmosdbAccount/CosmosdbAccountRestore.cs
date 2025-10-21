using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountRestore")]
    public class CosmosdbAccountRestore : azurerm.CosmosdbAccount.ICosmosdbAccountRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#restore_timestamp_in_utc CosmosdbAccount#restore_timestamp_in_utc}.</summary>
        [JsiiProperty(name: "restoreTimestampInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public string RestoreTimestampInUtc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#source_cosmosdb_account_id CosmosdbAccount#source_cosmosdb_account_id}.</summary>
        [JsiiProperty(name: "sourceCosmosdbAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceCosmosdbAccountId
        {
            get;
            set;
        }

        private object? _database;

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#database CosmosdbAccount#database}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Database
        {
            get => _database;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbAccount.ICosmosdbAccountRestoreDatabase[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreDatabase).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _database = value;
            }
        }

        private object? _gremlinDatabase;

        /// <summary>gremlin_database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#gremlin_database CosmosdbAccount#gremlin_database}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gremlinDatabase", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreGremlinDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GremlinDatabase
        {
            get => _gremlinDatabase;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _gremlinDatabase = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#tables_to_restore CosmosdbAccount#tables_to_restore}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tablesToRestore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TablesToRestore
        {
            get;
            set;
        }
    }
}
