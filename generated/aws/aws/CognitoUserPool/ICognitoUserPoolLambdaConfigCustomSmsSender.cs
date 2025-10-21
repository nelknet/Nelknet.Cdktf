using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolLambdaConfigCustomSmsSender), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolLambdaConfigCustomSmsSender")]
    public interface ICognitoUserPoolLambdaConfigCustomSmsSender
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_arn CognitoUserPool#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_version CognitoUserPool#lambda_version}.</summary>
        [JsiiProperty(name: "lambdaVersion", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolLambdaConfigCustomSmsSender), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolLambdaConfigCustomSmsSender")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolLambdaConfigCustomSmsSender
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_arn CognitoUserPool#lambda_arn}.</summary>
            [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_version CognitoUserPool#lambda_version}.</summary>
            [JsiiProperty(name: "lambdaVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
