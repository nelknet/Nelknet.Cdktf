using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineTriggerGitConfigurationPush")]
    public class CodepipelineTriggerGitConfigurationPush : aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush
    {
        /// <summary>branches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranches\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches? Branches
        {
            get;
            set;
        }

        /// <summary>file_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#file_paths Codepipeline#file_paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePaths\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths? FilePaths
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#tags Codepipeline#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTags\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags? Tags
        {
            get;
            set;
        }
    }
}
