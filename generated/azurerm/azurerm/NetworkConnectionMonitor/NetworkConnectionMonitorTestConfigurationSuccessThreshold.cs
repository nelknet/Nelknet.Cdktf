using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiByValue(fqn: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold")]
    public class NetworkConnectionMonitorTestConfigurationSuccessThreshold : azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#checks_failed_percent NetworkConnectionMonitor#checks_failed_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checksFailedPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChecksFailedPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#round_trip_time_ms NetworkConnectionMonitor#round_trip_time_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roundTripTimeMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RoundTripTimeMs
        {
            get;
            set;
        }
    }
}
