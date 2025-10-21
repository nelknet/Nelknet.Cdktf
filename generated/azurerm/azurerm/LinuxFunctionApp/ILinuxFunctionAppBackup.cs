using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppBackup), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppBackup")]
    public interface ILinuxFunctionAppBackup
    {
        /// <summary>The name which should be used for this Backup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#name LinuxFunctionApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#schedule LinuxFunctionApp#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppBackupSchedule\"}")]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppBackupSchedule Schedule
        {
            get;
        }

        /// <summary>The SAS URL to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_url LinuxFunctionApp#storage_account_url}
        /// </remarks>
        [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountUrl
        {
            get;
        }

        /// <summary>Should this backup job be enabled?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#enabled LinuxFunctionApp#enabled}
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

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppBackup), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppBackup")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppBackup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name which should be used for this Backup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#name LinuxFunctionApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#schedule LinuxFunctionApp#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppBackupSchedule\"}")]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppBackupSchedule Schedule
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppBackupSchedule>()!;
            }

            /// <summary>The SAS URL to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_url LinuxFunctionApp#storage_account_url}
            /// </remarks>
            [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Should this backup job be enabled?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#enabled LinuxFunctionApp#enabled}
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
