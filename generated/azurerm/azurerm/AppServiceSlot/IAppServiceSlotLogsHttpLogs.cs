using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSlotLogsHttpLogs), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs")]
    public interface IAppServiceSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system AppServiceSlot#file_system}
        /// </remarks>
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem? FileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSlotLogsHttpLogs), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#azure_blob_storage AppServiceSlot#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage?>();
            }

            /// <summary>file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#file_system AppServiceSlot#file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem? FileSystem
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem?>();
            }
        }
    }
}
