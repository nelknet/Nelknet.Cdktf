using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoManagedUserPoolClient
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoManagedUserPoolClient.CognitoManagedUserPoolClientRefreshTokenRotation")]
    public class CognitoManagedUserPoolClientRefreshTokenRotation : aws.CognitoManagedUserPoolClient.ICognitoManagedUserPoolClientRefreshTokenRotation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#feature CognitoManagedUserPoolClient#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public string Feature
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#retry_grace_period_seconds CognitoManagedUserPoolClient#retry_grace_period_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryGracePeriodSeconds
        {
            get;
            set;
        }
    }
}
