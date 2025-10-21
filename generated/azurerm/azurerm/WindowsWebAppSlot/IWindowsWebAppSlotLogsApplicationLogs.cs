using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotLogsApplicationLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs")]
    public interface IWindowsWebAppSlotLogsApplicationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#file_system_level WindowsWebAppSlot#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemLevel
        {
            get;
        }

        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#azure_blob_storage WindowsWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotLogsApplicationLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#file_system_level WindowsWebAppSlot#file_system_level}.</summary>
            [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#azure_blob_storage WindowsWebAppSlot#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage?>();
            }
        }
    }
}
