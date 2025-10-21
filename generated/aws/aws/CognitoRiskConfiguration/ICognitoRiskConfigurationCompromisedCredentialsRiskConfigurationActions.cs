using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions")]
    public interface ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_action CognitoRiskConfiguration#event_action}.</summary>
        [JsiiProperty(name: "eventAction", typeJson: "{\"primitive\":\"string\"}")]
        string EventAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_action CognitoRiskConfiguration#event_action}.</summary>
            [JsiiProperty(name: "eventAction", typeJson: "{\"primitive\":\"string\"}")]
            public string EventAction
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
