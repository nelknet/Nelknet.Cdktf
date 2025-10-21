using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction")]
    public interface ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#event_action CognitoRiskConfiguration#event_action}.</summary>
        [JsiiProperty(name: "eventAction", typeJson: "{\"primitive\":\"string\"}")]
        string EventAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#notify CognitoRiskConfiguration#notify}.</summary>
        [JsiiProperty(name: "notify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Notify
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationActionsLowAction
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#notify CognitoRiskConfiguration#notify}.</summary>
            [JsiiProperty(name: "notify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Notify
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
