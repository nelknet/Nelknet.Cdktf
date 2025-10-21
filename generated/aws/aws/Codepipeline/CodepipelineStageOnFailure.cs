using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStageOnFailure")]
    public class CodepipelineStageOnFailure : aws.Codepipeline.ICodepipelineStageOnFailure
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureCondition\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineStageOnFailureCondition? Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#result Codepipeline#result}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Result
        {
            get;
            set;
        }

        /// <summary>retry_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_configuration Codepipeline#retry_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration? RetryConfiguration
        {
            get;
            set;
        }
    }
}
