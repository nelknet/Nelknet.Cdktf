using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository")]
    public class SagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#repository_url SagemakerUserProfile#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryUrl
        {
            get;
            set;
        }
    }
}
