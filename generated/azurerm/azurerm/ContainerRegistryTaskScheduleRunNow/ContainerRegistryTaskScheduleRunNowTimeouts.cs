using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTaskScheduleRunNow
{
    [JsiiByValue(fqn: "azurerm.containerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNowTimeouts")]
    public class ContainerRegistryTaskScheduleRunNowTimeouts : azurerm.ContainerRegistryTaskScheduleRunNow.IContainerRegistryTaskScheduleRunNowTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#create ContainerRegistryTaskScheduleRunNow#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#delete ContainerRegistryTaskScheduleRunNow#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#read ContainerRegistryTaskScheduleRunNow#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
