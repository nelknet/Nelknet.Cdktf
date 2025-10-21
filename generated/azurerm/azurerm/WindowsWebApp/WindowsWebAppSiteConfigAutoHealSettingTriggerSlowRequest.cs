using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest")]
    public class WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#count WindowsWebApp#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#interval WindowsWebApp#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#time_taken WindowsWebApp#time_taken}.</summary>
        [JsiiProperty(name: "timeTaken", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeTaken
        {
            get;
            set;
        }
    }
}
