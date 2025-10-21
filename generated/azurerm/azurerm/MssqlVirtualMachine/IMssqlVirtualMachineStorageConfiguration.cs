using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineStorageConfiguration), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration")]
    public interface IMssqlVirtualMachineStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#disk_type MssqlVirtualMachine#disk_type}.</summary>
        [JsiiProperty(name: "diskType", typeJson: "{\"primitive\":\"string\"}")]
        string DiskType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_workload_type MssqlVirtualMachine#storage_workload_type}.</summary>
        [JsiiProperty(name: "storageWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageWorkloadType
        {
            get;
        }

        /// <summary>data_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_settings MssqlVirtualMachine#data_settings}
        /// </remarks>
        [JsiiProperty(name: "dataSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationDataSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationDataSettings? DataSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_settings MssqlVirtualMachine#log_settings}
        /// </remarks>
        [JsiiProperty(name: "logSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationLogSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationLogSettings? LogSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#system_db_on_data_disk_enabled MssqlVirtualMachine#system_db_on_data_disk_enabled}.</summary>
        [JsiiProperty(name: "systemDbOnDataDiskEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SystemDbOnDataDiskEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>temp_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#temp_db_settings MssqlVirtualMachine#temp_db_settings}
        /// </remarks>
        [JsiiProperty(name: "tempDbSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings? TempDbSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineStorageConfiguration), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#disk_type MssqlVirtualMachine#disk_type}.</summary>
            [JsiiProperty(name: "diskType", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_workload_type MssqlVirtualMachine#storage_workload_type}.</summary>
            [JsiiProperty(name: "storageWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageWorkloadType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_settings MssqlVirtualMachine#data_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationDataSettings\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationDataSettings? DataSettings
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationDataSettings?>();
            }

            /// <summary>log_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_settings MssqlVirtualMachine#log_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationLogSettings\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationLogSettings? LogSettings
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationLogSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#system_db_on_data_disk_enabled MssqlVirtualMachine#system_db_on_data_disk_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemDbOnDataDiskEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SystemDbOnDataDiskEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>temp_db_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#temp_db_settings MssqlVirtualMachine#temp_db_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tempDbSettings", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings? TempDbSettings
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings?>();
            }
        }
    }
}
