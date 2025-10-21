using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolWebAuthnConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration")]
    public interface ICognitoUserPoolWebAuthnConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#relying_party_id CognitoUserPool#relying_party_id}.</summary>
        [JsiiProperty(name: "relyingPartyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelyingPartyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_verification CognitoUserPool#user_verification}.</summary>
        [JsiiProperty(name: "userVerification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserVerification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolWebAuthnConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#relying_party_id CognitoUserPool#relying_party_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relyingPartyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelyingPartyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_verification CognitoUserPool#user_verification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userVerification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserVerification
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
