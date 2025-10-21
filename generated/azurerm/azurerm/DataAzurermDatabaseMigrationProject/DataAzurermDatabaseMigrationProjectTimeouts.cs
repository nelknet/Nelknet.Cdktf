using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabaseMigrationProject
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectTimeouts")]
    public class DataAzurermDatabaseMigrationProjectTimeouts : azurerm.DataAzurermDatabaseMigrationProject.IDataAzurermDatabaseMigrationProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#read DataAzurermDatabaseMigrationProject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
