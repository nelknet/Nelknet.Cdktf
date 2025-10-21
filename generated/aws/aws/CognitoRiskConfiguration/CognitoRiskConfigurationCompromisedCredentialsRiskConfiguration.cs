using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration")]
    public class CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#actions CognitoRiskConfiguration#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions\"}")]
        public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions Actions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_filter CognitoRiskConfiguration#event_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EventFilter
        {
            get;
            set;
        }
    }
}
