using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsCodeRepository")]
    public class SagemakerSpaceSpaceSettingsJupyterServerAppSettingsCodeRepository : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettingsCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#repository_url SagemakerSpace#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryUrl
        {
            get;
            set;
        }
    }
}
