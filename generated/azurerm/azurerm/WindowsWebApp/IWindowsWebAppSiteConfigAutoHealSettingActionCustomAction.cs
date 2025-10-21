using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction")]
    public interface IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#executable WindowsWebApp#executable}.</summary>
        [JsiiProperty(name: "executable", typeJson: "{\"primitive\":\"string\"}")]
        string Executable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#parameters WindowsWebApp#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#executable WindowsWebApp#executable}.</summary>
            [JsiiProperty(name: "executable", typeJson: "{\"primitive\":\"string\"}")]
            public string Executable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#parameters WindowsWebApp#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parameters
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
