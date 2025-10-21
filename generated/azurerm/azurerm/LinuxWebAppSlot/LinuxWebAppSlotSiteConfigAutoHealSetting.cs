using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSetting")]
    public class LinuxWebAppSlotSiteConfigAutoHealSetting : azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#action LinuxWebAppSlot#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingAction? Action
        {
            get;
            set;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#trigger LinuxWebAppSlot#trigger}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingTrigger? Trigger
        {
            get;
            set;
        }
    }
}
