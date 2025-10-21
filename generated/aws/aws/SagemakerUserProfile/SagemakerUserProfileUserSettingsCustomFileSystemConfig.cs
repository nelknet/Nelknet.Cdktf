using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfig")]
    public class SagemakerUserProfileUserSettingsCustomFileSystemConfig : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomFileSystemConfig
    {
        private object? _efsFileSystemConfig;

        /// <summary>efs_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#efs_file_system_config SagemakerUserProfile#efs_file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EfsFileSystemConfig
        {
            get => _efsFileSystemConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomFileSystemConfigEfsFileSystemConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _efsFileSystemConfig = value;
            }
        }
    }
}
