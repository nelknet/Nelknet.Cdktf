using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSmsConfiguration")]
    public interface ICognitoUserPoolSmsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsCallerArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_region CognitoUserPool#sns_region}.</summary>
        [JsiiProperty(name: "snsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSmsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
            [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsCallerArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_region CognitoUserPool#sns_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
