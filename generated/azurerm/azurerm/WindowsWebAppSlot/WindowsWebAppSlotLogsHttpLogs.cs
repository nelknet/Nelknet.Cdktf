using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs")]
    public class WindowsWebAppSlotLogsHttpLogs : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#azure_blob_storage WindowsWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#file_system WindowsWebAppSlot#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
