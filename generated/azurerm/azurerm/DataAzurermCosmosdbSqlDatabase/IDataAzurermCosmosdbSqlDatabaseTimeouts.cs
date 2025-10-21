using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbSqlDatabase
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCosmosdbSqlDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabaseTimeouts")]
    public interface IDataAzurermCosmosdbSqlDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#read DataAzurermCosmosdbSqlDatabase#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCosmosdbSqlDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCosmosdbSqlDatabase.IDataAzurermCosmosdbSqlDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#read DataAzurermCosmosdbSqlDatabase#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
