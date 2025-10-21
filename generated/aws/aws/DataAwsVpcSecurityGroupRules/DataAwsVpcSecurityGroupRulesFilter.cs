using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcSecurityGroupRules
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesFilter")]
    public class DataAwsVpcSecurityGroupRulesFilter : aws.DataAwsVpcSecurityGroupRules.IDataAwsVpcSecurityGroupRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#name DataAwsVpcSecurityGroupRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#values DataAwsVpcSecurityGroupRules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
