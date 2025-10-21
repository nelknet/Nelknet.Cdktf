using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTokenPassword
{
    [JsiiByValue(fqn: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1")]
    public class ContainerRegistryTokenPasswordPassword1 : azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#expiry ContainerRegistryTokenPassword#expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expiry
        {
            get;
            set;
        }
    }
}
