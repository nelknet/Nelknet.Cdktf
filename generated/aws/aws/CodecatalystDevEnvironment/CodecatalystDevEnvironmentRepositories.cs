using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories")]
    public class CodecatalystDevEnvironmentRepositories : aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentRepositories
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#repository_name CodecatalystDevEnvironment#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#branch_name CodecatalystDevEnvironment#branch_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BranchName
        {
            get;
            set;
        }
    }
}
