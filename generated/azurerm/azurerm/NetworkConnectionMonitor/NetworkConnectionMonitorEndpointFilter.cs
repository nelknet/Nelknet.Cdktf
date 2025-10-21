using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiByValue(fqn: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilter")]
    public class NetworkConnectionMonitorEndpointFilter : azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilter
    {
        private object? _item;

        /// <summary>item block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#item NetworkConnectionMonitor#item}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "item", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorEndpointFilterItem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Item
        {
            get => _item;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilterItem[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorEndpointFilterItem).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _item = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#type NetworkConnectionMonitor#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
