using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail")]
    public class CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#html_body CognitoRiskConfiguration#html_body}.</summary>
        [JsiiProperty(name: "htmlBody", typeJson: "{\"primitive\":\"string\"}")]
        public string HtmlBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#subject CognitoRiskConfiguration#subject}.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#text_body CognitoRiskConfiguration#text_body}.</summary>
        [JsiiProperty(name: "textBody", typeJson: "{\"primitive\":\"string\"}")]
        public string TextBody
        {
            get;
            set;
        }
    }
}
