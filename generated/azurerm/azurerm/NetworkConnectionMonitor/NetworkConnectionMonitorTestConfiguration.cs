using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfiguration")]
    public class NetworkConnectionMonitorTestConfiguration : azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#name NetworkConnectionMonitor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#protocol NetworkConnectionMonitor#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>http_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#http_configuration NetworkConnectionMonitor#http_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfiguration\"}", isOptional: true)]
        public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration? HttpConfiguration
        {
            get;
            set;
        }

        /// <summary>icmp_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#icmp_configuration NetworkConnectionMonitor#icmp_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration\"}", isOptional: true)]
        public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration? IcmpConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#preferred_ip_version NetworkConnectionMonitor#preferred_ip_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredIpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredIpVersion
        {
            get;
            set;
        }

        /// <summary>success_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#success_threshold NetworkConnectionMonitor#success_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "successThreshold", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}", isOptional: true)]
        public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold? SuccessThreshold
        {
            get;
            set;
        }

        /// <summary>tcp_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#tcp_configuration NetworkConnectionMonitor#tcp_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration\"}", isOptional: true)]
        public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration? TcpConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#test_frequency_in_seconds NetworkConnectionMonitor#test_frequency_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TestFrequencyInSeconds
        {
            get;
            set;
        }
    }
}
