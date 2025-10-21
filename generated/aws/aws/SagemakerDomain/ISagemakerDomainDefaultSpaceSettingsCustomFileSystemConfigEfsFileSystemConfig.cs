using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig")]
    public interface ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_id SagemakerDomain#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_path SagemakerDomain#file_system_path}.</summary>
        [JsiiProperty(name: "fileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_id SagemakerDomain#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#file_system_path SagemakerDomain#file_system_path}.</summary>
            [JsiiProperty(name: "fileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
