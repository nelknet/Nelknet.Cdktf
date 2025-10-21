using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiByValue(fqn: "azurerm.firewallPolicy.FirewallPolicyIntrusionDetection")]
    public class FirewallPolicyIntrusionDetection : azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#mode FirewallPolicy#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#private_ranges FirewallPolicy#private_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrivateRanges
        {
            get;
            set;
        }

        private object? _signatureOverrides;

        /// <summary>signature_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#signature_overrides FirewallPolicy#signature_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signatureOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionSignatureOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SignatureOverrides
        {
            get => _signatureOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetectionSignatureOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetectionSignatureOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _signatureOverrides = value;
            }
        }

        private object? _trafficBypass;

        /// <summary>traffic_bypass block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#traffic_bypass FirewallPolicy#traffic_bypass}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trafficBypass", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionTrafficBypass\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrafficBypass
        {
            get => _trafficBypass;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetectionTrafficBypass[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetectionTrafficBypass).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trafficBypass = value;
            }
        }
    }
}
