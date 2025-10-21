using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigVirtualApplicationVirtualDirectory")]
    public class WindowsWebAppSiteConfigVirtualApplicationVirtualDirectory : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#physical_path WindowsWebApp#physical_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "physicalPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhysicalPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#virtual_path WindowsWebApp#virtual_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualPath
        {
            get;
            set;
        }
    }
}
