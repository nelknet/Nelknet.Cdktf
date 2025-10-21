using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMssqlDatabase.DataAzurermMssqlDatabaseTimeouts")]
    public class DataAzurermMssqlDatabaseTimeouts : azurerm.DataAzurermMssqlDatabase.IDataAzurermMssqlDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#read DataAzurermMssqlDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
