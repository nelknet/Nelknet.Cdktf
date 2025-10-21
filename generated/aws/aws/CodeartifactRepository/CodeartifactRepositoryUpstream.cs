using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeartifactRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codeartifactRepository.CodeartifactRepositoryUpstream")]
    public class CodeartifactRepositoryUpstream : aws.CodeartifactRepository.ICodeartifactRepositoryUpstream
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryName
        {
            get;
            set;
        }
    }
}
