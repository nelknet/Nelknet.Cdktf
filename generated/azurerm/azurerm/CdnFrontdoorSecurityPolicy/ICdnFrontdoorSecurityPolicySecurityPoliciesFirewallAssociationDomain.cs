using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecurityPolicy
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain")]
    public interface ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_domain_id CdnFrontdoorSecurityPolicy#cdn_frontdoor_domain_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorDomainId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnFrontdoorDomainId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewallAssociationDomain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_domain_id CdnFrontdoorSecurityPolicy#cdn_frontdoor_domain_id}.</summary>
            [JsiiProperty(name: "cdnFrontdoorDomainId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnFrontdoorDomainId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
