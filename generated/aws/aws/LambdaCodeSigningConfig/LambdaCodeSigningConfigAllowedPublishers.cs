using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCodeSigningConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers")]
    public class LambdaCodeSigningConfigAllowedPublishers : aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
        [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SigningProfileVersionArns
        {
            get;
            set;
        }
    }
}
