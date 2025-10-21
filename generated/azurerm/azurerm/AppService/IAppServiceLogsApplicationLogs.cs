using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceLogsApplicationLogs), fullyQualifiedName: "azurerm.appService.AppServiceLogsApplicationLogs")]
    public interface IAppServiceLogsApplicationLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#azure_blob_storage AppService#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppService.IAppServiceLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#file_system_level AppService#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileSystemLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceLogsApplicationLogs), fullyQualifiedName: "azurerm.appService.AppServiceLogsApplicationLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceLogsApplicationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#azure_blob_storage AppService#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.AppService.IAppServiceLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.AppService.IAppServiceLogsApplicationLogsAzureBlobStorage?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#file_system_level AppService#file_system_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileSystemLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
