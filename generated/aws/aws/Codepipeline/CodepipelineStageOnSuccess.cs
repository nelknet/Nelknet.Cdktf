using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStageOnSuccess")]
    public class CodepipelineStageOnSuccess : aws.Codepipeline.ICodepipelineStageOnSuccess
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessCondition\"}")]
        public aws.Codepipeline.ICodepipelineStageOnSuccessCondition Condition
        {
            get;
            set;
        }
    }
}
