using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration")]
    public class CognitoUserPoolWebAuthnConfiguration : aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#relying_party_id CognitoUserPool#relying_party_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relyingPartyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelyingPartyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_verification CognitoUserPool#user_verification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userVerification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserVerification
        {
            get;
            set;
        }
    }
}
