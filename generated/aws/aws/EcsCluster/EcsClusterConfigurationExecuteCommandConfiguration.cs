using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiByValue(fqn: "aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration")]
    public class EcsClusterConfigurationExecuteCommandConfiguration : aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#kms_key_id EcsCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>log_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#log_configuration EcsCluster#log_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}", isOptional: true)]
        public aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#logging EcsCluster#logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Logging
        {
            get;
            set;
        }
    }
}
