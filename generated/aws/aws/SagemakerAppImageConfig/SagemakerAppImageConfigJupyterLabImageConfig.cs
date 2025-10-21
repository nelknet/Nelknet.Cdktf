using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiByValue(fqn: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfig")]
    public class SagemakerAppImageConfigJupyterLabImageConfig : aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig
    {
        /// <summary>container_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#container_config SagemakerAppImageConfig#container_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfig\"}", isOptional: true)]
        public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigContainerConfig? ContainerConfig
        {
            get;
            set;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig\"}", isOptional: true)]
        public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig? FileSystemConfig
        {
            get;
            set;
        }
    }
}
