using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobScheduleTriggerConfig), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig")]
    public interface IContainerAppJobScheduleTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#cron_expression ContainerAppJob#cron_expression}.</summary>
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        string CronExpression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Parallelism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicaCompletionCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobScheduleTriggerConfig), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#cron_expression ContainerAppJob#cron_expression}.</summary>
            [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string CronExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Parallelism
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicaCompletionCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
