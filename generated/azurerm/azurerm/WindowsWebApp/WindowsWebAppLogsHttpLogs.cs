using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs")]
    public class WindowsWebAppLogsHttpLogs : azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_blob_storage WindowsWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#file_system WindowsWebApp#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
