using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageOnFailureRetryConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration")]
    public interface ICodepipelineStageOnFailureRetryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_mode Codepipeline#retry_mode}.</summary>
        [JsiiProperty(name: "retryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetryMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageOnFailureRetryConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#retry_mode Codepipeline#retry_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetryMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
