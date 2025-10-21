using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiByValue(fqn: "azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches")]
    public class MaintenanceConfigurationInstallPatches : azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches
    {
        private object? _linux;

        /// <summary>linux block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#linux MaintenanceConfiguration#linux}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linux", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Linux
        {
            get => _linux;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _linux = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#reboot MaintenanceConfiguration#reboot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reboot
        {
            get;
            set;
        }

        private object? _windows;

        /// <summary>windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#windows MaintenanceConfiguration#windows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Windows
        {
            get => _windows;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesWindows[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesWindows).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _windows = value;
            }
        }
    }
}
