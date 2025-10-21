using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiByValue(fqn: "azurerm.appService.AppServiceLogsApplicationLogs")]
    public class AppServiceLogsApplicationLogs : azurerm.AppService.IAppServiceLogsApplicationLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#azure_blob_storage AppService#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.AppService.IAppServiceLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#file_system_level AppService#file_system_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileSystemLevel
        {
            get;
            set;
        }
    }
}
