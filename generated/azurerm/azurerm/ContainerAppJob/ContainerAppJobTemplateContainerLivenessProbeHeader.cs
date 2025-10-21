using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobTemplateContainerLivenessProbeHeader")]
    public class ContainerAppJobTemplateContainerLivenessProbeHeader : azurerm.ContainerAppJob.IContainerAppJobTemplateContainerLivenessProbeHeader
    {
        /// <summary>The HTTP Header Name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#name ContainerAppJob#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The HTTP Header value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#value ContainerAppJob#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
