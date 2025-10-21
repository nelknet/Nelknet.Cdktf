using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcSecurityGroupRules
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcSecurityGroupRulesFilter), fullyQualifiedName: "aws.dataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesFilter")]
    public interface IDataAwsVpcSecurityGroupRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#name DataAwsVpcSecurityGroupRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#values DataAwsVpcSecurityGroupRules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcSecurityGroupRulesFilter), fullyQualifiedName: "aws.dataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcSecurityGroupRules.IDataAwsVpcSecurityGroupRulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#name DataAwsVpcSecurityGroupRules#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#values DataAwsVpcSecurityGroupRules#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
