using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest")]
    public class CodepipelineTriggerGitConfigurationPullRequest : aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest
    {
        /// <summary>branches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#branches Codepipeline#branches}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranches\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches? Branches
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#events Codepipeline#events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Events
        {
            get;
            set;
        }

        /// <summary>file_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#file_paths Codepipeline#file_paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths? FilePaths
        {
            get;
            set;
        }
    }
}
