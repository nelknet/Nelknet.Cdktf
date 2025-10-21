using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigAutoHealSettingAction")]
    public class LinuxWebAppSlotSiteConfigAutoHealSettingAction : azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigAutoHealSettingAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#action_type LinuxWebAppSlot#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#minimum_process_execution_time LinuxWebAppSlot#minimum_process_execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumProcessExecutionTime
        {
            get;
            set;
        }
    }
}
