using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceAzureSqlDatabase
{
    [JsiiInterface(nativeType: typeof(IDataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString")]
    public interface IDataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#linked_service_name DataFactoryLinkedServiceAzureSqlDatabase#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string LinkedServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#secret_name DataFactoryLinkedServiceAzureSqlDatabase#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceAzureSqlDatabase.DataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryLinkedServiceAzureSqlDatabase.IDataFactoryLinkedServiceAzureSqlDatabaseKeyVaultConnectionString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#linked_service_name DataFactoryLinkedServiceAzureSqlDatabase#linked_service_name}.</summary>
            [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string LinkedServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_sql_database#secret_name DataFactoryLinkedServiceAzureSqlDatabase#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
