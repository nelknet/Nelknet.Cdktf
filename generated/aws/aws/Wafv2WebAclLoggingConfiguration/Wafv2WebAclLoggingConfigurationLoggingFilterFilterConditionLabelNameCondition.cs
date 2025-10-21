using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition : aws.Wafv2WebAclLoggingConfiguration.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#label_name Wafv2WebAclLoggingConfiguration#label_name}.</summary>
        [JsiiProperty(name: "labelName", typeJson: "{\"primitive\":\"string\"}")]
        public string LabelName
        {
            get;
            set;
        }
    }
}
