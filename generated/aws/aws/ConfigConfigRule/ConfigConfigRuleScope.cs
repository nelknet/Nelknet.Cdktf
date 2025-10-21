using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiByValue(fqn: "aws.configConfigRule.ConfigConfigRuleScope")]
    public class ConfigConfigRuleScope : aws.ConfigConfigRule.IConfigConfigRuleScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_id ConfigConfigRule#compliance_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComplianceResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_types ConfigConfigRule#compliance_resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ComplianceResourceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_key ConfigConfigRule#tag_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_value ConfigConfigRule#tag_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagValue
        {
            get;
            set;
        }
    }
}
