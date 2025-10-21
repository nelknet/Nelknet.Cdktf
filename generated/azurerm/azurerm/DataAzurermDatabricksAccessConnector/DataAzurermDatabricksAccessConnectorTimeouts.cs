using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabricksAccessConnector
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnectorTimeouts")]
    public class DataAzurermDatabricksAccessConnectorTimeouts : azurerm.DataAzurermDatabricksAccessConnector.IDataAzurermDatabricksAccessConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector#read DataAzurermDatabricksAccessConnector#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
