using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiByValue(fqn: "azurerm.appService.AppServiceLogsHttpLogs")]
    public class AppServiceLogsHttpLogs : azurerm.AppService.IAppServiceLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#azure_blob_storage AppService#azure_blob_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public azurerm.AppService.IAppServiceLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get;
            set;
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#file_system AppService#file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsHttpLogsFileSystem\"}", isOptional: true)]
        public azurerm.AppService.IAppServiceLogsHttpLogsFileSystem? FileSystem
        {
            get;
            set;
        }
    }
}
