using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode")]
    public class LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode : azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#count LinuxWebApp#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#interval LinuxWebApp#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#status_code_range LinuxWebApp#status_code_range}.</summary>
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCodeRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#path LinuxWebApp#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#sub_status LinuxWebApp#sub_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SubStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#win32_status_code LinuxWebApp#win32_status_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "win32StatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Win32StatusCode
        {
            get;
            set;
        }
    }
}
