using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiInterface(nativeType: typeof(IFmsPolicySecurityServicePolicyDataPolicyOption), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption")]
    public interface IFmsPolicySecurityServicePolicyDataPolicyOption
    {
        /// <summary>network_acl_common_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_acl_common_policy FmsPolicy#network_acl_common_policy}
        /// </remarks>
        [JsiiProperty(name: "networkAclCommonPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy? NetworkAclCommonPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_firewall_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_firewall_policy FmsPolicy#network_firewall_policy}
        /// </remarks>
        [JsiiProperty(name: "networkFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy? NetworkFirewallPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>third_party_firewall_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#third_party_firewall_policy FmsPolicy#third_party_firewall_policy}
        /// </remarks>
        [JsiiProperty(name: "thirdPartyFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy? ThirdPartyFirewallPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFmsPolicySecurityServicePolicyDataPolicyOption), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption")]
        internal sealed class _Proxy : DeputyBase, aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>network_acl_common_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_acl_common_policy FmsPolicy#network_acl_common_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkAclCommonPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy\"}", isOptional: true)]
            public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy? NetworkAclCommonPolicy
            {
                get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy?>();
            }

            /// <summary>network_firewall_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_firewall_policy FmsPolicy#network_firewall_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy\"}", isOptional: true)]
            public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy? NetworkFirewallPolicy
            {
                get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy?>();
            }

            /// <summary>third_party_firewall_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#third_party_firewall_policy FmsPolicy#third_party_firewall_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thirdPartyFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy\"}", isOptional: true)]
            public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy? ThirdPartyFirewallPolicy
            {
                get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy?>();
            }
        }
    }
}
