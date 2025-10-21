using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiByValue(fqn: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig")]
    public class SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig : aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#default_gid SagemakerAppImageConfig#default_gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#default_uid SagemakerAppImageConfig#default_uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultUid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#mount_path SagemakerAppImageConfig#mount_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPath
        {
            get;
            set;
        }
    }
}
