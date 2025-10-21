using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualDesktopWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceTimeouts")]
    public class DataAzurermVirtualDesktopWorkspaceTimeouts : azurerm.DataAzurermVirtualDesktopWorkspace.IDataAzurermVirtualDesktopWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#read DataAzurermVirtualDesktopWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
