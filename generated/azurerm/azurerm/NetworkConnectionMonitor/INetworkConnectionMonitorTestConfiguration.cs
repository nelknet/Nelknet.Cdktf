using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiInterface(nativeType: typeof(INetworkConnectionMonitorTestConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfiguration")]
    public interface INetworkConnectionMonitorTestConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#name NetworkConnectionMonitor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#protocol NetworkConnectionMonitor#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>http_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#http_configuration NetworkConnectionMonitor#http_configuration}
        /// </remarks>
        [JsiiProperty(name: "httpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration? HttpConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>icmp_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#icmp_configuration NetworkConnectionMonitor#icmp_configuration}
        /// </remarks>
        [JsiiProperty(name: "icmpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration? IcmpConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#preferred_ip_version NetworkConnectionMonitor#preferred_ip_version}.</summary>
        [JsiiProperty(name: "preferredIpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredIpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>success_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#success_threshold NetworkConnectionMonitor#success_threshold}
        /// </remarks>
        [JsiiProperty(name: "successThreshold", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold? SuccessThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#tcp_configuration NetworkConnectionMonitor#tcp_configuration}
        /// </remarks>
        [JsiiProperty(name: "tcpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration? TcpConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#test_frequency_in_seconds NetworkConnectionMonitor#test_frequency_in_seconds}.</summary>
        [JsiiProperty(name: "testFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TestFrequencyInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkConnectionMonitorTestConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#name NetworkConnectionMonitor#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#protocol NetworkConnectionMonitor#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>http_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#http_configuration NetworkConnectionMonitor#http_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationHttpConfiguration\"}", isOptional: true)]
            public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration? HttpConfiguration
            {
                get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationHttpConfiguration?>();
            }

            /// <summary>icmp_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#icmp_configuration NetworkConnectionMonitor#icmp_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration\"}", isOptional: true)]
            public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration? IcmpConfiguration
            {
                get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#preferred_ip_version NetworkConnectionMonitor#preferred_ip_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredIpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredIpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>success_threshold block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#success_threshold NetworkConnectionMonitor#success_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successThreshold", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}", isOptional: true)]
            public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold? SuccessThreshold
            {
                get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold?>();
            }

            /// <summary>tcp_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#tcp_configuration NetworkConnectionMonitor#tcp_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpConfiguration", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration\"}", isOptional: true)]
            public azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration? TcpConfiguration
            {
                get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#test_frequency_in_seconds NetworkConnectionMonitor#test_frequency_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "testFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TestFrequencyInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
