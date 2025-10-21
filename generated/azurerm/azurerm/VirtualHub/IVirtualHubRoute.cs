using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHub
{
    [JsiiInterface(nativeType: typeof(IVirtualHubRoute), fullyQualifiedName: "azurerm.virtualHub.VirtualHubRoute")]
    public interface IVirtualHubRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#address_prefixes VirtualHub#address_prefixes}.</summary>
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AddressPrefixes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#next_hop_ip_address VirtualHub#next_hop_ip_address}.</summary>
        [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        string NextHopIpAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualHubRoute), fullyQualifiedName: "azurerm.virtualHub.VirtualHubRoute")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualHub.IVirtualHubRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#address_prefixes VirtualHub#address_prefixes}.</summary>
            [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AddressPrefixes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#next_hop_ip_address VirtualHub#next_hop_ip_address}.</summary>
            [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string NextHopIpAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
