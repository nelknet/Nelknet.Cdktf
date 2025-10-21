using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkWatcher
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkWatcher.DataAzurermNetworkWatcherTimeouts")]
    public class DataAzurermNetworkWatcherTimeouts : azurerm.DataAzurermNetworkWatcher.IDataAzurermNetworkWatcherTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_watcher#read DataAzurermNetworkWatcher#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
