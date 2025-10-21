using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiByValue(fqn: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig")]
    public class SagemakerAppImageConfigCodeEditorAppImageConfig : aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig
    {
        /// <summary>container_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#container_config SagemakerAppImageConfig#container_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig\"}", isOptional: true)]
        public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig? ContainerConfig
        {
            get;
            set;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}", isOptional: true)]
        public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig
        {
            get;
            set;
        }
    }
}
