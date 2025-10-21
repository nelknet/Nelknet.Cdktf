using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction")]
    public class WindowsWebAppSiteConfigAutoHealSettingAction : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#action_type WindowsWebApp#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }

        /// <summary>custom_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#custom_action WindowsWebApp#custom_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customAction", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction? CustomAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#minimum_process_execution_time WindowsWebApp#minimum_process_execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumProcessExecutionTime
        {
            get;
            set;
        }
    }
}
