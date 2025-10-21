using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiInterface(nativeType: typeof(INetworkConnectionMonitorTestConfigurationTcpConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration")]
    public interface INetworkConnectionMonitorTestConfigurationTcpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#port NetworkConnectionMonitor#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#destination_port_behavior NetworkConnectionMonitor#destination_port_behavior}.</summary>
        [JsiiProperty(name: "destinationPortBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPortBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#trace_route_enabled NetworkConnectionMonitor#trace_route_enabled}.</summary>
        [JsiiProperty(name: "traceRouteEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TraceRouteEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkConnectionMonitorTestConfigurationTcpConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationTcpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationTcpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#port NetworkConnectionMonitor#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#destination_port_behavior NetworkConnectionMonitor#destination_port_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPortBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#trace_route_enabled NetworkConnectionMonitor#trace_route_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "traceRouteEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TraceRouteEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
