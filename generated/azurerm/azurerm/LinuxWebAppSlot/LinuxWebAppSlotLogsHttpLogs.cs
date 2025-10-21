using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs")]
    public class LinuxWebAppSlotLogsHttpLogs : azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#azure_blob_storage LinuxWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#file_system LinuxWebAppSlot#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
