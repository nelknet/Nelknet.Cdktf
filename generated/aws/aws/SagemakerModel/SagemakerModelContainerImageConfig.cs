using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelContainerImageConfig")]
    public class SagemakerModelContainerImageConfig : aws.SagemakerModel.ISagemakerModelContainerImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryAccessMode
        {
            get;
            set;
        }

        /// <summary>repository_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_auth_config SagemakerModel#repository_auth_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryAuthConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfig\"}", isOptional: true)]
        public aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig
        {
            get;
            set;
        }
    }
}
