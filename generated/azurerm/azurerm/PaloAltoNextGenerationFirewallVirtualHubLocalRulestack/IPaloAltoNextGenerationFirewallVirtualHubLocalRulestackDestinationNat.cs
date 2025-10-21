using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat")]
    public interface IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#name PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#protocol PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>backend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#backend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#backend_config}
        /// </remarks>
        [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig? BackendConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#frontend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#frontend_config}
        /// </remarks>
        [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig? FrontendConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#name PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#protocol PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>backend_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#backend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#backend_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig? BackendConfig
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig?>();
            }

            /// <summary>frontend_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#frontend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#frontend_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig? FrontendConfig
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig?>();
            }
        }
    }
}
