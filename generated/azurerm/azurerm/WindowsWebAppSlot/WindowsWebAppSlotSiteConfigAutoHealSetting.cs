using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSetting")]
    public class WindowsWebAppSlotSiteConfigAutoHealSetting : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSetting
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#action WindowsWebAppSlot#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingAction\"}")]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingAction Action
        {
            get;
            set;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#trigger WindowsWebAppSlot#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTrigger\"}")]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger Trigger
        {
            get;
            set;
        }
    }
}
