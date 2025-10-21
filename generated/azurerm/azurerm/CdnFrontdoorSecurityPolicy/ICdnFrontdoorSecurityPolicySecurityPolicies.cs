using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecurityPolicy
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPolicies), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPolicies")]
    public interface ICdnFrontdoorSecurityPolicySecurityPolicies
    {
        /// <summary>firewall block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#firewall CdnFrontdoorSecurityPolicy#firewall}
        /// </remarks>
        [JsiiProperty(name: "firewall", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall\"}")]
        azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall Firewall
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorSecurityPolicySecurityPolicies), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPolicies")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>firewall block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#firewall CdnFrontdoorSecurityPolicy#firewall}
            /// </remarks>
            [JsiiProperty(name: "firewall", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall\"}")]
            public azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall Firewall
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall>()!;
            }
        }
    }
}
