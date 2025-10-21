using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPoolClient
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolClientTokenValidityUnits), fullyQualifiedName: "aws.cognitoUserPoolClient.CognitoUserPoolClientTokenValidityUnits")]
    public interface ICognitoUserPoolClientTokenValidityUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#access_token CognitoUserPoolClient#access_token}.</summary>
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#id_token CognitoUserPoolClient#id_token}.</summary>
        [JsiiProperty(name: "idToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#refresh_token CognitoUserPoolClient#refresh_token}.</summary>
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolClientTokenValidityUnits), fullyQualifiedName: "aws.cognitoUserPoolClient.CognitoUserPoolClientTokenValidityUnits")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPoolClient.ICognitoUserPoolClientTokenValidityUnits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#access_token CognitoUserPoolClient#access_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#id_token CognitoUserPoolClient#id_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#refresh_token CognitoUserPoolClient#refresh_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
