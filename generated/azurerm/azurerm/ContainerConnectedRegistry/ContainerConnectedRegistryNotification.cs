using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerConnectedRegistry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerConnectedRegistry.ContainerConnectedRegistryNotification")]
    public class ContainerConnectedRegistryNotification : azurerm.ContainerConnectedRegistry.IContainerConnectedRegistryNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#action ContainerConnectedRegistry#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#name ContainerConnectedRegistry#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#digest ContainerConnectedRegistry#digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Digest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#tag ContainerConnectedRegistry#tag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tag
        {
            get;
            set;
        }
    }
}
