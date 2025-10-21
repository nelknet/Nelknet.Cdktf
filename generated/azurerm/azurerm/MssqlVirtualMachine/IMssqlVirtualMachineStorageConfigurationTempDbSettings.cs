using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineStorageConfigurationTempDbSettings), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings")]
    public interface IMssqlVirtualMachineStorageConfigurationTempDbSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
        [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultFilePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
        [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Luns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_count MssqlVirtualMachine#data_file_count}.</summary>
        [JsiiProperty(name: "dataFileCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataFileCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_growth_in_mb MssqlVirtualMachine#data_file_growth_in_mb}.</summary>
        [JsiiProperty(name: "dataFileGrowthInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataFileGrowthInMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_size_mb MssqlVirtualMachine#data_file_size_mb}.</summary>
        [JsiiProperty(name: "dataFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataFileSizeMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_growth_mb MssqlVirtualMachine#log_file_growth_mb}.</summary>
        [JsiiProperty(name: "logFileGrowthMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogFileGrowthMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_size_mb MssqlVirtualMachine#log_file_size_mb}.</summary>
        [JsiiProperty(name: "logFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogFileSizeMb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineStorageConfigurationTempDbSettings), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
            [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultFilePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
            [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Luns
            {
                get => GetInstanceProperty<double[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_count MssqlVirtualMachine#data_file_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFileCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataFileCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_growth_in_mb MssqlVirtualMachine#data_file_growth_in_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFileGrowthInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataFileGrowthInMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_size_mb MssqlVirtualMachine#data_file_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataFileSizeMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_growth_mb MssqlVirtualMachine#log_file_growth_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFileGrowthMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogFileGrowthMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_size_mb MssqlVirtualMachine#log_file_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogFileSizeMb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
