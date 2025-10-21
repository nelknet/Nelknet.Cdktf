using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStage), fullyQualifiedName: "aws.codepipeline.CodepipelineStage")]
    public interface ICodepipelineStage
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#action Codepipeline#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageAction\"},\"kind\":\"array\"}}]}}")]
        object Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>before_entry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#before_entry Codepipeline#before_entry}
        /// </remarks>
        [JsiiProperty(name: "beforeEntry", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineStageBeforeEntry? BeforeEntry
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_failure Codepipeline#on_failure}
        /// </remarks>
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineStageOnFailure? OnFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_success Codepipeline#on_success}
        /// </remarks>
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineStageOnSuccess? OnSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStage), fullyQualifiedName: "aws.codepipeline.CodepipelineStage")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#action Codepipeline#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageAction\"},\"kind\":\"array\"}}]}}")]
            public object Action
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>before_entry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#before_entry Codepipeline#before_entry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "beforeEntry", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineStageBeforeEntry? BeforeEntry
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageBeforeEntry?>();
            }

            /// <summary>on_failure block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_failure Codepipeline#on_failure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineStageOnFailure? OnFailure
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailure?>();
            }

            /// <summary>on_success block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_success Codepipeline#on_success}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineStageOnSuccess? OnSuccess
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnSuccess?>();
            }
        }
    }
}
