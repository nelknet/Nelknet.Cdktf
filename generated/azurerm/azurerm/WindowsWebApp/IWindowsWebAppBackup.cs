using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppBackup), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppBackup")]
    public interface IWindowsWebAppBackup
    {
        /// <summary>The name which should be used for this Backup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#name WindowsWebApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#schedule WindowsWebApp#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppBackupSchedule\"}")]
        azurerm.WindowsWebApp.IWindowsWebAppBackupSchedule Schedule
        {
            get;
        }

        /// <summary>The SAS URL to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#storage_account_url WindowsWebApp#storage_account_url}
        /// </remarks>
        [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountUrl
        {
            get;
        }

        /// <summary>Should this backup job be enabled?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#enabled WindowsWebApp#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppBackup), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppBackup")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppBackup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name which should be used for this Backup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#name WindowsWebApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#schedule WindowsWebApp#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppBackupSchedule\"}")]
            public azurerm.WindowsWebApp.IWindowsWebAppBackupSchedule Schedule
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppBackupSchedule>()!;
            }

            /// <summary>The SAS URL to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#storage_account_url WindowsWebApp#storage_account_url}
            /// </remarks>
            [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Should this backup job be enabled?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#enabled WindowsWebApp#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
