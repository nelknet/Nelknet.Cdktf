using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration")]
    public interface ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#actions CognitoRiskConfiguration#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions\"}")]
        aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions Actions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_filter CognitoRiskConfiguration#event_filter}.</summary>
        [JsiiProperty(name: "eventFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#actions CognitoRiskConfiguration#actions}
            /// </remarks>
            [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions\"}")]
            public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions Actions
            {
                get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationCompromisedCredentialsRiskConfigurationActions>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_filter CognitoRiskConfiguration#event_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventFilter
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
