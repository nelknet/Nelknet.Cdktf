using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogsAzureBlobStorage")]
    public class WindowsWebAppLogsApplicationLogsAzureBlobStorage : azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogsAzureBlobStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#level WindowsWebApp#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public string Level
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#retention_in_days WindowsWebApp#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#sas_url WindowsWebApp#sas_url}.</summary>
        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string SasUrl
        {
            get;
            set;
        }
    }
}
