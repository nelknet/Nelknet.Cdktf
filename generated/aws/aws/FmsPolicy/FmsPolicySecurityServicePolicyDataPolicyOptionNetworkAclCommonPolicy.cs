using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy")]
    public class FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy : aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy
    {
        /// <summary>network_acl_entry_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#network_acl_entry_set FmsPolicy#network_acl_entry_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkAclEntrySet", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyNetworkAclEntrySet\"}", isOptional: true)]
        public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyNetworkAclEntrySet? NetworkAclEntrySet
        {
            get;
            set;
        }
    }
}
