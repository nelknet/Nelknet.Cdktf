using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityGroupRule
{
    [JsiiByValue(fqn: "aws.securityGroupRule.SecurityGroupRuleTimeouts")]
    public class SecurityGroupRuleTimeouts : aws.SecurityGroupRule.ISecurityGroupRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#create SecurityGroupRule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
