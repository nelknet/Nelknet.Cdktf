using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiByValue(fqn: "azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogs")]
    public class AppServiceSlotLogsApplicationLogs : azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system_level AppServiceSlot#file_system_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileSystemLevel
        {
            get;
            set;
        }
    }
}
