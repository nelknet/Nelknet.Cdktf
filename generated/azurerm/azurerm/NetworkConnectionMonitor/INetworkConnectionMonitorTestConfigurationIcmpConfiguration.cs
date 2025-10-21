using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiInterface(nativeType: typeof(INetworkConnectionMonitorTestConfigurationIcmpConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration")]
    public interface INetworkConnectionMonitorTestConfigurationIcmpConfiguration
    {
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

        [JsiiTypeProxy(nativeType: typeof(INetworkConnectionMonitorTestConfigurationIcmpConfiguration), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationIcmpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationIcmpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
