using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings")]
    public class CognitoUserPoolUserAttributeUpdateSettings : aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#attributes_require_verification_before_update CognitoUserPool#attributes_require_verification_before_update}.</summary>
        [JsiiProperty(name: "attributesRequireVerificationBeforeUpdate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AttributesRequireVerificationBeforeUpdate
        {
            get;
            set;
        }
    }
}
