using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiInterface(nativeType: typeof(IMaintenanceConfigurationInstallPatches), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches")]
    public interface IMaintenanceConfigurationInstallPatches
    {
        /// <summary>linux block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#linux MaintenanceConfiguration#linux}
        /// </remarks>
        [JsiiProperty(name: "linux", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Linux
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#reboot MaintenanceConfiguration#reboot}.</summary>
        [JsiiProperty(name: "reboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reboot
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#windows MaintenanceConfiguration#windows}
        /// </remarks>
        [JsiiProperty(name: "windows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Windows
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMaintenanceConfigurationInstallPatches), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches")]
        internal sealed class _Proxy : DeputyBase, azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>linux block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#linux MaintenanceConfiguration#linux}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linux", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Linux
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#reboot MaintenanceConfiguration#reboot}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reboot
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>windows block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#windows MaintenanceConfiguration#windows}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Windows
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
