using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecurityPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall")]
    public class CdnFrontdoorSecurityPolicySecurityPoliciesFirewall : azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall
    {
        /// <summary>association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#association CdnFrontdoorSecurityPolicy#association}
        /// </remarks>
        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation\"}")]
        public azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociation Association
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_firewall_policy_id CdnFrontdoorSecurityPolicy#cdn_frontdoor_firewall_policy_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string CdnFrontdoorFirewallPolicyId
        {
            get;
            set;
        }
    }
}
