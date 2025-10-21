using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfig")]
    public class SagemakerDomainDefaultUserSettingsCustomFileSystemConfig : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig
    {
        /// <summary>efs_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#efs_file_system_config SagemakerDomain#efs_file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig
        {
            get;
            set;
        }
    }
}
