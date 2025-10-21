using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs")]
    public interface IWindowsWebAppSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#azure_blob_storage WindowsWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#file_system WindowsWebAppSlot#file_system}
        /// </remarks>
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem? FileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotLogsHttpLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#azure_blob_storage WindowsWebAppSlot#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage?>();
            }

            /// <summary>file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#file_system WindowsWebAppSlot#file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem? FileSystem
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem?>();
            }
        }
    }
}
