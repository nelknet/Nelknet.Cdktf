using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCodeSigningConfig
{
    [JsiiInterface(nativeType: typeof(ILambdaCodeSigningConfigPolicies), fullyQualifiedName: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies")]
    public interface ILambdaCodeSigningConfigPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
        [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
        string UntrustedArtifactOnDeployment
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCodeSigningConfigPolicies), fullyQualifiedName: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
            [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
            public string UntrustedArtifactOnDeployment
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
