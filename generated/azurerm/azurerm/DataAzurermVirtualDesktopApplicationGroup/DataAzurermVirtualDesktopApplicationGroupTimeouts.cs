using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualDesktopApplicationGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupTimeouts")]
    public class DataAzurermVirtualDesktopApplicationGroupTimeouts : azurerm.DataAzurermVirtualDesktopApplicationGroup.IDataAzurermVirtualDesktopApplicationGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#read DataAzurermVirtualDesktopApplicationGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
