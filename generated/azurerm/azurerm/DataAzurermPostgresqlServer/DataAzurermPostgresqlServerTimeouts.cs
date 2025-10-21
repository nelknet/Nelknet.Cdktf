using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPostgresqlServer
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPostgresqlServer.DataAzurermPostgresqlServerTimeouts")]
    public class DataAzurermPostgresqlServerTimeouts : azurerm.DataAzurermPostgresqlServer.IDataAzurermPostgresqlServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#read DataAzurermPostgresqlServer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
