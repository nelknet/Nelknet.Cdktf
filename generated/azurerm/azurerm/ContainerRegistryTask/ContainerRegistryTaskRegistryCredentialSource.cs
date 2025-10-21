using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource")]
    public class ContainerRegistryTaskRegistryCredentialSource : azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#login_mode ContainerRegistryTask#login_mode}.</summary>
        [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
        public string LoginMode
        {
            get;
            set;
        }
    }
}
