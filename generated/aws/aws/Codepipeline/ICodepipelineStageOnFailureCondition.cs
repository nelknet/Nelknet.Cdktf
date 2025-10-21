using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageOnFailureCondition), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailureCondition")]
    public interface ICodepipelineStageOnFailureCondition
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#rule Codepipeline#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureConditionRule\"},\"kind\":\"array\"}}]}}")]
        object Rule
        {
            get;
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

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageOnFailureCondition), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailureCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageOnFailureCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#rule Codepipeline#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureConditionRule\"},\"kind\":\"array\"}}]}}")]
            public object Rule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#result Codepipeline#result}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Result
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
