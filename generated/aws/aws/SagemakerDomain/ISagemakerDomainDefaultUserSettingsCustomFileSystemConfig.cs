using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfig")]
    public interface ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig
    {
        /// <summary>efs_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#efs_file_system_config SagemakerDomain#efs_file_system_config}
        /// </remarks>
        [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#efs_file_system_config SagemakerDomain#efs_file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig?>();
            }
        }
    }
}
