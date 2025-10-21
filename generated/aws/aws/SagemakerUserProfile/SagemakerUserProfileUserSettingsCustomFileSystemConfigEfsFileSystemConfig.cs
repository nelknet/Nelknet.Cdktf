using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig")]
    public class SagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#file_system_id SagemakerUserProfile#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#file_system_path SagemakerUserProfile#file_system_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileSystemPath
        {
            get;
            set;
        }
    }
}
