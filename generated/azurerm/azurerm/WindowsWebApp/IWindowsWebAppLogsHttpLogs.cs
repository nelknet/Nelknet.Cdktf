using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppLogsHttpLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs")]
    public interface IWindowsWebAppLogsHttpLogs
    {
        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_blob_storage WindowsWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#file_system WindowsWebApp#file_system}
        /// </remarks>
        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem? FileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppLogsHttpLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_blob_storage WindowsWebApp#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage?>();
            }

            /// <summary>file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#file_system WindowsWebApp#file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem? FileSystem
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem?>();
            }
        }
    }
}
