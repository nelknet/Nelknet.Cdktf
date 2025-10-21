using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPoolClient
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolClientRefreshTokenRotation), fullyQualifiedName: "aws.cognitoUserPoolClient.CognitoUserPoolClientRefreshTokenRotation")]
    public interface ICognitoUserPoolClientRefreshTokenRotation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#feature CognitoUserPoolClient#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        string Feature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#retry_grace_period_seconds CognitoUserPoolClient#retry_grace_period_seconds}.</summary>
        [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolClientRefreshTokenRotation), fullyQualifiedName: "aws.cognitoUserPoolClient.CognitoUserPoolClientRefreshTokenRotation")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPoolClient.ICognitoUserPoolClientRefreshTokenRotation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#feature CognitoUserPoolClient#feature}.</summary>
            [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
            public string Feature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_client#retry_grace_period_seconds CognitoUserPoolClient#retry_grace_period_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
