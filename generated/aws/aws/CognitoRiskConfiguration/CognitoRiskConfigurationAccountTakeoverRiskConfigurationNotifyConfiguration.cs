using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration")]
    public class CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#source_arn CognitoRiskConfiguration#source_arn}.</summary>
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceArn
        {
            get;
            set;
        }

        /// <summary>block_email block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#block_email CognitoRiskConfiguration#block_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockEmail", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail? BlockEmail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#from CognitoRiskConfiguration#from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? From
        {
            get;
            set;
        }

        /// <summary>mfa_email block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#mfa_email CognitoRiskConfiguration#mfa_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mfaEmail", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail? MfaEmail
        {
            get;
            set;
        }

        /// <summary>no_action_email block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#no_action_email CognitoRiskConfiguration#no_action_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noActionEmail", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail? NoActionEmail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#reply_to CognitoRiskConfiguration#reply_to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replyTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplyTo
        {
            get;
            set;
        }
    }
}
