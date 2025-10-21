using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting")]
    public class ContainerRegistryTaskAgentSetting : azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#cpu ContainerRegistryTask#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Cpu
        {
            get;
            set;
        }
    }
}
