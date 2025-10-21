using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPoolClient
{
    [JsiiByValue(fqn: "aws.cognitoUserPoolClient.CognitoUserPoolClientTokenValidityUnits")]
    public class CognitoUserPoolClientTokenValidityUnits : aws.CognitoUserPoolClient.ICognitoUserPoolClientTokenValidityUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#access_token CognitoUserPoolClient#access_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#id_token CognitoUserPoolClient#id_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#refresh_token CognitoUserPoolClient#refresh_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefreshToken
        {
            get;
            set;
        }
    }
}
