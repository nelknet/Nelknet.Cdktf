using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows")]
    public interface ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_auth_mode CognitoUserPool#custom_auth_mode}.</summary>
        [JsiiProperty(name: "customAuthMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomAuthMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_auth_mode CognitoUserPool#custom_auth_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customAuthMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomAuthMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
