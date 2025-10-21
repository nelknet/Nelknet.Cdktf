using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotLogsHttpLogs), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs")]
    public interface ILinuxWebAppSlotLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#azure_blob_storage LinuxWebAppSlot#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#file_system LinuxWebAppSlot#file_system}
        /// </remarks>
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsFileSystem? FileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotLogsHttpLogs), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#azure_blob_storage LinuxWebAppSlot#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsAzureBlobStorage?>();
            }

            /// <summary>file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#file_system LinuxWebAppSlot#file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsFileSystem? FileSystem
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogsFileSystem?>();
            }
        }
    }
}
