using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageOnSuccess), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnSuccess")]
    public interface ICodepipelineStageOnSuccess
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessCondition\"}")]
        aws.Codepipeline.ICodepipelineStageOnSuccessCondition Condition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageOnSuccess), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnSuccess")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageOnSuccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessCondition\"}")]
            public aws.Codepipeline.ICodepipelineStageOnSuccessCondition Condition
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnSuccessCondition>()!;
            }
        }
    }
}
