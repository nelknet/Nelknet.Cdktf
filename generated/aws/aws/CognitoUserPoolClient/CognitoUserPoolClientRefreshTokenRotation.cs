using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPoolClient
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPoolClient.CognitoUserPoolClientRefreshTokenRotation")]
    public class CognitoUserPoolClientRefreshTokenRotation : aws.CognitoUserPoolClient.ICognitoUserPoolClientRefreshTokenRotation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#feature CognitoUserPoolClient#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public string Feature
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#retry_grace_period_seconds CognitoUserPoolClient#retry_grace_period_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryGracePeriodSeconds
        {
            get;
            set;
        }
    }
}
