using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs")]
    public class LinuxWebAppLogsApplicationLogs : azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#file_system_level LinuxWebApp#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemLevel
        {
            get;
            set;
        }

        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#azure_blob_storage LinuxWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }
    }
}
