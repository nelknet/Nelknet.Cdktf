using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskPlatform")]
    public class ContainerRegistryTaskPlatform : azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#os ContainerRegistryTask#os}.</summary>
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        public string Os
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#architecture ContainerRegistryTask#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#variant ContainerRegistryTask#variant}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "variant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Variant
        {
            get;
            set;
        }
    }
}
