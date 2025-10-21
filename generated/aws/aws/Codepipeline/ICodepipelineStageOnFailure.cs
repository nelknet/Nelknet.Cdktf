using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageOnFailure), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailure")]
    public interface ICodepipelineStageOnFailure
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineStageOnFailureCondition? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#result Codepipeline#result}.</summary>
        [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Result
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_configuration Codepipeline#retry_configuration}
        /// </remarks>
        [JsiiProperty(name: "retryConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration? RetryConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageOnFailure), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailure")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageOnFailure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#condition Codepipeline#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureCondition\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineStageOnFailureCondition? Condition
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailureCondition?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#result Codepipeline#result}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Result
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retry_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_configuration Codepipeline#retry_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration? RetryConfiguration
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration?>();
            }
        }
    }
}
