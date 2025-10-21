using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiByValue(fqn: "aws.ecsCluster.EcsClusterConfiguration")]
    public class EcsClusterConfiguration : aws.EcsCluster.IEcsClusterConfiguration
    {
        /// <summary>execute_command_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#execute_command_configuration EcsCluster#execute_command_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executeCommandConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
        public aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration
        {
            get;
            set;
        }

        /// <summary>managed_storage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#managed_storage_configuration EcsCluster#managed_storage_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedStorageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationManagedStorageConfiguration\"}", isOptional: true)]
        public aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration? ManagedStorageConfiguration
        {
            get;
            set;
        }
    }
}
