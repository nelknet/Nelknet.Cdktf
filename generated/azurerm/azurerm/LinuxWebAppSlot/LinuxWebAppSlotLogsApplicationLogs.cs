using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogs")]
    public class LinuxWebAppSlotLogsApplicationLogs : azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#file_system_level LinuxWebAppSlot#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemLevel
        {
            get;
            set;
        }

        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#azure_blob_storage LinuxWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }
    }
}
