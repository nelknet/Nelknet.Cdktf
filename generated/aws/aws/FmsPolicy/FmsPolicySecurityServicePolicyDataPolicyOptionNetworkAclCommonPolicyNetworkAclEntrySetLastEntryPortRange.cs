using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyNetworkAclEntrySetLastEntryPortRange")]
    public class FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyNetworkAclEntrySetLastEntryPortRange : aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyNetworkAclEntrySetLastEntryPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#from FmsPolicy#from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? From
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#to FmsPolicy#to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? To
        {
            get;
            set;
        }
    }
}
