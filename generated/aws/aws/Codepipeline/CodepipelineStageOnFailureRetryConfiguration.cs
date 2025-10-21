using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration")]
    public class CodepipelineStageOnFailureRetryConfiguration : aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_mode Codepipeline#retry_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetryMode
        {
            get;
            set;
        }
    }
}
