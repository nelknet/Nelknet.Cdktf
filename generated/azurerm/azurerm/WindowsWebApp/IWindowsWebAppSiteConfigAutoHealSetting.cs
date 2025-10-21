using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSetting")]
    public interface IWindowsWebAppSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#action WindowsWebApp#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction\"}")]
        azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction Action
        {
            get;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#trigger WindowsWebApp#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger\"}")]
        azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger Trigger
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#action WindowsWebApp#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction\"}")]
            public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction Action
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction>()!;
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#trigger WindowsWebApp#trigger}
            /// </remarks>
            [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger\"}")]
            public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger Trigger
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger>()!;
            }
        }
    }
}
