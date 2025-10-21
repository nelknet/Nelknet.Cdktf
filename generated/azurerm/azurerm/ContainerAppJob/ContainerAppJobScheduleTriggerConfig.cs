using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig")]
    public class ContainerAppJobScheduleTriggerConfig : azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#cron_expression ContainerAppJob#cron_expression}.</summary>
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string CronExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Parallelism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaCompletionCount
        {
            get;
            set;
        }
    }
}
