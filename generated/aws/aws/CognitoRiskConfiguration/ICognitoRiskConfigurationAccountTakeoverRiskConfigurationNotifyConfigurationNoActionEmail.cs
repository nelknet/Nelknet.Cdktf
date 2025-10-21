using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoRiskConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail")]
    public interface ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
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

        [JsiiTypeProxy(nativeType: typeof(ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail), fullyQualifiedName: "aws.cognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoRiskConfiguration.ICognitoRiskConfigurationAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
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
