using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem")]
    public class LinuxWebAppLogsHttpLogsFileSystem : azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_days LinuxWebApp#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#retention_in_mb LinuxWebApp#retention_in_mb}.</summary>
        [JsiiProperty(name: "retentionInMb", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInMb
        {
            get;
            set;
        }
    }
}
