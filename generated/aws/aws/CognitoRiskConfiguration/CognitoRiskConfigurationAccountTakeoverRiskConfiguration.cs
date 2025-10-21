using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfiguration")]
    public class CognitoRiskConfigurationAccountTakeoverRiskConfiguration : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfiguration
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#actions CognitoRiskConfiguration#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions\"}")]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions Actions
        {
            get;
            set;
        }

        /// <summary>notify_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#notify_configuration CognitoRiskConfiguration#notify_configuration}
        /// </remarks>
        [JsiiProperty(name: "notifyConfiguration", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration\"}")]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfiguration NotifyConfiguration
        {
            get;
            set;
        }
    }
}
