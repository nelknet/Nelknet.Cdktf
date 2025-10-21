using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig")]
    public class SagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_id SagemakerDomain#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_path SagemakerDomain#file_system_path}.</summary>
        [JsiiProperty(name: "fileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemPath
        {
            get;
            set;
        }
    }
}
