using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiByValue(fqn: "aws.configConfigRule.ConfigConfigRuleEvaluationMode")]
    public class ConfigConfigRuleEvaluationMode : aws.ConfigConfigRule.IConfigConfigRuleEvaluationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#mode ConfigConfigRule#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
