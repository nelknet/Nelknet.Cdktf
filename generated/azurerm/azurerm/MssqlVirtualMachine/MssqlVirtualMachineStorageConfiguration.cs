using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration")]
    public class MssqlVirtualMachineStorageConfiguration : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#disk_type MssqlVirtualMachine#disk_type}.</summary>
        [JsiiProperty(name: "diskType", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_workload_type MssqlVirtualMachine#storage_workload_type}.</summary>
        [JsiiProperty(name: "storageWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageWorkloadType
        {
            get;
            set;
        }

        /// <summary>data_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_settings MssqlVirtualMachine#data_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationDataSettings\"}", isOptional: true)]
        public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationDataSettings? DataSettings
        {
            get;
            set;
        }

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_settings MssqlVirtualMachine#log_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationLogSettings\"}", isOptional: true)]
        public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationLogSettings? LogSettings
        {
            get;
            set;
        }

        private object? _systemDbOnDataDiskEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#system_db_on_data_disk_enabled MssqlVirtualMachine#system_db_on_data_disk_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemDbOnDataDiskEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SystemDbOnDataDiskEnabled
        {
            get => _systemDbOnDataDiskEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _systemDbOnDataDiskEnabled = value;
            }
        }

        /// <summary>temp_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#temp_db_settings MssqlVirtualMachine#temp_db_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tempDbSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings\"}", isOptional: true)]
        public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings? TempDbSettings
        {
            get;
            set;
        }
    }
}
