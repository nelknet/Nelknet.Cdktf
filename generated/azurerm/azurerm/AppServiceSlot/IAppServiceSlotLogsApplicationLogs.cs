using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSlotLogsApplicationLogs), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogs")]
    public interface IAppServiceSlotLogsApplicationLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system_level AppServiceSlot#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileSystemLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSlotLogsApplicationLogs), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogsAzureBlobStorage?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system_level AppServiceSlot#file_system_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileSystemLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
