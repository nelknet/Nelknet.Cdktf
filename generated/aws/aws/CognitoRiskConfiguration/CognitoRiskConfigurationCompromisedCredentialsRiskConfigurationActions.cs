using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions")]
    public class CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions : aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_action CognitoRiskConfiguration#event_action}.</summary>
        [JsiiProperty(name: "eventAction", typeJson: "{\"primitive\":\"string\"}")]
        public string EventAction
        {
            get;
            set;
        }
    }
}
