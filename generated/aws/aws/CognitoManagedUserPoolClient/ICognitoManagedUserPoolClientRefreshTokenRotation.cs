using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoManagedUserPoolClient
{
    [JsiiInterface(nativeType: typeof(ICognitoManagedUserPoolClientRefreshTokenRotation), fullyQualifiedName: "aws.cognitoManagedUserPoolClient.CognitoManagedUserPoolClientRefreshTokenRotation")]
    public interface ICognitoManagedUserPoolClientRefreshTokenRotation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#feature CognitoManagedUserPoolClient#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        string Feature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#retry_grace_period_seconds CognitoManagedUserPoolClient#retry_grace_period_seconds}.</summary>
        [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoManagedUserPoolClientRefreshTokenRotation), fullyQualifiedName: "aws.cognitoManagedUserPoolClient.CognitoManagedUserPoolClientRefreshTokenRotation")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoManagedUserPoolClient.ICognitoManagedUserPoolClientRefreshTokenRotation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#feature CognitoManagedUserPoolClient#feature}.</summary>
            [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
            public string Feature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_managed_user_pool_client#retry_grace_period_seconds CognitoManagedUserPoolClient#retry_grace_period_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
