using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode")]
    public class WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#count WindowsWebAppSlot#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#interval WindowsWebAppSlot#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#status_code_range WindowsWebAppSlot#status_code_range}.</summary>
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCodeRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#path WindowsWebAppSlot#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#sub_status WindowsWebAppSlot#sub_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SubStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#win32_status_code WindowsWebAppSlot#win32_status_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "win32StatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Win32StatusCode
        {
            get;
            set;
        }
    }
}
