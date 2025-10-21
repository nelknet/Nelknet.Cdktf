using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings")]
    public class MssqlVirtualMachineStorageConfigurationTempDbSettings : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
        [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultFilePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
        [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Luns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_count MssqlVirtualMachine#data_file_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFileCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataFileCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_growth_in_mb MssqlVirtualMachine#data_file_growth_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFileGrowthInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataFileGrowthInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#data_file_size_mb MssqlVirtualMachine#data_file_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataFileSizeMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_growth_mb MssqlVirtualMachine#log_file_growth_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFileGrowthMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogFileGrowthMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_file_size_mb MssqlVirtualMachine#log_file_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogFileSizeMb
        {
            get;
            set;
        }
    }
}
