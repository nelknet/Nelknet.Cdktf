using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolSignInPolicy")]
    public class CognitoUserPoolSignInPolicy : aws.CognitoUserPool.ICognitoUserPoolSignInPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#allowed_first_auth_factors CognitoUserPool#allowed_first_auth_factors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedFirstAuthFactors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedFirstAuthFactors
        {
            get;
            set;
        }
    }
}
