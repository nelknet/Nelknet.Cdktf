using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineTriggerGitConfigurationPush), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPush")]
    public interface ICodepipelineTriggerGitConfigurationPush
    {
        /// <summary>branches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
        /// </remarks>
        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranches\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches? Branches
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
        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePaths\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths? FilePaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#tags Codepipeline#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineTriggerGitConfigurationPush), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPush")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>branches block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranches\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches? Branches
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches?>();
            }

            /// <summary>file_paths block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#file_paths Codepipeline#file_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePaths\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths? FilePaths
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#tags Codepipeline#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTags\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags? Tags
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags?>();
            }
        }
    }
}
