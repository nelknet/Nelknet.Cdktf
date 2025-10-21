using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig")]
    public class SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig : aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_credentials_provider_arn SagemakerModel#repository_credentials_provider_arn}.</summary>
        [JsiiProperty(name: "repositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryCredentialsProviderArn
        {
            get;
            set;
        }
    }
}
