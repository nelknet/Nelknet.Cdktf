using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCodeSigningConfig
{
    [JsiiInterface(nativeType: typeof(ILambdaCodeSigningConfigAllowedPublishers), fullyQualifiedName: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers")]
    public interface ILambdaCodeSigningConfigAllowedPublishers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
        [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SigningProfileVersionArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCodeSigningConfigAllowedPublishers), fullyQualifiedName: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
            [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SigningProfileVersionArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
