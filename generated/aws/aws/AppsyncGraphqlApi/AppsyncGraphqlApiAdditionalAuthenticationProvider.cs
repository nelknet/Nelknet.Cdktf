using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProvider : aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>lambda_authorizer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#lambda_authorizer_config AppsyncGraphqlApi#lambda_authorizer_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAuthorizerConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig\"}", isOptional: true)]
        public aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true)]
        public aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig
        {
            get;
            set;
        }

        /// <summary>user_pool_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true)]
        public aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig
        {
            get;
            set;
        }
    }
}
