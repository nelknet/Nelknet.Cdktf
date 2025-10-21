using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorFirewallPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicyTimeouts")]
    public interface IDataAzurermCdnFrontdoorFirewallPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#read DataAzurermCdnFrontdoorFirewallPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorFirewallPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorFirewallPolicy.IDataAzurermCdnFrontdoorFirewallPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#read DataAzurermCdnFrontdoorFirewallPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
