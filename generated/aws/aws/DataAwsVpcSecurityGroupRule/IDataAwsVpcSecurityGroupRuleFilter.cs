using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcSecurityGroupRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcSecurityGroupRuleFilter), fullyQualifiedName: "aws.dataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRuleFilter")]
    public interface IDataAwsVpcSecurityGroupRuleFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#name DataAwsVpcSecurityGroupRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#values DataAwsVpcSecurityGroupRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcSecurityGroupRuleFilter), fullyQualifiedName: "aws.dataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRuleFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcSecurityGroupRule.IDataAwsVpcSecurityGroupRuleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#name DataAwsVpcSecurityGroupRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#values DataAwsVpcSecurityGroupRule#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
