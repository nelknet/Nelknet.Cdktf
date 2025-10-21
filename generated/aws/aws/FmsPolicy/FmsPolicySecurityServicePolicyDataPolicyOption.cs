using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption")]
    public class FmsPolicySecurityServicePolicyDataPolicyOption : aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption
    {
        /// <summary>network_acl_common_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_acl_common_policy FmsPolicy#network_acl_common_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkAclCommonPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy\"}", isOptional: true)]
        public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy? NetworkAclCommonPolicy
        {
            get;
            set;
        }

        /// <summary>network_firewall_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_firewall_policy FmsPolicy#network_firewall_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy\"}", isOptional: true)]
        public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy? NetworkFirewallPolicy
        {
            get;
            set;
        }

        /// <summary>third_party_firewall_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#third_party_firewall_policy FmsPolicy#third_party_firewall_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thirdPartyFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy\"}", isOptional: true)]
        public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy? ThirdPartyFirewallPolicy
        {
            get;
            set;
        }
    }
}
