using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStageBeforeEntry")]
    public class CodepipelineStageBeforeEntry : aws.Codepipeline.ICodepipelineStageBeforeEntry
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryCondition\"}")]
        public aws.Codepipeline.ICodepipelineStageBeforeEntryCondition Condition
        {
            get;
            set;
        }
    }
}
