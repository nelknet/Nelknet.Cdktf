using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Firewall
{
    [JsiiInterface(nativeType: typeof(IFirewallVirtualHub), fullyQualifiedName: "azurerm.firewall.FirewallVirtualHub")]
    public interface IFirewallVirtualHub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#virtual_hub_id Firewall#virtual_hub_id}.</summary>
        [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualHubId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#public_ip_count Firewall#public_ip_count}.</summary>
        [JsiiProperty(name: "publicIpCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicIpCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallVirtualHub), fullyQualifiedName: "azurerm.firewall.FirewallVirtualHub")]
        internal sealed class _Proxy : DeputyBase, azurerm.Firewall.IFirewallVirtualHub
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#virtual_hub_id Firewall#virtual_hub_id}.</summary>
            [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualHubId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#public_ip_count Firewall#public_ip_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicIpCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
