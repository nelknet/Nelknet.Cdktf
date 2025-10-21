using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiByValue(fqn: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs")]
    public class AppServiceSlotLogsHttpLogs : azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system AppServiceSlot#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
