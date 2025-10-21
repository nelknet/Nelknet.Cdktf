using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubRoutingIntent
{
    [JsiiInterface(nativeType: typeof(IVirtualHubRoutingIntentRoutingPolicy), fullyQualifiedName: "azurerm.virtualHubRoutingIntent.VirtualHubRoutingIntentRoutingPolicy")]
    public interface IVirtualHubRoutingIntentRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#destinations VirtualHubRoutingIntent#destinations}.</summary>
        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Destinations
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#name VirtualHubRoutingIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#next_hop VirtualHubRoutingIntent#next_hop}.</summary>
        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        string NextHop
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualHubRoutingIntentRoutingPolicy), fullyQualifiedName: "azurerm.virtualHubRoutingIntent.VirtualHubRoutingIntentRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualHubRoutingIntent.IVirtualHubRoutingIntentRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#destinations VirtualHubRoutingIntent#destinations}.</summary>
            [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Destinations
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#name VirtualHubRoutingIntent#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#next_hop VirtualHubRoutingIntent#next_hop}.</summary>
            [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
            public string NextHop
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
