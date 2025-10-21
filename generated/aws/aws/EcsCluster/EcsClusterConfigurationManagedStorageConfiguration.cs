using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiByValue(fqn: "aws.ecsCluster.EcsClusterConfigurationManagedStorageConfiguration")]
    public class EcsClusterConfigurationManagedStorageConfiguration : aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#fargate_ephemeral_storage_kms_key_id EcsCluster#fargate_ephemeral_storage_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fargateEphemeralStorageKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FargateEphemeralStorageKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#kms_key_id EcsCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
