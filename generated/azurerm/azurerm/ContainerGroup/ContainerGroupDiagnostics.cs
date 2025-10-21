using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerGroup.ContainerGroupDiagnostics")]
    public class ContainerGroupDiagnostics : azurerm.ContainerGroup.IContainerGroupDiagnostics
    {
        /// <summary>log_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#log_analytics ContainerGroup#log_analytics}
        /// </remarks>
        [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupDiagnosticsLogAnalytics\"}")]
        public azurerm.ContainerGroup.IContainerGroupDiagnosticsLogAnalytics LogAnalytics
        {
            get;
            set;
        }
    }
}
