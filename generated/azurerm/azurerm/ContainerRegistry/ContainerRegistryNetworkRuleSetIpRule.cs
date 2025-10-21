using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistry
{
    [JsiiByValue(fqn: "azurerm.containerRegistry.ContainerRegistryNetworkRuleSetIpRule")]
    public class ContainerRegistryNetworkRuleSetIpRule : azurerm.ContainerRegistry.IContainerRegistryNetworkRuleSetIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#action ContainerRegistry#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#ip_range ContainerRegistry#ip_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpRange
        {
            get;
            set;
        }
    }
}
