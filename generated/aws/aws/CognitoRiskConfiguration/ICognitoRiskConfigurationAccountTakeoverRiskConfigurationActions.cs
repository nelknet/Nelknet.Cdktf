using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions")]
    public interface ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions
    {
        /// <summary>high_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#high_action CognitoRiskConfiguration#high_action}
        /// </remarks>
        [JsiiProperty(name: "highAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction? HighAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>low_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#low_action CognitoRiskConfiguration#low_action}
        /// </remarks>
        [JsiiProperty(name: "lowAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction? LowAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>medium_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#medium_action CognitoRiskConfiguration#medium_action}
        /// </remarks>
        [JsiiProperty(name: "mediumAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActions")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>high_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#high_action CognitoRiskConfiguration#high_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "highAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction\"}", isOptional: true)]
            public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction? HighAction
            {
                get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsHighAction?>();
            }

            /// <summary>low_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#low_action CognitoRiskConfiguration#low_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lowAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction\"}", isOptional: true)]
            public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction? LowAction
            {
                get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction?>();
            }

            /// <summary>medium_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#medium_action CognitoRiskConfiguration#medium_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mediumAction", typeJson: "{\"fqn\":\"aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction\"}", isOptional: true)]
            public aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction
            {
                get => GetInstanceProperty<aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsMediumAction?>();
            }
        }
    }
}
