using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCodeSigningConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies")]
    public class LambdaCodeSigningConfigPolicies : aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
        [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
        public string UntrustedArtifactOnDeployment
        {
            get;
            set;
        }
    }
}
