using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppLogsHttpLogs")]
    public class LinuxWebAppLogsHttpLogs : azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#azure_blob_storage LinuxWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#file_system LinuxWebApp#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
