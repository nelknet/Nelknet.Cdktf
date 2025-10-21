using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigVirtualApplicationVirtualDirectory")]
    public interface IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#physical_path WindowsWebApp#physical_path}.</summary>
        [JsiiProperty(name: "physicalPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhysicalPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#virtual_path WindowsWebApp#virtual_path}.</summary>
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigVirtualApplicationVirtualDirectory")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#physical_path WindowsWebApp#physical_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "physicalPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhysicalPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#virtual_path WindowsWebApp#virtual_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
