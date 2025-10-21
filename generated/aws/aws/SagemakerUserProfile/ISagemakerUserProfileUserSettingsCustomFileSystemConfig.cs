using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsCustomFileSystemConfig), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfig")]
    public interface ISagemakerUserProfileUserSettingsCustomFileSystemConfig
    {
        /// <summary>efs_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#efs_file_system_config SagemakerUserProfile#efs_file_system_config}
        /// </remarks>
        [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EfsFileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsCustomFileSystemConfig), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#efs_file_system_config SagemakerUserProfile#efs_file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EfsFileSystemConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
