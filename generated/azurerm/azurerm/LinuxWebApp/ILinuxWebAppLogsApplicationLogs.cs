using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppLogsApplicationLogs), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs")]
    public interface ILinuxWebAppLogsApplicationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#file_system_level LinuxWebApp#file_system_level}.</summary>
        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemLevel
        {
            get;
        }

        /// <summary>azure_blob_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#azure_blob_storage LinuxWebApp#azure_blob_storage}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppLogsApplicationLogs), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#file_system_level LinuxWebApp#file_system_level}.</summary>
            [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>azure_blob_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#azure_blob_storage LinuxWebApp#azure_blob_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
            public azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorage
            {
                get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage?>();
            }
        }
    }
}
