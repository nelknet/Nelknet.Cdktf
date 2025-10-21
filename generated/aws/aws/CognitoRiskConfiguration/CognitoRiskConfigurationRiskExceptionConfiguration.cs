using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationRiskExceptionConfiguration")]
    public class CognitoRiskConfigurationRiskExceptionConfiguration : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationRiskExceptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#blocked_ip_range_list CognitoRiskConfiguration#blocked_ip_range_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockedIpRangeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BlockedIpRangeList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#skipped_ip_range_list CognitoRiskConfiguration#skipped_ip_range_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skippedIpRangeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SkippedIpRangeList
        {
            get;
            set;
        }
    }
}
