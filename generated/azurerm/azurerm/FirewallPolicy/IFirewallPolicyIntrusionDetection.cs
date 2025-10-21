using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IFirewallPolicyIntrusionDetection), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyIntrusionDetection")]
    public interface IFirewallPolicyIntrusionDetection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#mode FirewallPolicy#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#private_ranges FirewallPolicy#private_ranges}.</summary>
        [JsiiProperty(name: "privateRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrivateRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>signature_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#signature_overrides FirewallPolicy#signature_overrides}
        /// </remarks>
        [JsiiProperty(name: "signatureOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionSignatureOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SignatureOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>traffic_bypass block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#traffic_bypass FirewallPolicy#traffic_bypass}
        /// </remarks>
        [JsiiProperty(name: "trafficBypass", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionTrafficBypass\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrafficBypass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallPolicyIntrusionDetection), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyIntrusionDetection")]
        internal sealed class _Proxy : DeputyBase, azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#mode FirewallPolicy#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#private_ranges FirewallPolicy#private_ranges}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrivateRanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>signature_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#signature_overrides FirewallPolicy#signature_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signatureOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionSignatureOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SignatureOverrides
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>traffic_bypass block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#traffic_bypass FirewallPolicy#traffic_bypass}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficBypass", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionTrafficBypass\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrafficBypass
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
