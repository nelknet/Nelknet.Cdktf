using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiInterface(nativeType: typeof(IEcsClusterConfigurationExecuteCommandConfiguration), fullyQualifiedName: "aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration")]
    public interface IEcsClusterConfigurationExecuteCommandConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#kms_key_id EcsCluster#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#log_configuration EcsCluster#log_configuration}
        /// </remarks>
        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#logging EcsCluster#logging}.</summary>
        [JsiiProperty(name: "logging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logging
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsClusterConfigurationExecuteCommandConfiguration), fullyQualifiedName: "aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#kms_key_id EcsCluster#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#log_configuration EcsCluster#log_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}", isOptional: true)]
            public aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration
            {
                get => GetInstanceProperty<aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#logging EcsCluster#logging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logging
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
