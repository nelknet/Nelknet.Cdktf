using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineTriggerGitConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfiguration")]
    public interface ICodepipelineTriggerGitConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#source_action_name Codepipeline#source_action_name}.</summary>
        [JsiiProperty(name: "sourceActionName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceActionName
        {
            get;
        }

        /// <summary>pull_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#pull_request Codepipeline#pull_request}
        /// </remarks>
        [JsiiProperty(name: "pullRequest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PullRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#push Codepipeline#push}
        /// </remarks>
        [JsiiProperty(name: "push", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Push
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineTriggerGitConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineTriggerGitConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#source_action_name Codepipeline#source_action_name}.</summary>
            [JsiiProperty(name: "sourceActionName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceActionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>pull_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#pull_request Codepipeline#pull_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PullRequest
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>push block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#push Codepipeline#push}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "push", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Push
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
