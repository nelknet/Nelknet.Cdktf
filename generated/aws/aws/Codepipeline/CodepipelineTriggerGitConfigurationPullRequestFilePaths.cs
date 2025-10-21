using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths")]
    public class CodepipelineTriggerGitConfigurationPullRequestFilePaths : aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#excludes Codepipeline#excludes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Excludes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#includes Codepipeline#includes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Includes
        {
            get;
            set;
        }
    }
}
