using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction")]
    public class LinuxWebAppSiteConfigAutoHealSettingAction : azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#action_type LinuxWebApp#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#minimum_process_execution_time LinuxWebApp#minimum_process_execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumProcessExecutionTime
        {
            get;
            set;
        }
    }
}
