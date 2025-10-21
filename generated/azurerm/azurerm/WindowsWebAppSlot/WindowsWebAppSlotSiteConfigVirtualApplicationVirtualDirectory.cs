using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigVirtualApplicationVirtualDirectory")]
    public class WindowsWebAppSlotSiteConfigVirtualApplicationVirtualDirectory : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigVirtualApplicationVirtualDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#physical_path WindowsWebAppSlot#physical_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "physicalPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhysicalPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#virtual_path WindowsWebAppSlot#virtual_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualPath
        {
            get;
            set;
        }
    }
}
