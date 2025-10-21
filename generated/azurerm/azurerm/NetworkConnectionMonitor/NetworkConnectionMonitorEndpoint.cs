using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpoint")]
    public class NetworkConnectionMonitorEndpoint : azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#name NetworkConnectionMonitor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#address NetworkConnectionMonitor#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#coverage_level NetworkConnectionMonitor#coverage_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coverageLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CoverageLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#excluded_ip_addresses NetworkConnectionMonitor#excluded_ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedIpAddresses
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#filter NetworkConnectionMonitor#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilter\"}", isOptional: true)]
        public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#included_ip_addresses NetworkConnectionMonitor#included_ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedIpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#target_resource_id NetworkConnectionMonitor#target_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#target_resource_type NetworkConnectionMonitor#target_resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceType
        {
            get;
            set;
        }
    }
}
