using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoManagedUserPoolClient
{
    [JsiiByValue(fqn: "aws.cognitoManagedUserPoolClient.CognitoManagedUserPoolClientTokenValidityUnits")]
    public class CognitoManagedUserPoolClientTokenValidityUnits : aws.CognitoManagedUserPoolClient.ICognitoManagedUserPoolClientTokenValidityUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#access_token CognitoManagedUserPoolClient#access_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#id_token CognitoManagedUserPoolClient#id_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#refresh_token CognitoManagedUserPoolClient#refresh_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefreshToken
        {
            get;
            set;
        }
    }
}
