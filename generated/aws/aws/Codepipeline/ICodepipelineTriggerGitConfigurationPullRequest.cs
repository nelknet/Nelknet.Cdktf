using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineTriggerGitConfigurationPullRequest), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest")]
    public interface ICodepipelineTriggerGitConfigurationPullRequest
    {
        /// <summary>branches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
        /// </remarks>
        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranches\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches? Branches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#events Codepipeline#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Events
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#file_paths Codepipeline#file_paths}
        /// </remarks>
        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths? FilePaths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineTriggerGitConfigurationPullRequest), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>branches block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranches\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches? Branches
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#events Codepipeline#events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Events
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>file_paths block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#file_paths Codepipeline#file_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths? FilePaths
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths?>();
            }
        }
    }
}
