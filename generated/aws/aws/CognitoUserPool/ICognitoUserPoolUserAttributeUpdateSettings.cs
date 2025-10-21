using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUserAttributeUpdateSettings), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings")]
    public interface ICognitoUserPoolUserAttributeUpdateSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#attributes_require_verification_before_update CognitoUserPool#attributes_require_verification_before_update}.</summary>
        [JsiiProperty(name: "attributesRequireVerificationBeforeUpdate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AttributesRequireVerificationBeforeUpdate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUserAttributeUpdateSettings), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#attributes_require_verification_before_update CognitoUserPool#attributes_require_verification_before_update}.</summary>
            [JsiiProperty(name: "attributesRequireVerificationBeforeUpdate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AttributesRequireVerificationBeforeUpdate
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
