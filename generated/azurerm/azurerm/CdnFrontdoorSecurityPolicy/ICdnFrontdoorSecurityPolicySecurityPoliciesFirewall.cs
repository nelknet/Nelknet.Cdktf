using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecurityPolicy
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall")]
    public interface ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall
    {
        /// <summary>association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#association CdnFrontdoorSecurityPolicy#association}
        /// </remarks>
        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation\"}")]
        azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation Association
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_firewall_policy_id CdnFrontdoorSecurityPolicy#cdn_frontdoor_firewall_policy_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnFrontdoorFirewallPolicyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#association CdnFrontdoorSecurityPolicy#association}
            /// </remarks>
            [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation\"}")]
            public azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation Association
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_firewall_policy_id CdnFrontdoorSecurityPolicy#cdn_frontdoor_firewall_policy_id}.</summary>
            [JsiiProperty(name: "cdnFrontdoorFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnFrontdoorFirewallPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
