using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSetting")]
    public interface ILinuxWebAppSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#action LinuxWebApp#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#trigger LinuxWebApp#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger? Trigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSetting), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#action LinuxWebApp#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction\"}", isOptional: true)]
            public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction? Action
            {
                get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction?>();
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#trigger LinuxWebApp#trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
            public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger? Trigger
            {
                get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger?>();
            }
        }
    }
}
