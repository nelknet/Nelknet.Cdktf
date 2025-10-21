using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSetting")]
    public class LinuxWebAppSiteConfigAutoHealSetting : azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#action LinuxWebApp#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction? Action
        {
            get;
            set;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#trigger LinuxWebApp#trigger}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger? Trigger
        {
            get;
            set;
        }
    }
}
