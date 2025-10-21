using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageBeforeEntry), fullyQualifiedName: "aws.codepipeline.CodepipelineStageBeforeEntry")]
    public interface ICodepipelineStageBeforeEntry
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryCondition\"}")]
        aws.Codepipeline.ICodepipelineStageBeforeEntryCondition Condition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageBeforeEntry), fullyQualifiedName: "aws.codepipeline.CodepipelineStageBeforeEntry")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageBeforeEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryCondition\"}")]
            public aws.Codepipeline.ICodepipelineStageBeforeEntryCondition Condition
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageBeforeEntryCondition>()!;
            }
        }
    }
}
