using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration")]
    public interface ICognitoUserPoolUsernameConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#case_sensitive CognitoUserPool#case_sensitive}.</summary>
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaseSensitive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#case_sensitive CognitoUserPool#case_sensitive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CaseSensitive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
