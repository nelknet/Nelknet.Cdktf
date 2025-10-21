using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlServer
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMssqlServer.DataAzurermMssqlServerTimeouts")]
    public class DataAzurermMssqlServerTimeouts : azurerm.DataAzurermMssqlServer.IDataAzurermMssqlServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#read DataAzurermMssqlServer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
