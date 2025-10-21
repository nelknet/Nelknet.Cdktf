using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail")]
    public interface ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#html_body CognitoRiskConfiguration#html_body}.</summary>
        [JsiiProperty(name: "htmlBody", typeJson: "{\"primitive\":\"string\"}")]
        string HtmlBody
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#subject CognitoRiskConfiguration#subject}.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        string Subject
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#text_body CognitoRiskConfiguration#text_body}.</summary>
        [JsiiProperty(name: "textBody", typeJson: "{\"primitive\":\"string\"}")]
        string TextBody
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#html_body CognitoRiskConfiguration#html_body}.</summary>
            [JsiiProperty(name: "htmlBody", typeJson: "{\"primitive\":\"string\"}")]
            public string HtmlBody
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#subject CognitoRiskConfiguration#subject}.</summary>
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
            public string Subject
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#text_body CognitoRiskConfiguration#text_body}.</summary>
            [JsiiProperty(name: "textBody", typeJson: "{\"primitive\":\"string\"}")]
            public string TextBody
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
