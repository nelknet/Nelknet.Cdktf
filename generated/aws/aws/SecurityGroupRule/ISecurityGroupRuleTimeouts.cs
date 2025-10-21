using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityGroupRule
{
    [JsiiInterface(nativeType: typeof(ISecurityGroupRuleTimeouts), fullyQualifiedName: "aws.securityGroupRule.SecurityGroupRuleTimeouts")]
    public interface ISecurityGroupRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#create SecurityGroupRule#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityGroupRuleTimeouts), fullyQualifiedName: "aws.securityGroupRule.SecurityGroupRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityGroupRule.ISecurityGroupRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#create SecurityGroupRule#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
