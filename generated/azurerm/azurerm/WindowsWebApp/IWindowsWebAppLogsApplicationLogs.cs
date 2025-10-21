using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppLogsApplicationLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogs")]
    public interface IWindowsWebAppLogsApplicationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#file_system_level WindowsWebApp#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemLevel
        {
            get;
        }

        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_blob_storage WindowsWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppLogsApplicationLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#file_system_level WindowsWebApp#file_system_level}.</summary>
            [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_blob_storage WindowsWebApp#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogsAzureBlobStorage?>();
            }
        }
    }
}
