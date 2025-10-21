using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions")]
    public class CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions
    {
        /// <summary>high_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#high_action CognitoRiskConfiguration#high_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "highAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction? HighAction
        {
            get;
            set;
        }

        /// <summary>low_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#low_action CognitoRiskConfiguration#low_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lowAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction? LowAction
        {
            get;
            set;
        }

        /// <summary>medium_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#medium_action CognitoRiskConfiguration#medium_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mediumAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction\"}", isOptional: true)]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction
        {
            get;
            set;
        }
    }
}
