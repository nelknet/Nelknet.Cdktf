using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorDataCollectionEndpoint
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpointTimeouts")]
    public class DataAzurermMonitorDataCollectionEndpointTimeouts : azurerm.DataAzurermMonitorDataCollectionEndpoint.IDataAzurermMonitorDataCollectionEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint#read DataAzurermMonitorDataCollectionEndpoint#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
