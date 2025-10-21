using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerCodeRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerCodeRepository.SagemakerCodeRepositoryGitConfig")]
    public class SagemakerCodeRepositoryGitConfig : aws.SagemakerCodeRepository.ISagemakerCodeRepositoryGitConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#repository_url SagemakerCodeRepository#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#branch SagemakerCodeRepository#branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#secret_arn SagemakerCodeRepository#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }
    }
}
